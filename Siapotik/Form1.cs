using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Siapotik
{
    public partial class frmUtama : Form
    {

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
            frmLogin login = new frmLogin();
        }

        private void menusSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void menuJualResep_Click(object sender, EventArgs e)
        {
            frmPenjualan jual = new frmPenjualan();
            jual.MdiParent = this;
            jual.Show();
        }

        private void resepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderResep resep = new frmOrderResep();
            resep.MdiParent = this;
            resep.Show();
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDokter dokter = new frmDokter();
            dokter.MdiParent = this;
            dokter.Show();
        }

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasien pasien = new frmPasien();
            pasien.MdiParent = this;
            pasien.Show();
        }

        public void disData()
        {
            dataToolStripMenuItem.Enabled = false;
        }
        public void disDistribusi()
        {
            prosesToolStripMenuItem.Enabled = false;
        }

        public void disPenjualan()
        {
            penjualanToolStripMenuItem.Enabled = false;
        }

        public void disPegawai()
        {
            pegawaiToolStripMenuItem1.Enabled = false;
        }

        public void disView()
        {
            vIewToolStripMenuItem.Enabled = false;
        }

        private void penerimaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPembelian beli = new frmPembelian();
            beli.MdiParent = this;
            beli.Show();
        }

        private void pemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.MdiParent = this;
            order.Show();
        }

        private void golonganObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGolObat golObat = new frmGolObat();
            golObat.MdiParent = this;
            golObat.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void dataOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewOrder order = new viewOrder();
            order.MdiParent = this;
            order.Show();
        }

        private void dataPenerimaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPenerimaan terima = new viewPenerimaan();
            terima.MdiParent = this;
            terima.Show();
        }

        private void dataPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPenjualan jual = new viewPenjualan();
            jual.MdiParent = this;
            jual.Show();
        }
    }
}
