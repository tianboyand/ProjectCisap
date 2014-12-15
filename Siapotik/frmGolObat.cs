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
    public partial class frmGolObat : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmGolObat()
        {
            InitializeComponent();
        }

        private void frmGolObat_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            tampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                autonumber();
                txtGolongan.Enabled = true;
                txtGolongan.Text = "";
                btnTambah.Text = "Simpan";
                btnHapus.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                if (txtGolongan.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGolongan.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, pesan;
                        sql = String.Concat("Insert Into T_Golongan_Obat Values ('", kdGolongan.Text, "', '", txtGolongan.Text, "')");
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                txtGolongan.Enabled = true;
                btnEdit.Text = "Update";
                btnHapus.Enabled = false;
                btnTambah.Enabled = false;
            }
            else
            {
                if (txtGolongan.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGolongan.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql = "UPDATE T_Golongan_Obat SET Golongan='" + txtGolongan.Text + "' WHERE Kode_Golongan='" + kdGolongan.Text + "'";
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
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string pesan;
            try
            {
                string sql = "DELETE FROM T_Golongan_Obat WHERE Kode_Golongan='" + kdGolongan.Text + "'";
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



        private void autonumber()
        {
            int hitung;
            string urut;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Kode_Golongan from T_Golongan_Obat where Kode_Golongan in(select max(Kode_Golongan) from T_Golongan_Obat) order by Kode_Golongan desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["Kode_Golongan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "GL" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "GL001";
            }
            reader.Close();
            kdGolongan.Text = urut;
            conn.Close();
        }

        private void bersihTxt()
        {
            txtGolongan.Text = "";
            txtGolongan.Enabled = false;
        }

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select * from T_Golongan_Obat", conn);
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
            kdGolongan.Text = dgvGolongan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGolongan.Text = dgvGolongan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
