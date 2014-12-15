using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Siapotik
{
    public partial class frmOrder : Form
    {
        SqlConnection conn;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            cekSupplier();
        }

        private void dgvOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvOrders.Rows[e.RowIndex].Cells[0].Value = dgvOrders.Rows[e.RowIndex].Cells[0].Value;
                conn.Open();
                string sql = "Select * FROM T_Obat where ID_Obat = '" + dgvOrders.Rows[e.RowIndex].Cells[0].Value + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOrders.Rows[e.RowIndex].Cells[1].Value = reader.GetString(2);
                    dgvOrders.Rows[e.RowIndex].Cells[2].Value = 0;
                    dgvOrders.Rows[e.RowIndex].Cells[3].Value = reader.GetString(6);
                }
                conn.Close();
            }
            hitungItem();
        }

        private void hitungItem()
        {
            long line = 0;
            int rows = dgvOrders.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvOrders.Rows[i].Cells[2].Value);
                txtTotalItem.Text = line.ToString();
            }
        }

        private void cekObat()
        {
            Obat.Items.Clear();
            conn.Open();
            string sql = "Select * from T_Obat";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Obat.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void cekSupplier()
        {
            conn.Open();
            txtIDs.Items.Clear();
            string sql = "Select ID_Supplier from T_Supplier";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIDs.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void txtIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select Nama,Alamat from T_Supplier where ID_Supplier = '" + txtIDs.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNamas.Text = (reader.GetString(0));
                txtAlamat.Text = (reader.GetString(1));
            }
            conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvOrders.SelectedRows)
            {
                dgvOrders.Rows.RemoveAt(item.Index);
                MessageBox.Show("Data Berhasil Dihapus");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            cekObat();
            aktif();
            bersih();
            btnSimpan.Enabled = false;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (txtFaktur.Text == "")
            {
                MessageBox.Show("No.Faktur Belum Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFaktur.Focus();
            }
            else if (txtIDs.Text == "")
            {
                MessageBox.Show("Kode Supplier Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIDs.Focus();
            }
            else if (dgvOrders.Rows.Count - 1 == 0)
            {
                MessageBox.Show("Data Obat Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtTotalItem.Text =="0")
            {
                MessageBox.Show("Jumlah Obat Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql, sql1;
                    sql = String.Concat("Insert Into T_Pemesanan(Kode_Faktur,ID_Supplier,Total_Item,Tanggal) Values(@p0,@p1,@p2,@p3)");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@p0", txtFaktur.Text);
                    cmd.Parameters.AddWithValue("@p1", txtIDs.Text);
                    cmd.Parameters.AddWithValue("@p2", txtTotalItem.Text);
                    cmd.Parameters.AddWithValue("@p3", dateOrder.Text);
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dgvOrders.Rows.Count - 1; i++)
                    {
                        sql1 = String.Concat("Insert Into T_DetailPemesanan (Kode_Faktur,ID_Obat,Jumlah) Values(@p5,@p6,@p7)");
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql1;
                        cmd.Parameters.AddWithValue("@p5", txtFaktur.Text);
                        cmd.Parameters.AddWithValue("@p6", dgvOrders.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p7", dgvOrders.Rows[i].Cells[2].Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data Berhasil Disimpan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    disTxt();
                    conn.Close();
                    btnSimpan.Enabled = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Terjadi kesalahan karena: " + err);
                }
            }
        }

        private void bersih()
        {
            txtFaktur.Clear();
            txtIDs.Text = "";
            txtAlamat.Clear();
            txtNamas.Clear();
            txtTotalItem.Clear();
            dgvOrders.Rows.Clear();
        }

        private void disTxt()
        {
            txtFaktur.Enabled = false;
            txtIDs.Enabled = false;
            dgvOrders.Enabled = false;
            btnBatal.Enabled = false;
            lblAds.Enabled = false;
            btnCetak.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void aktif()
        {
            txtFaktur.Enabled = true;
            txtIDs.Enabled = true;
            dgvOrders.Enabled = true;
            btnBatal.Enabled = true;
            lblAds.Enabled = true;
            btnCetak.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
            disTxt();
            btnSimpan.Enabled = true;
        }

        private void lblAds_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.Show();
        }

        private void txtIDs_Click(object sender, EventArgs e)
        {
            cekSupplier();
        }
    }
}
