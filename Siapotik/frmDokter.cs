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
    public partial class frmDokter : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmDokter()
        {
            InitializeComponent();
        }

        private void frmDokter_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            tampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                bersihTxt();
                autonumber();
                aktif();
                btnTambah.Text = "Simpan";
                btnHapus.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                if (txtNama.Text == "" || txtAlamat.Text == "" || txtHP.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, pesan;
                        sql = String.Concat("Insert Into T_Dokter Values ('", txtID.Text, "', '", txtNama.Text, "', '", txtHP.Text, "', '", txtAlamat.Text, "', '", txtKet.Text, "')");
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
                    disTxt();
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
                aktif();
                btnEdit.Text = "Update";
                btnHapus.Enabled = false;
                btnTambah.Enabled = false;
            }
            else
            {
                if (txtNama.Text == "" || txtAlamat.Text == "" || txtHP.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql = "UPDATE T_Dokter SET Nama_Dokter='" + txtNama.Text + "', HP='" + txtHP.Text +
                            "', Alamat='" + txtAlamat.Text + "', Keterangan='" + txtKet.Text + "' WHERE ID_Dokter='" + txtID.Text + "'";
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
                    disTxt();
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
                string sql = "DELETE FROM T_Dokter WHERE ID_Dokter='" + txtID.Text + "'";
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

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select * from T_Dokter", conn);
                da.Fill(ds, "Test");
                dgvDokter.ReadOnly = true;
                dgvDokter.AllowUserToAddRows = false;
                dgvDokter.AllowUserToDeleteRows = false;
                dgvDokter.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvDokter.DataSource = ds.Tables["Test"];
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
            SqlCommand cmd = new SqlCommand("select ID_Dokter from T_Dokter where ID_Dokter in(select max(ID_Dokter) from T_Dokter) order by ID_Dokter desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["ID_Dokter"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "DOK" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                urut = "DOK00001";
            }
            reader.Close();
            txtID.Text = urut;
            conn.Close();
        }

        private void dgvDokter_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            txtID.Text = dgvDokter.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvDokter.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHP.Text = dgvDokter.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = dgvDokter.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKet.Text = dgvDokter.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bersihTxt()
        {
            txtID.Clear();
            txtNama.Clear();
            txtHP.Clear();
            txtAlamat.Clear();
            txtKet.Clear();
        }

        private void aktif()
        {
            txtNama.Enabled = true;
            txtHP.Enabled = true;
            txtAlamat.Enabled = true;
            txtKet.Enabled = true;
        }

        private void disTxt()
        {
            txtNama.Enabled = false;
            txtHP.Enabled = false;
            txtAlamat.Enabled = false;
            txtKet.Enabled = false;
        }
    }
}
