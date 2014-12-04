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
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuObat = new System.Windows.Forms.ToolStripMenuItem();
            this.menusSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJabatan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDataPegawai = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPegawai = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnJabatan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnObat = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnGolongan = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnPegawai.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.pnJabatan.SuspendLayout();
            this.pnObat.SuspendLayout();
            this.pnGolongan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.pegawaiToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(92, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustomer,
            this.menuObat,
            this.menusSupplier});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // menuCustomer
            // 
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(126, 22);
            this.menuCustomer.Text = "Customer";
            // 
            // menuObat
            // 
            this.menuObat.Name = "menuObat";
            this.menuObat.Size = new System.Drawing.Size(126, 22);
            this.menuObat.Text = "Obat";
            this.menuObat.Click += new System.EventHandler(this.obatToolStripMenuItem_Click);
            // 
            // menusSupplier
            // 
            this.menusSupplier.Name = "menusSupplier";
            this.menusSupplier.Size = new System.Drawing.Size(126, 22);
            this.menusSupplier.Text = "Supplier";
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
            // pnPegawai
            // 
            this.pnPegawai.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnPegawai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPegawai.BackgroundImage")));
            this.pnPegawai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnPegawai.Controls.Add(this.Label1);
            this.pnPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPegawai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnPegawai.Location = new System.Drawing.Point(839, 39);
            this.pnPegawai.Name = "pnPegawai";
            this.pnPegawai.Size = new System.Drawing.Size(175, 152);
            this.pnPegawai.TabIndex = 18;
            this.pnPegawai.Click += new System.EventHandler(this.pnPegawai_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(3, 133);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 15);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Data Pegawai";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel1,
            this.status});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 700);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip1.Size = new System.Drawing.Size(1150, 29);
            this.StatusStrip1.TabIndex = 14;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(280, 24);
            this.ToolStripStatusLabel2.Text = "Copyright © 2014  by Anonymous Team - Mikroskil";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel1.Image")));
            this.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(24, 24);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(900, 0, 0, 0);
            this.status.Size = new System.Drawing.Size(939, 15);
            this.status.Text = "Status";
            // 
            // pnJabatan
            // 
            this.pnJabatan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnJabatan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnJabatan.BackgroundImage")));
            this.pnJabatan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnJabatan.Controls.Add(this.label2);
            this.pnJabatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnJabatan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnJabatan.Location = new System.Drawing.Point(839, 197);
            this.pnJabatan.Name = "pnJabatan";
            this.pnJabatan.Size = new System.Drawing.Size(175, 71);
            this.pnJabatan.TabIndex = 19;
            this.pnJabatan.Click += new System.EventHandler(this.pnJabatan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jabatan";
            // 
            // pnObat
            // 
            this.pnObat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnObat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnObat.BackgroundImage")));
            this.pnObat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnObat.Controls.Add(this.label3);
            this.pnObat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnObat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnObat.Location = new System.Drawing.Point(548, 39);
            this.pnObat.Name = "pnObat";
            this.pnObat.Size = new System.Drawing.Size(175, 152);
            this.pnObat.TabIndex = 19;
            this.pnObat.Click += new System.EventHandler(this.pnObat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Obat\r\n";
            // 
            // pnGolongan
            // 
            this.pnGolongan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnGolongan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnGolongan.BackgroundImage")));
            this.pnGolongan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnGolongan.Controls.Add(this.label4);
            this.pnGolongan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnGolongan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnGolongan.Location = new System.Drawing.Point(548, 197);
            this.pnGolongan.Name = "pnGolongan";
            this.pnGolongan.Size = new System.Drawing.Size(175, 71);
            this.pnGolongan.TabIndex = 20;
            this.pnGolongan.Click += new System.EventHandler(this.pnGolongan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Golongan";
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.pnGolongan);
            this.Controls.Add(this.pnObat);
            this.Controls.Add(this.pnJabatan);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.pnPegawai);
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
            this.pnPegawai.ResumeLayout(false);
            this.pnPegawai.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.pnJabatan.ResumeLayout(false);
            this.pnJabatan.PerformLayout();
            this.pnObat.ResumeLayout(false);
            this.pnObat.PerformLayout();
            this.pnGolongan.ResumeLayout(false);
            this.pnGolongan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuObat;
        private System.Windows.Forms.ToolStripMenuItem menusSupplier;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnJabatan;
        private System.Windows.Forms.ToolStripMenuItem mnDataPegawai;
        private System.Windows.Forms.Panel pnPegawai;
        private System.Windows.Forms.Panel pnJabatan;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnObat;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnGolongan;
        internal System.Windows.Forms.Label label4;
    }
}

