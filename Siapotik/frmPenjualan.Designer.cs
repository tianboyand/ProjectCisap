namespace Siapotik
{
    partial class frmPenjualan
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
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTotalItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dgvJual = new System.Windows.Forms.DataGridView();
            this.Obat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(221, 515);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 186;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(125, 515);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 29);
            this.btnSimpan.TabIndex = 185;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.ForeColor = System.Drawing.Color.White;
            this.txtTotalItem.Location = new System.Drawing.Point(124, 478);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.Size = new System.Drawing.Size(265, 22);
            this.txtTotalItem.TabIndex = 184;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 183;
            this.label3.Text = "Total Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 182;
            this.label2.Text = "Total Bayar";
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBayar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBayar.ForeColor = System.Drawing.Color.White;
            this.txtTotalBayar.Location = new System.Drawing.Point(644, 478);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(265, 64);
            this.txtTotalBayar.TabIndex = 181;
            this.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(715, 26);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(191, 20);
            this.dateOrder.TabIndex = 179;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(4, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 24);
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(561, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 167;
            this.label5.Text = "Tanggal Pembelian";
            // 
            // txtFaktur
            // 
            this.txtFaktur.Enabled = false;
            this.txtFaktur.Location = new System.Drawing.Point(173, 26);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(192, 20);
            this.txtFaktur.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 166;
            this.label1.Text = "No. Nota Pembelian\r\n";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(875, -23);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 24);
            this.btnMin.TabIndex = 172;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(408, -18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 173;
            this.label10.Text = "Data Pemesanan";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(903, -23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 24);
            this.btnClose.TabIndex = 171;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // dgvJual
            // 
            this.dgvJual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJual.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Obat,
            this.nObat,
            this.harga,
            this.jBeli,
            this.stokA,
            this.stokR,
            this.tBayar,
            this.kObat});
            this.dgvJual.Enabled = false;
            this.dgvJual.GridColor = System.Drawing.SystemColors.Control;
            this.dgvJual.Location = new System.Drawing.Point(27, 80);
            this.dgvJual.Name = "dgvJual";
            this.dgvJual.Size = new System.Drawing.Size(879, 363);
            this.dgvJual.TabIndex = 169;
            this.dgvJual.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJual_CellEndEdit);
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
            this.jBeli.HeaderText = "QTY";
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
            // frmPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(934, 565);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBayar);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvJual);
            this.MaximizeBox = false;
            this.Name = "frmPenjualan";
            this.Text = "Transaksi Penjualan Obat Non-Resep";
            this.Load += new System.EventHandler(this.frmPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtTotalItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.DataGridView dgvJual;
        private System.Windows.Forms.DataGridViewComboBoxColumn Obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokA;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokR;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kObat;

    }
}