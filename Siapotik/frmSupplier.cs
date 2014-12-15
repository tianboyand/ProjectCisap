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
    public partial class frmSupplier : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            tampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                autonumber();
                aktifTxt();
                bersihTxt();
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
                        sql = String.Concat("Insert Into T_Supplier Values ('", txtID.Text, "', '", txtNama.Text, "', '", txtAlamat.Text, "', '", txtHP.Text, "')");
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
                aktifTxt();
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
                        string sql = "UPDATE T_Supplier SET Nama='" + txtNama.Text + "', Alamat='" + txtAlamat.Text + "', HP='" + txtHP.Text + "' WHERE ID_Supplier='" + txtID.Text + "'";
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
                string sql = "DELETE FROM T_Supplier WHERE ID_Supplier='" + txtID.Text + "'";
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
                da = new SqlDataAdapter("Select * from T_Supplier", conn);
                da.Fill(ds, "Test");
                dgvSupplier.ReadOnly = true;
                dgvSupplier.AllowUserToAddRows = false;
                dgvSupplier.AllowUserToDeleteRows = false;
                dgvSupplier.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvSupplier.DataSource = ds.Tables["Test"];
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
            SqlCommand cmd = new SqlCommand("select ID_Supplier from T_Supplier where ID_Supplier in(select max(ID_Supplier) from T_Supplier) order by ID_Supplier desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["ID_Supplier"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "SP" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "SP001";
            }
            reader.Close();
            txtID.Text = urut;
            conn.Close();
        }

        private void dgvSupplier_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            txtID.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAlamat.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHP.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bersihTxt()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtHP.Text = "";
        }

        private void aktifTxt()
        {
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtHP.Enabled = true;
        }

        private void disTxt()
        {
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtHP.Enabled = false;
        }
    }
}
