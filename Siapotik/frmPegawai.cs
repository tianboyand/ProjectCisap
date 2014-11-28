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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmJabatan Jabatan = new frmJabatan();
            Jabatan.Show();
        }

        private void frmPegawai_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            conn.Open();
            cekjabatan();
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select ID_Pegawai, Nama_Pegawai, Jenis_Kelamin, Alamat, HP, Jabatan from T_Pegawai JOIN T_Jabatan ON T_Pegawai.Kode_Jabatan = T_Jabatan.Kode_Jabatan", conn);
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

        private void cekjabatan()
        {
            txtJabatan.Items.Clear();
            string sql = "Select Jabatan from T_Jabatan order by Kode_Jabatan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                txtJabatan.Items.Add(reader.GetString(0));
            }
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
                string sql, pesan;
                sql = String.Concat("Insert Into T_Pegawai Values ('",
                txtID.Text, "', '", txtNama.Text, "', '", txtKelamin.Text, "', '", txtAlamat.Text, "', '", txtHP.Text, "', '", txtPassword.Text, "', '", txtFoto.Text, "',(Select Kode_Jabatan From T_Jabatan where Jabatan = '", txtJabatan.Text, "'))");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                pesan = String.Concat(cmd.ExecuteNonQuery(), " Record berhasil di Simpan");
                MessageBox.Show(pesan, "Info Simpan");
            conn.Close();
        }

        private void autonumber()
        {
            SqlCommand cmd = new SqlCommand("SELECT CONCAT('PG',LPAD((RIGHT( MAX(ID_Pegawai),3)+1),3,'0')) as ID_Pegawai FROM T_Pegawai", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtID.Text = "PG001";
                txtID.Text = reader.GetString(0);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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


    }
}
