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
using System.Globalization;

namespace Siapotik
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "Select Nama_Pegawai,Password from T_Pegawai where Nama_Pegawai ='" + txtNama.Text + "' AND Password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Nama atau Password Anda Salah / Tidak Terdaftar","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    kunci();
                }
                else
                {
                    reader.Close();
                    sql = "Select Akses from T_Pegawai where Nama_Pegawai ='" + txtNama.Text + "' AND Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                        if ((reader.GetString(0).ToString() == "Full"))
                        {
                            MessageBox.Show("Selamat Datang " + txtNama.Text);
                            frmUtama utama = new frmUtama();
                            utama.Show();
                            
                        }
                        else if ((reader.GetString(0).ToString() == "Half"))
                        {
                            MessageBox.Show("Selamat Datang " + txtNama.Text);
                            frmUtama utama = new frmUtama();
                            utama.Show();
                            utama.disPegawai();
                        }
                        else if ((reader.GetString(0).ToString() == "Low"))
                        {
                            MessageBox.Show("Selamat Datang " + txtNama.Text);
                            frmUtama utama = new frmUtama();
                            utama.Show();
                            utama.disData();
                            utama.disDistribusi();
                            utama.disPegawai();
                            utama.disPenjualan();
                        }
                        else
                        {
                            MessageBox.Show("Data Login Anda Tidak Dikenal!");
                            kunci();
                        }
                        kunci();
                        this.Hide();
                }
            reader.Close();
            conn.Close();
        }

        private void kunci()
        {
            txtNama.Text = "";
            txtPassword.Text = "";
            txtNama.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            //string t = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNama.Text);
            ////e.KeyChar = Char.ToUpper(e.KeyChar);
            //txtNama.Text = t;
        }

    }
}
