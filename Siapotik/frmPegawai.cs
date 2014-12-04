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
    public partial class frmPegawai : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public frmPegawai()
        {
            InitializeComponent();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                conn.Open();
                aktif();
                btnEdit.Text = "Update";
                btnBatal.Enabled = true;
                conn.Close();
                cekjabatan();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE T_Pegawai SET ID_Pegawai='" + txtID.Text + "', Nama_Pegawai='" + txtNama.Text + "',Jenis_Kelamin='" + txtKelamin.Text + "', Alamat='" + txtAlamat.Text + "', HP='" + txtHP.Text + "', Password='" + txtPassword.Text + "', Kode_Jabatan = '" + txtJabatan.Text + "', Akses='" + txtAkses.Text + "', Photo='" + txtFoto.Text + "' WHERE ID_Pegawai='" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    DialogResult result = MessageBox.Show("Yakin Ubah Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Diupdate");
                        MessageBox.Show(pesan, "Success");
                    }
                    else
                    {
                        distxt();
                    }
                    conn.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Terjadi kesalahan karena: " + err);
                }
                tampilData();
                btnEdit.Text = "Edit";
                btnBatal.Enabled=false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmJabatan Jabatan = new frmJabatan();
            Jabatan.Show();
        }

        private void frmPegawai_Load(object sender, EventArgs e)
        {
            bersihtxt();
            distxt();
            //classKoneksi konek = new classKoneksi();
            //konek.koneksi();
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            //conn.Open();
            tampilData();
            txtAkses.Items.Add("Full");
            txtAkses.Items.Add("Half");
            txtAkses.Items.Add("Low");
        }

        private void cekjabatan()
        {
            conn.Open();
            txtJabatan.Items.Clear();
            string sql = "Select Kode_Jabatan from T_Jabatan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                txtJabatan.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void bersihtxt()
        {
            txtID.Text = "";
            txtNama.Text = "";
            txtKelamin.Text = "";
            txtAlamat.Text = "";
            txtHP.Text = "";
            txtJabatan.Text = "";
            txtJabatan2.Text = "";
            txtPassword.Text = "";
        }

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select ID_Pegawai, Nama_Pegawai, Jenis_Kelamin, Alamat, HP, Jabatan, Password, Akses from T_Pegawai JOIN T_Jabatan ON T_Pegawai.Kode_Jabatan = T_Jabatan.Kode_Jabatan", conn);
                da.Fill(ds, "Test");
                dgvPegawai.ReadOnly = true;
                dgvPegawai.AllowUserToAddRows = false;
                dgvPegawai.AllowUserToDeleteRows = false;
                dgvPegawai.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvPegawai.DataSource = ds.Tables["Test"];
            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
        }

        private void distxt()
        {
            txtNama.Enabled = false;
            txtKelamin.Enabled = false;
            txtAlamat.Enabled = false;
            txtHP.Enabled = false;
            txtJabatan.Enabled = false;
            txtPassword.Enabled = false;
            txtAkses.Enabled = false;
            btnUpload.Enabled = false;
            lblAdd.Enabled = false;
        }

        private void aktif()
        {
            txtNama.Enabled = true;
            txtKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            txtHP.Enabled = true;
            txtJabatan.Enabled = true;
            txtPassword.Enabled = true;
            txtAkses.Enabled = true;
            btnUpload.Enabled = true;
            lblAdd.Enabled = true;
        }

        private void autonumber()
        {
            int hitung;
            string urut;
            conn.Open();
            // Mempersiapkan koneksi database;

            // Perintah untuk mendapatkan nilai terbesar dari field nomor
            SqlCommand cmd = new SqlCommand("select ID_Pegawai from T_Pegawai where ID_Pegawai in(select max(ID_Pegawai) from T_Pegawai) order by ID_Pegawai desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            // Jika data ditemukan
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["ID_Pegawai"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "PG" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                // Jika tidak ditemukan maka mengisi variable urut dengan BRG0001
                urut = "PG001";
            }
            reader.Close();
            txtID.Text = urut;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        { 
            if (btnTambah.Text == "Tambah")
            {
                aktif();
                bersihtxt();
                btnBatal.Enabled = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                cekjabatan();
                autonumber();
                btnTambah.Text = "Simpan";
                txtFoto.Text = "";
                pBox.ImageLocation = "";
            }
            else
            {
            conn.Open();
                string sql, pesan;
                sql = String.Concat("Insert Into T_Pegawai Values ('",
                txtID.Text, "', '", txtNama.Text, "', '", txtKelamin.Text, "', '", txtAlamat.Text, "', '", txtHP.Text, "', '", txtPassword.Text, "', '", txtFoto.Text, "','", txtJabatan.Text, "','", txtAkses.Text, "')");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                pesan = String.Concat(cmd.ExecuteNonQuery(), " Record berhasil di Simpan");
                MessageBox.Show(pesan, "Info Simpan");
                conn.Close();
                tampilData();
                bersihtxt();
                distxt();
                btnTambah.Text = "Tambah";
                btnBatal.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select Jabatan from T_Jabatan where Kode_Jabatan = '" + txtJabatan.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtJabatan2.Text=(reader.GetString(0));
            }
            conn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "JPEGs|*.jpg;*.jpeg|PNG|*.png";
            dlgOpen.FilterIndex = 0;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(dlgOpen.FileName);
                pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                txtFoto.Text = dlgOpen.FileName;
            }
        }

        private void tampilFoto()
        {
            conn.Open();
            string sql = "Select Photo from T_Pegawai where ID_Pegawai = '" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            reader.Read();
            //{
            txtFoto.Text = (reader.GetString(0));
            pBox.ImageLocation = txtFoto.Text;
            //}
            reader.Close();
            conn.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihtxt();
            distxt();
            btnTambah.Text = "Tambah";
            btnBatal.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void dgvPegawai_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            distxt();
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            txtID.Text = dgvPegawai.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvPegawai.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKelamin.Text = dgvPegawai.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = dgvPegawai.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHP.Text = dgvPegawai.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtJabatan2.Text = dgvPegawai.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPassword.Text = dgvPegawai.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAkses.Text = dgvPegawai.Rows[e.RowIndex].Cells[7].Value.ToString();
            tampilFoto();
            conn.Open();
            string sql = "Select Kode_Jabatan from T_Jabatan where Jabatan = '" + txtJabatan2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            reader.Read();
            //{
            txtJabatan.Text = (reader.GetString(0));
            //}
            reader.Close();
            conn.Close();
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string pesan;
            try
            {
                string sql = "DELETE FROM T_Pegawai WHERE ID_Pegawai='" + txtID.Text + "'";
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
