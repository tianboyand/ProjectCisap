namespace Siapotik
{
    partial class viewPenjualan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPilih = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPilih);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 61);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // txtPilih
            // 
            this.txtPilih.FormattingEnabled = true;
            this.txtPilih.Items.AddRange(new object[] {
            "Kode Penjualan",
            "Nama Obat",
            "Nama Pasien",
            "Nama Dokter",
            "Tanggal"});
            this.txtPilih.Location = new System.Drawing.Point(8, 22);
            this.txtPilih.Name = "txtPilih";
            this.txtPilih.Size = new System.Drawing.Size(134, 21);
            this.txtPilih.TabIndex = 75;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtID.Location = new System.Drawing.Point(148, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(140, 20);
            this.txtID.TabIndex = 74;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.AllowUserToAddRows = false;
            this.dgvPenjualan.AllowUserToDeleteRows = false;
            this.dgvPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPenjualan.Location = new System.Drawing.Point(2, 79);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.ReadOnly = true;
            this.dgvPenjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPenjualan.Size = new System.Drawing.Size(871, 416);
            this.dgvPenjualan.TabIndex = 81;
            // 
            // viewPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(874, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPenjualan);
            this.Name = "viewPenjualan";
            this.Text = "View Data Penjualan";
            this.Load += new System.EventHandler(this.viewPenjualan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtPilih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvPenjualan;
    }
}