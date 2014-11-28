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
            this.jabatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.signin = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
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
            this.menuCustomer.Size = new System.Drawing.Size(152, 22);
            this.menuCustomer.Text = "Customer";
            // 
            // menuObat
            // 
            this.menuObat.Name = "menuObat";
            this.menuObat.Size = new System.Drawing.Size(152, 22);
            this.menuObat.Text = "Obat";
            this.menuObat.Click += new System.EventHandler(this.obatToolStripMenuItem_Click);
            // 
            // menusSupplier
            // 
            this.menusSupplier.Name = "menusSupplier";
            this.menusSupplier.Size = new System.Drawing.Size(152, 22);
            this.menusSupplier.Text = "Supplier";
            // 
            // pegawaiToolStripMenuItem1
            // 
            this.pegawaiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jabatanToolStripMenuItem,
            this.dataPegawaiToolStripMenuItem});
            this.pegawaiToolStripMenuItem1.Name = "pegawaiToolStripMenuItem1";
            this.pegawaiToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.pegawaiToolStripMenuItem1.Text = "Pegawai";
            // 
            // jabatanToolStripMenuItem
            // 
            this.jabatanToolStripMenuItem.Name = "jabatanToolStripMenuItem";
            this.jabatanToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.jabatanToolStripMenuItem.Text = "Jabatan";
            this.jabatanToolStripMenuItem.Click += new System.EventHandler(this.jabatanToolStripMenuItem_Click);
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Gray;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.signin);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.pass);
            this.Panel1.Controls.Add(this.user);
            this.Panel1.Location = new System.Drawing.Point(557, 234);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(295, 247);
            this.Panel1.TabIndex = 13;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Chartreuse;
            this.PictureBox2.Location = new System.Drawing.Point(1, 214);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(293, 33);
            this.PictureBox2.TabIndex = 17;
            this.PictureBox2.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Chartreuse;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(16, 6);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 21);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form Login Administrator";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.PictureBox1.Location = new System.Drawing.Point(1, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(293, 33);
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(20, 170);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(80, 27);
            this.signin.TabIndex = 15;
            this.signin.Text = "SIgnIn";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Gray;
            this.Label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 18);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Password :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Gray;
            this.Label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(17, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 18);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Username :";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(20, 132);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(202, 20);
            this.pass.TabIndex = 12;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(20, 69);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(202, 20);
            this.user.TabIndex = 11;
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
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 729);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUtama";
            this.Text = "Sistem Informasi Apotik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
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
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button signin;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox pass;
        internal System.Windows.Forms.TextBox user;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jabatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
    }
}

