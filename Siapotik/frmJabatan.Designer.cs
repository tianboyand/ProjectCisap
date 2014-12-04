namespace Siapotik
{
    partial class frmJabatan
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.kdJabatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJabatan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJabatan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(33, 111);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 44;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(131, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 29);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(228, 111);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(71, 29);
            this.btnTambah.TabIndex = 42;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJabatan
            // 
            this.txtJabatan.Enabled = false;
            this.txtJabatan.Location = new System.Drawing.Point(160, 66);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(140, 20);
            this.txtJabatan.TabIndex = 40;
            // 
            // kdJabatan
            // 
            this.kdJabatan.Enabled = false;
            this.kdJabatan.Location = new System.Drawing.Point(160, 32);
            this.kdJabatan.Name = "kdJabatan";
            this.kdJabatan.Size = new System.Drawing.Size(140, 20);
            this.kdJabatan.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Jabatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kode Jabatan";
            // 
            // dgvJabatan
            // 
            this.dgvJabatan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJabatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJabatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJabatan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvJabatan.Location = new System.Drawing.Point(34, 169);
            this.dgvJabatan.Name = "dgvJabatan";
            this.dgvJabatan.Size = new System.Drawing.Size(265, 196);
            this.dgvJabatan.TabIndex = 47;
            this.dgvJabatan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJabatan_CellEnter);
            // 
            // frmJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 393);
            this.Controls.Add(this.dgvJabatan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.kdJabatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmJabatan";
            this.Text = "Jabatan Pegawai";
            this.Load += new System.EventHandler(this.frmJabatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJabatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.TextBox kdJabatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJabatan;
    }
}