namespace Siapotik
{
    partial class frmOrderResep
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
            this.txtIDd = new System.Windows.Forms.ComboBox();
            this.txtNamad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlamatd = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDp = new System.Windows.Forms.ComboBox();
            this.txtNamap = new System.Windows.Forms.TextBox();
            this.lblAddp = new System.Windows.Forms.Label();
            this.txtAlamatp = new System.Windows.Forms.RichTextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Obat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDd
            // 
            this.txtIDd.Enabled = false;
            this.txtIDd.FormattingEnabled = true;
            this.txtIDd.Location = new System.Drawing.Point(122, 11);
            this.txtIDd.Name = "txtIDd";
            this.txtIDd.Size = new System.Drawing.Size(90, 21);
            this.txtIDd.TabIndex = 174;
            this.txtIDd.SelectedIndexChanged += new System.EventHandler(this.txtIDd_SelectedIndexChanged);
            this.txtIDd.Click += new System.EventHandler(this.txtIDd_Click);
            // 
            // txtNamad
            // 
            this.txtNamad.Enabled = false;
            this.txtNamad.Location = new System.Drawing.Point(218, 12);
            this.txtNamad.Name = "txtNamad";
            this.txtNamad.Size = new System.Drawing.Size(262, 20);
            this.txtNamad.TabIndex = 202;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 201;
            this.label11.Text = "ID Dokter";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.Enabled = false;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Cyan;
            this.lblAdd.Location = new System.Drawing.Point(491, 15);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(32, 13);
            this.lblAdd.TabIndex = 230;
            this.lblAdd.Text = "Add..";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click_1);
            // 
            // txtFaktur
            // 
            this.txtFaktur.Enabled = false;
            this.txtFaktur.Location = new System.Drawing.Point(715, 11);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(192, 20);
            this.txtFaktur.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 247;
            this.label1.Text = "No. Faktur Pembelian";
            // 
            // txtAlamatd
            // 
            this.txtAlamatd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamatd.Enabled = false;
            this.txtAlamatd.Location = new System.Drawing.Point(122, 38);
            this.txtAlamatd.Name = "txtAlamatd";
            this.txtAlamatd.Size = new System.Drawing.Size(400, 39);
            this.txtAlamatd.TabIndex = 273;
            this.txtAlamatd.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 272;
            this.label12.Text = "Alamat";
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(715, 38);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(191, 20);
            this.dateOrder.TabIndex = 293;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(565, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 291;
            this.label5.Text = "Tanggal Pembelian\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 318;
            this.label6.Text = "ID Pasien";
            // 
            // txtIDp
            // 
            this.txtIDp.Enabled = false;
            this.txtIDp.FormattingEnabled = true;
            this.txtIDp.Location = new System.Drawing.Point(122, 83);
            this.txtIDp.Name = "txtIDp";
            this.txtIDp.Size = new System.Drawing.Size(90, 21);
            this.txtIDp.TabIndex = 317;
            this.txtIDp.SelectedIndexChanged += new System.EventHandler(this.txtIDp_SelectedIndexChanged_1);
            // 
            // txtNamap
            // 
            this.txtNamap.Enabled = false;
            this.txtNamap.Location = new System.Drawing.Point(218, 84);
            this.txtNamap.Name = "txtNamap";
            this.txtNamap.Size = new System.Drawing.Size(262, 20);
            this.txtNamap.TabIndex = 334;
            // 
            // lblAddp
            // 
            this.lblAddp.AutoSize = true;
            this.lblAddp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddp.Enabled = false;
            this.lblAddp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddp.ForeColor = System.Drawing.Color.Cyan;
            this.lblAddp.Location = new System.Drawing.Point(491, 87);
            this.lblAddp.Name = "lblAddp";
            this.lblAddp.Size = new System.Drawing.Size(32, 13);
            this.lblAddp.TabIndex = 350;
            this.lblAddp.Text = "Add..";
            this.lblAddp.Click += new System.EventHandler(this.lblAddp_Click_1);
            // 
            // txtAlamatp
            // 
            this.txtAlamatp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamatp.Enabled = false;
            this.txtAlamatp.Location = new System.Drawing.Point(122, 110);
            this.txtAlamatp.Name = "txtAlamatp";
            this.txtAlamatp.Size = new System.Drawing.Size(400, 39);
            this.txtAlamatp.TabIndex = 363;
            this.txtAlamatp.Text = "";
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
            this.dgvOrder.Location = new System.Drawing.Point(18, 167);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(888, 224);
            this.dgvOrder.TabIndex = 369;
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
            this.harga.HeaderText = "Harga Satuan";
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
            // txtTotalItem
            // 
            this.txtTotalItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.ForeColor = System.Drawing.Color.White;
            this.txtTotalItem.Location = new System.Drawing.Point(115, 411);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.ReadOnly = true;
            this.txtTotalItem.Size = new System.Drawing.Size(265, 22);
            this.txtTotalItem.TabIndex = 384;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 383;
            this.label3.Text = "Total Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 393;
            this.label2.Text = "Total Bayar";
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBayar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBayar.ForeColor = System.Drawing.Color.White;
            this.txtTotalBayar.Location = new System.Drawing.Point(641, 411);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.ReadOnly = true;
            this.txtTotalBayar.Size = new System.Drawing.Size(265, 64);
            this.txtTotalBayar.TabIndex = 392;
            this.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBayar
            // 
            this.txtBayar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtBayar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBayar.ForeColor = System.Drawing.Color.White;
            this.txtBayar.Location = new System.Drawing.Point(641, 482);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(265, 35);
            this.txtBayar.TabIndex = 405;
            this.txtBayar.Text = "0";
            this.txtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBayar.Enter += new System.EventHandler(this.txtBayar_Enter_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(527, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 404;
            this.label4.Text = "Bayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(527, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 411;
            this.label7.Text = "Kembalian";
            // 
            // txtKembalian
            // 
            this.txtKembalian.AcceptsReturn = true;
            this.txtKembalian.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtKembalian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKembalian.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembalian.ForeColor = System.Drawing.Color.White;
            this.txtKembalian.Location = new System.Drawing.Point(641, 526);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.ReadOnly = true;
            this.txtKembalian.Size = new System.Drawing.Size(265, 28);
            this.txtKembalian.TabIndex = 412;
            this.txtKembalian.Text = "0";
            this.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(115, 468);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 29);
            this.btnSimpan.TabIndex = 413;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(208, 468);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 416;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(309, 468);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 418;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // frmOrderResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(926, 575);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBayar);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.txtAlamatp);
            this.Controls.Add(this.lblAddp);
            this.Controls.Add(this.txtNamap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDp);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamatd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtNamad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDd);
            this.MaximizeBox = false;
            this.Name = "frmOrderResep";
            this.Text = "Transaksi Penjualan Obat Resep";
            this.Load += new System.EventHandler(this.frmOrderResep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIDd;
        private System.Windows.Forms.TextBox txtNamad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAlamatd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtIDp;
        private System.Windows.Forms.TextBox txtNamap;
        private System.Windows.Forms.Label lblAddp;
        private System.Windows.Forms.RichTextBox txtAlamatp;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn Obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokA;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokR;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kObat;
        private System.Windows.Forms.TextBox txtTotalItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}