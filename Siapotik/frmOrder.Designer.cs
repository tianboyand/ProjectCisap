namespace Siapotik
{
    partial class frmOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalItem = new System.Windows.Forms.TextBox();
            this.kObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblAds = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.txtIDs = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNamas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(667, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 211;
            this.label3.Text = "Total Item";
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.BackColor = System.Drawing.Color.White;
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItem.Enabled = false;
            this.txtTotalItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.ForeColor = System.Drawing.Color.Black;
            this.txtTotalItem.Location = new System.Drawing.Point(742, 525);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.Size = new System.Drawing.Size(73, 22);
            this.txtTotalItem.TabIndex = 210;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kObat
            // 
            this.kObat.HeaderText = "Keterangan";
            this.kObat.Name = "kObat";
            this.kObat.ReadOnly = true;
            this.kObat.Width = 250;
            // 
            // jBeli
            // 
            this.jBeli.HeaderText = "Jumlah Beli";
            this.jBeli.Name = "jBeli";
            this.jBeli.Width = 130;
            // 
            // nObat
            // 
            this.nObat.HeaderText = "Nama Obat";
            this.nObat.Name = "nObat";
            this.nObat.ReadOnly = true;
            this.nObat.Width = 260;
            // 
            // Obat
            // 
            this.Obat.HeaderText = "ID Obat";
            this.Obat.Name = "Obat";
            this.Obat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obat.Width = 110;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Obat,
            this.nObat,
            this.jBeli,
            this.kObat});
            this.dgvOrders.Enabled = false;
            this.dgvOrders.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrders.Location = new System.Drawing.Point(22, 143);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(793, 363);
            this.dgvOrders.TabIndex = 193;
            this.dgvOrders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellEndEdit);
            // 
            // lblAds
            // 
            this.lblAds.AutoSize = true;
            this.lblAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAds.Enabled = false;
            this.lblAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAds.ForeColor = System.Drawing.Color.Cyan;
            this.lblAds.Location = new System.Drawing.Point(536, 56);
            this.lblAds.Name = "lblAds";
            this.lblAds.Size = new System.Drawing.Size(32, 13);
            this.lblAds.TabIndex = 204;
            this.lblAds.Text = "Add..";
            this.lblAds.Click += new System.EventHandler(this.lblAds_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCetak.Enabled = false;
            this.btnCetak.FlatAppearance.BorderSize = 0;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(356, 523);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(71, 29);
            this.btnCetak.TabIndex = 209;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 191;
            this.label1.Text = "No. Faktur Pemesanan";
            // 
            // txtFaktur
            // 
            this.txtFaktur.Enabled = false;
            this.txtFaktur.Location = new System.Drawing.Point(168, 12);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(192, 20);
            this.txtFaktur.TabIndex = 192;
            // 
            // txtIDs
            // 
            this.txtIDs.Enabled = false;
            this.txtIDs.FormattingEnabled = true;
            this.txtIDs.Location = new System.Drawing.Point(168, 53);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Size = new System.Drawing.Size(90, 21);
            this.txtIDs.TabIndex = 198;
            this.txtIDs.SelectedIndexChanged += new System.EventHandler(this.txtIDs_SelectedIndexChanged);
            this.txtIDs.Click += new System.EventHandler(this.txtIDs_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 199;
            this.label11.Text = "ID Supplier";
            // 
            // txtNamas
            // 
            this.txtNamas.Enabled = false;
            this.txtNamas.Location = new System.Drawing.Point(264, 54);
            this.txtNamas.Name = "txtNamas";
            this.txtNamas.Size = new System.Drawing.Size(262, 20);
            this.txtNamas.TabIndex = 200;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 201;
            this.label12.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(168, 80);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(400, 39);
            this.txtAlamat.TabIndex = 202;
            this.txtAlamat.Text = "";
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(376, 12);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(192, 20);
            this.dateOrder.TabIndex = 203;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(22, 523);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 29);
            this.btnSimpan.TabIndex = 205;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(243, 523);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 206;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(131, 523);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 208;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(837, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNamas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDs);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAds);
            this.Controls.Add(this.dgvOrders);
            this.MaximizeBox = false;
            this.Name = "frmOrder";
            this.Text = "Pemesanan Obat";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nObat;
        private System.Windows.Forms.DataGridViewComboBoxColumn Obat;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblAds;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.ComboBox txtIDs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNamas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.OpenFileDialog dlgOpen;

    }
}