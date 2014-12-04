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
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //string sql = "Select Akses from T_Pegawai where Nama_Pegawai ='"+txtNama.Text+"' AND Password='"+txtPassword.Text+"'";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while(reader.Read())
            //{
            //    if ((reader.GetString(0).ToString() == "Full"))
            //    {
            //        kunci();
            //        MessageBox.Show("Sukses login "+txtNama.Text);
            //        //this.Hide();
            //        frmUtama utama = new frmUtama();
            //        utama.Show();
            //    }
            //    else if ((reader.GetString(0).ToString() == "Half"))
            //    {
            //        kunci();
            //        MessageBox.Show("Sukses login "+txtNama.Text);
            //        //this.Hide();
            //        frmPegawai pegawai = new frmPegawai();
            //        pegawai.Show();
            //    }
            //    else if ((reader.GetString(0).ToString() == "Low "))
            //    {
            //        kunci();
            //        MessageBox.Show("Sukses login " + txtNama.Text);
            //        //this.Hide();
            //        frmObat obat = new frmObat();
            //        obat.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data Login Anda Tidak Dikenal!");
            //        kunci();
            //    }
            //}
            //reader.Close();
            //conn.Close();


            conn.Open();
            string sql = "Select Nama_Pegawai,Password from T_Pegawai where Nama_Pegawai ='" + txtNama.Text + "' AND Password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0) != txtNama.Text || reader.GetString(1) != txtPassword.Text))
                {
                    kunci();
                    MessageBox.Show("Gagal login");
                }
                else
                {
                    reader.Close();
                    sql = "Select Akses from T_Pegawai where Nama_Pegawai ='" + txtNama.Text + "' AND Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if ((reader.GetString(0).ToString() == "Full"))
                        {
                            kunci();
                            MessageBox.Show("Sukses login " + txtNama.Text);
                            //this.Hide();
                            frmUtama utama = new frmUtama();
                            utama.Show();
                        }
                        else if ((reader.GetString(0).ToString() == "Half"))
                        {
                            kunci();
                            MessageBox.Show("Sukses login " + txtNama.Text);
                            //this.Hide();
                            frmPegawai pegawai = new frmPegawai();
                            pegawai.Show();
                        }
                        else if ((reader.GetString(0).ToString() == "Low"))
                        {
                            kunci();
                            MessageBox.Show("Sukses login " + txtNama.Text);
                            //this.Hide();
                            frmObat obat = new frmObat();
                            obat.Show();
                        }
                        else
                        {
                            MessageBox.Show("Data Login Anda Tidak Dikenal!");
                            kunci();
                        }
                    }
                }
            }
            reader.Close();
            conn.Close();



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
           // conn.Open();
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
    }
}
