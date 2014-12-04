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
    public partial class frmJabatan : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public frmJabatan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                autonumber();
                txtJabatan.Enabled = true;
                txtJabatan.Text = "";
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
                    sql = String.Concat("Insert Into T_Jabatan Values ('", kdJabatan.Text, "', '", txtJabatan.Text, "')");
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

        private void bersihTxt()
        {
            txtJabatan.Text = "";
            txtJabatan.Enabled = false;
        }

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select * from T_Jabatan", conn);
                da.Fill(ds, "Test");
                dgvJabatan.ReadOnly = true;
                dgvJabatan.AllowUserToAddRows = false;
                dgvJabatan.AllowUserToDeleteRows = false;
                dgvJabatan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvJabatan.DataSource = ds.Tables["Test"];
            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
        }

        private void autonumber()
        {
            int hitung;
            string urut;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Kode_Jabatan from T_Jabatan where Kode_Jabatan in(select max(Kode_Jabatan) from T_Jabatan) order by Kode_Jabatan desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["Kode_Jabatan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "JB" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "JB001";
            }
            reader.Close();
            kdJabatan.Text = urut;
            conn.Close();
        }

        private void frmJabatan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            tampilData();
        }

        private void dgvJabatan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            kdJabatan.Text = dgvJabatan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtJabatan.Text = dgvJabatan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                txtJabatan.Enabled = true;
                btnEdit.Text = "Update";
                btnHapus.Enabled = false;
                btnTambah.Enabled = false;
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE T_Jabatan SET Jabatan='" + txtJabatan.Text + "' WHERE Kode_Jabatan='" + kdJabatan.Text + "'";
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
                string sql = "DELETE FROM T_jabatan WHERE Kode_Jabatan='" + kdJabatan.Text + "'";
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
    }
}
