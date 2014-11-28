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
    public partial class frmUtama : Form
    {
        SqlConnection conn;

        public void konek()
        {
            conn = new SqlConnection("Server = localhost; Data Source = TRIE; Database = siapotik;Integrated Security = SSPI");
            conn.Open();
        }

        public frmUtama()
        {
            InitializeComponent();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObat formobat = new frmObat();
            formobat.MdiParent = this;
            formobat.Show();
            Panel1.Enabled = false;
            Panel1.Hide();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
        
        string pesan;
        try {
            konek();
            pesan = String.Concat("Koneksi ke = ",
            conn.DataSource, "\n");
                pesan = String.Concat(pesan, "Database = ",
            conn.Database, "\n");
            pesan = String.Concat(pesan, "WorkStationID = ",
            conn.WorkstationId, "\n");
            pesan = String.Concat(pesan, "Connection String = ",
            conn.ConnectionString);
            MessageBox.Show(pesan, "Koneksi Database");
            }
            catch (SqlException ex) {
            pesan = String.Concat("Error ", ex.ErrorCode, " : ");
            pesan = String.Concat(pesan, ex.Message);
            MessageBox.Show(pesan, "Database Error");
            }
        }

        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJabatan Jabatan = new frmJabatan();
            Jabatan.MdiParent = this;
            Jabatan.Show();
            Panel1.Enabled = false;
            Panel1.Hide();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPegawai Pegawai = new frmPegawai();
            Pegawai.MdiParent = this;
            Pegawai.Show();
            Panel1.Enabled = false;
            Panel1.Hide();
        }
    }
}
