namespace Siapotik
{
    partial class frmPembelian
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
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNamas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Obat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAds = new System.Windows.Forms.Label();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalItem = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(713, 40);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(191, 20);
            this.dateOrder.TabIndex = 148;
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(120, 38);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(400, 39);
            this.txtAlamat.TabIndex = 147;
            this.txtAlamat.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 146;
            this.label12.Text = "Alamat";
            // 
            // txtNamas
            // 
            this.txtNamas.Enabled = false;
            this.txtNamas.Location = new System.Drawing.Point(216, 12);
            this.txtNamas.Name = "txtNamas";
            this.txtNamas.Size = new System.Drawing.Size(262, 20);
            this.txtNamas.TabIndex = 145;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 144;
            this.label11.Text = "ID Supplier";
            // 
            // txtIDs
            // 
            this.txtIDs.Enabled = false;
            this.txtIDs.FormattingEnabled = true;
            this.txtIDs.Location = new System.Drawing.Point(120, 11);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Size = new System.Drawing.Size(90, 21);
            this.txtIDs.TabIndex = 143;
            this.txtIDs.SelectedIndexChanged += new System.EventHandler(this.txtIDs_SelectedIndexChanged);
            this.txtIDs.Click += new System.EventHandler(this.txtIDs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(563, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 133;
            this.label5.Text = "Tanggal Penerimaan";
            // 
            // txtFaktur
            // 
            this.txtFaktur.Enabled = false;
            this.txtFaktur.Location = new System.Drawing.Point(712, 10);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(192, 20);
            this.txtFaktur.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 132;
            this.label1.Text = "No. Faktur Pembelian";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Obat,
            this.nObat,
            this.harga,
            this.jBeli,
            this.stokA,
            this.stokR,
            this.tBayar,
            this.kObat});
            this.dgvOrder.Enabled = false;
            this.dgvOrder.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrder.Location = new System.Drawing.Point(22, 90);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(882, 363);
            this.dgvOrder.TabIndex = 136;
            this.dgvOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellEndEdit);
            // 
            // Obat
            // 
            this.Obat.HeaderText = "ID Obat";
            this.Obat.Name = "Obat";
            this.Obat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nObat
            // 
            this.nObat.HeaderText = "Nama Obat";
            this.nObat.Name = "nObat";
            this.nObat.ReadOnly = true;
            this.nObat.Width = 170;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            // 
            // jBeli
            // 
            this.jBeli.HeaderText = "Jumlah Beli";
            this.jBeli.Name = "jBeli";
            // 
            // stokA
            // 
            this.stokA.HeaderText = "Stok Awal";
            this.stokA.Name = "stokA";
            this.stokA.ReadOnly = true;
            // 
            // stokR
            // 
            this.stokR.HeaderText = "Stok Akhir";
            this.stokR.Name = "stokR";
            this.stokR.ReadOnly = true;
            // 
            // tBayar
            // 
            this.tBayar.HeaderText = "Total Bayar";
            this.tBayar.Name = "tBayar";
            this.tBayar.ReadOnly = true;
            // 
            // kObat
            // 
            this.kObat.HeaderText = "Keterangan";
            this.kObat.Name = "kObat";
            this.kObat.ReadOnly = true;
            this.kObat.Width = 250;
            // 
            // lblAds
            // 
            this.lblAds.AutoSize = true;
            this.lblAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAds.Enabled = false;
            this.lblAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAds.ForeColor = System.Drawing.Color.Cyan;
            this.lblAds.Location = new System.Drawing.Point(488, 14);
            this.lblAds.Name = "lblAds";
            this.lblAds.Size = new System.Drawing.Size(32, 13);
            this.lblAds.TabIndex = 157;
            this.lblAds.Text = "Add..";
            this.lblAds.Click += new System.EventHandler(this.lblAds_Click);
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBayar.Enabled = false;
            this.txtTotalBayar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBayar.ForeColor = System.Drawing.Color.White;
            this.txtTotalBayar.Location = new System.Drawing.Point(639, 470);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(265, 64);
            this.txtTotalBayar.TabIndex = 159;
            this.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(525, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 160;
            this.label2.Text = "Total Bayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 161;
            this.label3.Text = "Total Item";
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItem.Enabled = false;
            this.txtTotalItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.ForeColor = System.Drawing.Color.White;
            this.txtTotalItem.Location = new System.Drawing.Point(119, 470);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.Size = new System.Drawing.Size(265, 22);
            this.txtTotalItem.TabIndex = 162;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(120, 507);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 29);
            this.btnSimpan.TabIndex = 163;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(216, 507);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 164;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(313, 507);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 165;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // frmPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 552);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBayar);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNamas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lblAds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPembelian";
            this.Text = "Transaksi Pembelian Barang dari Supplier";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNamas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtIDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblAds;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalItem;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridViewComboBoxColumn Obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokA;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokR;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kObat;
        private System.Windows.Forms.Button btnHapus;
    }
}