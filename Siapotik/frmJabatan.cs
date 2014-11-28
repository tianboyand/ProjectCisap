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

        public frmJabatan()
        {
            InitializeComponent();
        }

        //public void auto()
        //{
        //    Try
        //    rs.Close()
        //    cmd = New MySqlCommand("SELECT CONCAT( 'BR' ,LPAD(( RIGHT( MAX(Kode_Barang),5)+1),5,'0')) as Kode_Barang FROM barang", db)
        //    rs = cmd.ExecuteReader
        //    If rs.Read Then
        //        kodebrg.Text = "BR00001"
        //        kodebrg.Text = rs.Item("Kode_Barang")
        //    Else
        //        kodebrg.Text = rs.Item("Kode_Barang")
        //    End If
        //Catch ex As Exception
        //    MsgBox("Data Barang Masih Kosong. Silahkan Input Data", MsgBoxStyle.OkOnly, "Informasi")
        //End Try
        //rs.Close()
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string sql, pesan;
            sql = String.Concat("Insert Into T_Jabatan Values ('",
            kdJabatan.Text, "', '", txtJabatan.Text, "')");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            pesan = String.Concat(cmd.ExecuteNonQuery(), " Record berhasil di Simpan");
            MessageBox.Show(pesan, "Info Simpan");
        }

        private void frmJabatan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            conn.Open(); 
        }
    }
}
