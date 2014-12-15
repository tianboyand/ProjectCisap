namespace Siapotik
{
    partial class frmObats
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
            this.dgvGolongan = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.kdObat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolongan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGolongan
            // 
            this.dgvGolongan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGolongan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGolongan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolongan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvGolongan.Location = new System.Drawing.Point(31, 195);
            this.dgvGolongan.Name = "dgvGolongan";
            this.dgvGolongan.Size = new System.Drawing.Size(332, 196);
            this.dgvGolongan.TabIndex = 63;
            this.dgvGolongan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGolongan_CellEnter);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(97, 144);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 62;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(195, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 29);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(292, 144);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(71, 29);
            this.btnTambah.TabIndex = 60;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(156, 63);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(206, 20);
            this.txtNama.TabIndex = 59;
            // 
            // kdObat
            // 
            this.kdObat.Enabled = false;
            this.kdObat.Location = new System.Drawing.Point(156, 29);
            this.kdObat.Name = "kdObat";
            this.kdObat.Size = new System.Drawing.Size(140, 20);
            this.kdObat.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nama Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kode Obat";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Enabled = false;
            this.txtKeterangan.Location = new System.Drawing.Point(156, 98);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(206, 20);
            this.txtKeterangan.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Keterangan";
            // 
            // frmObats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 423);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGolongan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.kdObat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmObats";
            this.Text = "frmObats";
            this.Load += new System.EventHandler(this.frmObats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolongan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGolongan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox kdObat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label3;
    }
}