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
    public partial class frmPembelian : Form
    {
        SqlConnection conn;
        public frmPembelian()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            cekSupplier();
        }

        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvOrder.Rows[e.RowIndex].Cells[0].Value = dgvOrder.Rows[e.RowIndex].Cells[0].Value;
                conn.Open();
                string sql = "Select * FROM T_Obat where ID_Obat = '" + dgvOrder.Rows[e.RowIndex].Cells[0].Value + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOrder.Rows[e.RowIndex].Cells[1].Value = reader.GetString(2);
                    dgvOrder.Rows[e.RowIndex].Cells[2].Value = reader.GetInt64(3);
                    dgvOrder.Rows[e.RowIndex].Cells[3].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[4].Value = reader.GetInt64(4);
                    dgvOrder.Rows[e.RowIndex].Cells[5].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[6].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[7].Value = reader.GetString(6);
                }
                conn.Close();
            }

            if (e.ColumnIndex == 3)
            {
                long cell4 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[4].Value);
                long cell3 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[3].Value);
                long cell2 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[2].Value);

                dgvOrder.Rows[e.RowIndex].Cells[5].Value = cell4 + cell3;
                dgvOrder.Rows[e.RowIndex].Cells[6].Value = cell2 * cell3;
            }

            hitungItem();
            hitungBayar();
        }

        private void hitungItem()
        {
            long line = 0;
            int rows = dgvOrder.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
               line = line + Convert.ToInt64(dgvOrder.Rows[i].Cells[3].Value);
               txtTotalItem.Text = line.ToString();
            }
        }

        private void hitungBayar()
        {
            long line = 0;
            int rows = dgvOrder.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvOrder.Rows[i].Cells[6].Value);
                txtTotalBayar.Text = line.ToString();
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
            foreach (DataGridViewRow item in this.dgvOrder.SelectedRows)
            {
                dgvOrder.Rows.RemoveAt(item.Index);
                MessageBox.Show("Data Berhasil Dihapus");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "Tambah")
            {
                cekObat();
                aktif();
                bersih();
                btnSimpan.Text = "Simpan";
            }
            else
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
                else if (dgvOrder.Rows.Count-1 == 0)
                {
                    MessageBox.Show("Data Obat Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, sql1, ubah;
                        sql = String.Concat("Insert Into T_Penerimaan (Kode_Faktur,ID_Supplier,Total_Item,Total_Bayar,Tanggal) Values(@p0,@p1,@p2,@p3,@p4)");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@p0", txtFaktur.Text);
                        cmd.Parameters.AddWithValue("@p1", txtIDs.Text);
                        cmd.Parameters.AddWithValue("@p2", txtTotalItem.Text);
                        cmd.Parameters.AddWithValue("@p3", txtTotalBayar.Text);
                        cmd.Parameters.AddWithValue("@p4", dateOrder.Text);
                        cmd.ExecuteNonQuery();
                        //for (int i = 0; i < rows - 1; i++)
                        //{
                        //    string value1 = txtFaktur.Text;
                        //    string value2 = dgvOrder.Rows[i].Cells[0].Value.ToString();
                        //    string value3 = dgvOrder.Rows[i].Cells[3].Value.ToString();
                        //    sql1 = String.Concat("Insert Into T_DetailPenerimaan Values ('",
                        //    value1, "', '", value2, "', '", value3, "')");
                        //    cmd = new SqlCommand();
                        //    cmd.Connection = conn;
                        //    cmd.CommandText = sql1;
                        //    cmd.ExecuteNonQuery();
                        //}
                        for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                        {
                            sql1 = String.Concat("Insert Into T_DetailPenerimaan (Kode_Faktur,ID_Obat,Jumlah) Values(@p5,@p6,@p7)");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql1;
                            cmd.Parameters.AddWithValue("@p5", txtFaktur.Text);
                            cmd.Parameters.AddWithValue("@p6", dgvOrder.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p7", dgvOrder.Rows[i].Cells[3].Value);
                            cmd.ExecuteNonQuery();
                            ubah = String.Concat("Update T_Obat SET Stok = Stok+@p9, Harga_Obat=@p10 WHERE ID_Obat=@p8");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = ubah;
                            cmd.Parameters.AddWithValue("@p8", dgvOrder.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p9", dgvOrder.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@p10", dgvOrder.Rows[i].Cells[2].Value);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data Berhasil Disimpan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        disTxt();
                        conn.Close();
                        btnSimpan.Text = "Tambah";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Terjadi kesalahan karena: " + err);
                    }
                }
            }
        }

        private void bersih()
        {
            txtFaktur.Clear();
            txtIDs.Text = "";
            txtAlamat.Clear();
            txtNamas.Clear();
            txtTotalBayar.Clear();
            txtTotalItem.Clear();
            dgvOrder.Rows.Clear();
        }

        private void disTxt()
        {
            txtFaktur.Enabled = false;
            txtIDs.Enabled = false;
            dgvOrder.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            lblAds.Enabled = false;
        }

        private void aktif()
        {
            txtFaktur.Enabled = true;
            txtIDs.Enabled = true;
            dgvOrder.Enabled = true;
            btnBatal.Enabled = true;
            btnHapus.Enabled = true;
            lblAds.Enabled = true;
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            bersih();
            disTxt();
            btnSimpan.Text = "Tambah";
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

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvOrder.SelectedRows)
            {
                dgvOrder.Rows.RemoveAt(item.Index);
                MessageBox.Show("Data Berhasil Dihapus");
                hitungBayar();
                hitungItem();
                if (dgvOrder.Rows.Count - 1 == 0)
                {
                    txtTotalItem.Text = "0";
                    txtTotalBayar.Text = "0";
                }
            }
        }
    }
}
