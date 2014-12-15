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
    public partial class frmObats : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmObats()
        {
            InitializeComponent();
        }

        private void frmObats_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            tampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                bersihTxt();
                aktif();
                btnTambah.Text = "Simpan";
                btnHapus.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql, pesan;
                    sql = String.Concat("Insert Into T_DataObat Values ('", kdObat.Text, "', '", txtNama.Text, "', '", txtKeterangan.Text, "')");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    DialogResult result = MessageBox.Show("Simpan Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Disimpan");
                        MessageBox.Show(pesan, "Success");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Terjadi kesalahan karena: " + err);
                }
                conn.Close();
                bersihTxt();
                tampilData();
                btnTambah.Text = "Tambah";
                btnHapus.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                aktif();
                kdObat.Enabled = false;
                btnEdit.Text = "Update";
                btnHapus.Enabled = false;
                btnTambah.Enabled = false;
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE T_DataObat SET Nama_Obat='" + txtNama.Text + "', Keterangan='" + txtKeterangan.Text + "' WHERE ID_Obat='" + kdObat.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    DialogResult result = MessageBox.Show("Yakin Ubah Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Diupdate");
                        MessageBox.Show(pesan, "Success");
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Terjadi kesalahan karena: " + err);
                }
                conn.Close();
                bersihTxt();
                tampilData();
                btnEdit.Text = "Edit";
                btnHapus.Enabled = true;
                btnTambah.Enabled = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string pesan;
            try
            {
                string sql = "DELETE FROM T_DataObat WHERE ID_Obat='" + kdObat.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                DialogResult result = MessageBox.Show("Yakin Hapus Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Dihapus");
                    MessageBox.Show(pesan, "Success");
                }
                else
                {
                    btnTambah.Focus();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
            conn.Close();
            tampilData();
        }

        private void bersihTxt()
        {
            kdObat.Text = "";
            kdObat.Enabled = false;
            txtNama.Text = "";
            txtNama.Enabled = false;
            txtKeterangan.Text = "";
            txtKeterangan.Enabled = false;
        }

        private void aktif()
        {
            kdObat.Enabled = true;
            txtNama.Enabled = true;
            txtKeterangan.Enabled = true;
        }

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select * from T_DataObat", conn);
                da.Fill(ds, "Test");
                dgvGolongan.ReadOnly = true;
                dgvGolongan.AllowUserToAddRows = false;
                dgvGolongan.AllowUserToDeleteRows = false;
                dgvGolongan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvGolongan.DataSource = ds.Tables["Test"];
            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
        }

        private void dgvGolongan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            kdObat.Text = dgvGolongan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvGolongan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKeterangan.Text = dgvGolongan.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
