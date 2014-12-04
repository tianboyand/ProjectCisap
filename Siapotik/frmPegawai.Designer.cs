namespace Siapotik
{
    partial class frmPegawai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelamin = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtJabatan = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvPegawai = new System.Windows.Forms.DataGridView();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtJabatan2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAkses = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(26, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(26, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "No. Telp/HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Jabatan";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(166, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(102, 20);
            this.txtID.TabIndex = 34;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(166, 88);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(192, 20);
            this.txtNama.TabIndex = 35;
            // 
            // txtKelamin
            // 
            this.txtKelamin.FormattingEnabled = true;
            this.txtKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.txtKelamin.Location = new System.Drawing.Point(166, 114);
            this.txtKelamin.Name = "txtKelamin";
            this.txtKelamin.Size = new System.Drawing.Size(102, 21);
            this.txtKelamin.TabIndex = 36;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(166, 141);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(192, 20);
            this.txtAlamat.TabIndex = 37;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(166, 167);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(192, 20);
            this.txtHP.TabIndex = 38;
            // 
            // txtJabatan
            // 
            this.txtJabatan.FormattingEnabled = true;
            this.txtJabatan.Location = new System.Drawing.Point(166, 193);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(84, 21);
            this.txtJabatan.TabIndex = 39;
            this.txtJabatan.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(514, 222);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(67, 28);
            this.btnUpload.TabIndex = 41;
            this.btnUpload.Text = "Browse";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(269, 20);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 44;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(152, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 29);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(34, 20);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(71, 29);
            this.btnTambah.TabIndex = 42;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(30, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 63);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(484, 20);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 45;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPegawai.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPegawai.Location = new System.Drawing.Point(30, 291);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.Size = new System.Drawing.Size(628, 211);
            this.dgvPegawai.TabIndex = 46;
            this.dgvPegawai.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPegawai_CellEnter);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Honeydew;
            this.lblAdd.Location = new System.Drawing.Point(364, 200);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(32, 13);
            this.lblAdd.TabIndex = 47;
            this.lblAdd.Text = "Add..";
            this.lblAdd.Click += new System.EventHandler(this.label8_Click);
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBox.Location = new System.Drawing.Point(480, 41);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(137, 173);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 40;
            this.pBox.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(26, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Password";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(452, 256);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(192, 20);
            this.txtFoto.TabIndex = 51;
            this.txtFoto.Visible = false;
            // 
            // txtJabatan2
            // 
            this.txtJabatan2.Enabled = false;
            this.txtJabatan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJabatan2.Location = new System.Drawing.Point(256, 194);
            this.txtJabatan2.Name = "txtJabatan2";
            this.txtJabatan2.Size = new System.Drawing.Size(102, 20);
            this.txtJabatan2.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(26, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Akses";
            // 
            // txtAkses
            // 
            this.txtAkses.FormattingEnabled = true;
            this.txtAkses.Location = new System.Drawing.Point(166, 248);
            this.txtAkses.Name = "txtAkses";
            this.txtAkses.Size = new System.Drawing.Size(84, 21);
            this.txtAkses.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 24);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(672, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 24);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(648, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 24);
            this.btnMin.TabIndex = 58;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(274, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Data Pegawai";
            // 
            // frmPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(694, 588);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAkses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtJabatan2);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.dgvPegawai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPegawai";
            this.Text = "Data Pegawai";
            this.Load += new System.EventHandler(this.frmPegawai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox txtKelamin;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.ComboBox txtJabatan;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPegawai;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtJabatan2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtAkses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label10;
    }
}