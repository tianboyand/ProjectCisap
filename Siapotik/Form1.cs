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

        public frmUtama()
        {
            InitializeComponent();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObat formobat = new frmObat();
            formobat.MdiParent = this;
            formobat.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
        
        string pesan;
        try {
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
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPegawai Pegawai = new frmPegawai();
            Pegawai.MdiParent = this;
            Pegawai.Show();
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {
            classKoneksi konek = new classKoneksi();
            konek.koneksi();
            
        }

        private void pnPegawai_Click(object sender, EventArgs e)
        {
            frmPegawai pegawai = new frmPegawai();
            pegawai.Show();
            pegawai.MdiParent = this;
            pnPegawai.Show();
        }

        private void pnJabatan_Click(object sender, EventArgs e)
        {
            frmJabatan jabatan = new frmJabatan();
            jabatan.Show();
            jabatan.MdiParent = this;
            pnJabatan.Show();
        }

        private void pnGolongan_Click(object sender, EventArgs e)
        {
            frmGolObat golobat = new frmGolObat();
            golobat.MdiParent = this;
            golobat.Show();
            pnGolongan.Show();
            pnObat.Show();
        }

        private void pnObat_Click(object sender, EventArgs e)
        {
            frmObat obat = new frmObat();
            obat.MdiParent = this;
            obat.Show();
            pnGolongan.SendToBack();
            pnObat.SendToBack();
            pnJabatan.SendToBack();
            pnPegawai.SendToBack();
        }

    }
}
