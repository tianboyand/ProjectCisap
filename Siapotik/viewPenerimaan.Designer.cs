namespace Siapotik
{
    partial class viewPenerimaan
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
            this.dgvPenerimaan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerimaan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPilih);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 61);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // txtPilih
            // 
            this.txtPilih.FormattingEnabled = true;
            this.txtPilih.Items.AddRange(new object[] {
            "Kode Faktur",
            "Nama Obat"});
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
            // dgvPenerimaan
            // 
            this.dgvPenerimaan.AllowUserToAddRows = false;
            this.dgvPenerimaan.AllowUserToDeleteRows = false;
            this.dgvPenerimaan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenerimaan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPenerimaan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPenerimaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenerimaan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPenerimaan.Location = new System.Drawing.Point(1, 79);
            this.dgvPenerimaan.Name = "dgvPenerimaan";
            this.dgvPenerimaan.ReadOnly = true;
            this.dgvPenerimaan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPenerimaan.Size = new System.Drawing.Size(883, 391);
            this.dgvPenerimaan.TabIndex = 79;
            // 
            // viewPenerimaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(886, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPenerimaan);
            this.Name = "viewPenerimaan";
            this.Text = "View Data Penerimaan";
            this.Load += new System.EventHandler(this.viewPenerimaan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerimaan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtPilih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvPenerimaan;
    }
}