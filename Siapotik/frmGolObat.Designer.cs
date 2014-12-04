namespace Siapotik
{
    partial class frmGolObat
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
            this.txtGolongan = new System.Windows.Forms.TextBox();
            this.kdGolongan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvGolongan.Location = new System.Drawing.Point(25, 159);
            this.dgvGolongan.Name = "dgvGolongan";
            this.dgvGolongan.Size = new System.Drawing.Size(265, 196);
            this.dgvGolongan.TabIndex = 55;
            this.dgvGolongan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGolongan_CellEnter);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(25, 101);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 54;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 29);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(220, 101);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(71, 29);
            this.btnTambah.TabIndex = 52;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtGolongan
            // 
            this.txtGolongan.Enabled = false;
            this.txtGolongan.Location = new System.Drawing.Point(152, 56);
            this.txtGolongan.Name = "txtGolongan";
            this.txtGolongan.Size = new System.Drawing.Size(140, 20);
            this.txtGolongan.TabIndex = 51;
            // 
            // kdGolongan
            // 
            this.kdGolongan.Enabled = false;
            this.kdGolongan.Location = new System.Drawing.Point(152, 22);
            this.kdGolongan.Name = "kdGolongan";
            this.kdGolongan.Size = new System.Drawing.Size(140, 20);
            this.kdGolongan.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Golongan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kode Golongan";
            // 
            // frmGolObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 384);
            this.Controls.Add(this.dgvGolongan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtGolongan);
            this.Controls.Add(this.kdGolongan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGolObat";
            this.Text = "Golongan Obat";
            this.Load += new System.EventHandler(this.frmGolObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolongan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGolongan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtGolongan;
        private System.Windows.Forms.TextBox kdGolongan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}