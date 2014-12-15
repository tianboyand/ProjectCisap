namespace Siapotik
{
    partial class frmUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuObat = new System.Windows.Forms.ToolStripMenuItem();
            this.golonganObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJualResep = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJabatan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDataPegawai = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenerimaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.prosesToolStripMenuItem,
            this.penjualanToolStripMenuItem,
            this.pegawaiToolStripMenuItem1,
            this.vIewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(117, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuObat,
            this.golonganObatToolStripMenuItem,
            this.menusSupplier,
            this.toolStripSeparator1,
            this.dokterToolStripMenuItem,
            this.pasienToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // menuObat
            // 
            this.menuObat.Name = "menuObat";
            this.menuObat.Size = new System.Drawing.Size(155, 22);
            this.menuObat.Text = "Obat";
            this.menuObat.Click += new System.EventHandler(this.obatToolStripMenuItem_Click);
            // 
            // golonganObatToolStripMenuItem
            // 
            this.golonganObatToolStripMenuItem.Name = "golonganObatToolStripMenuItem";
            this.golonganObatToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.golonganObatToolStripMenuItem.Text = "Golongan Obat";
            this.golonganObatToolStripMenuItem.Click += new System.EventHandler(this.golonganObatToolStripMenuItem_Click);
            // 
            // menusSupplier
            // 
            this.menusSupplier.Name = "menusSupplier";
            this.menusSupplier.Size = new System.Drawing.Size(155, 22);
            this.menusSupplier.Text = "Supplier";
            this.menusSupplier.Click += new System.EventHandler(this.menusSupplier_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dokterToolStripMenuItem.Text = "Dokter";
            this.dokterToolStripMenuItem.Click += new System.EventHandler(this.dokterToolStripMenuItem_Click);
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pasienToolStripMenuItem.Text = "Pasien";
            this.pasienToolStripMenuItem.Click += new System.EventHandler(this.pasienToolStripMenuItem_Click);
            // 
            // prosesToolStripMenuItem
            // 
            this.prosesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pemesananToolStripMenuItem,
            this.penerimaanToolStripMenuItem});
            this.prosesToolStripMenuItem.Name = "prosesToolStripMenuItem";
            this.prosesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.prosesToolStripMenuItem.Text = "Distribusi";
            // 
            // pemesananToolStripMenuItem
            // 
            this.pemesananToolStripMenuItem.Name = "pemesananToolStripMenuItem";
            this.pemesananToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pemesananToolStripMenuItem.Text = "Pemesanan";
            this.pemesananToolStripMenuItem.Click += new System.EventHandler(this.pemesananToolStripMenuItem_Click);
            // 
            // penerimaanToolStripMenuItem
            // 
            this.penerimaanToolStripMenuItem.Name = "penerimaanToolStripMenuItem";
            this.penerimaanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.penerimaanToolStripMenuItem.Text = "Penerimaan";
            this.penerimaanToolStripMenuItem.Click += new System.EventHandler(this.penerimaanToolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resepToolStripMenuItem,
            this.menuJualResep});
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // resepToolStripMenuItem
            // 
            this.resepToolStripMenuItem.Name = "resepToolStripMenuItem";
            this.resepToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.resepToolStripMenuItem.Text = "Resep";
            this.resepToolStripMenuItem.Click += new System.EventHandler(this.resepToolStripMenuItem_Click);
            // 
            // menuJualResep
            // 
            this.menuJualResep.Name = "menuJualResep";
            this.menuJualResep.Size = new System.Drawing.Size(133, 22);
            this.menuJualResep.Text = "Non-Resep";
            this.menuJualResep.Click += new System.EventHandler(this.menuJualResep_Click);
            // 
            // pegawaiToolStripMenuItem1
            // 
            this.pegawaiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnJabatan,
            this.mnDataPegawai});
            this.pegawaiToolStripMenuItem1.Name = "pegawaiToolStripMenuItem1";
            this.pegawaiToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.pegawaiToolStripMenuItem1.Text = "Pegawai";
            // 
            // mnJabatan
            // 
            this.mnJabatan.Name = "mnJabatan";
            this.mnJabatan.Size = new System.Drawing.Size(145, 22);
            this.mnJabatan.Text = "Jabatan";
            this.mnJabatan.Click += new System.EventHandler(this.jabatanToolStripMenuItem_Click);
            // 
            // mnDataPegawai
            // 
            this.mnDataPegawai.Name = "mnDataPegawai";
            this.mnDataPegawai.Size = new System.Drawing.Size(145, 22);
            this.mnDataPegawai.Text = "Data Pegawai";
            this.mnDataPegawai.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // vIewToolStripMenuItem
            // 
            this.vIewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataOrderToolStripMenuItem,
            this.dataPenerimaanToolStripMenuItem,
            this.dataPenjualanToolStripMenuItem,
            this.dataPegawaiToolStripMenuItem});
            this.vIewToolStripMenuItem.Name = "vIewToolStripMenuItem";
            this.vIewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vIewToolStripMenuItem.Text = "View";
            // 
            // dataOrderToolStripMenuItem
            // 
            this.dataOrderToolStripMenuItem.Name = "dataOrderToolStripMenuItem";
            this.dataOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dataOrderToolStripMenuItem.Text = "Data Order";
            this.dataOrderToolStripMenuItem.Click += new System.EventHandler(this.dataOrderToolStripMenuItem_Click);
            // 
            // dataPenerimaanToolStripMenuItem
            // 
            this.dataPenerimaanToolStripMenuItem.Name = "dataPenerimaanToolStripMenuItem";
            this.dataPenerimaanToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dataPenerimaanToolStripMenuItem.Text = "Data Penerimaan";
            this.dataPenerimaanToolStripMenuItem.Click += new System.EventHandler(this.dataPenerimaanToolStripMenuItem_Click);
            // 
            // dataPenjualanToolStripMenuItem
            // 
            this.dataPenjualanToolStripMenuItem.Name = "dataPenjualanToolStripMenuItem";
            this.dataPenjualanToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dataPenjualanToolStripMenuItem.Text = "Data Penjualan";
            this.dataPenjualanToolStripMenuItem.Click += new System.EventHandler(this.dataPenjualanToolStripMenuItem_Click);
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUtama";
            this.Text = "Sistem Informasi Apotik";
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuObat;
        private System.Windows.Forms.ToolStripMenuItem menusSupplier;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnJabatan;
        private System.Windows.Forms.ToolStripMenuItem mnDataPegawai;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuJualResep;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem prosesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penerimaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem golonganObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenerimaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
    }
}

