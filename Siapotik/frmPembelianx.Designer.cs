namespace Siapotik
{
    partial class frmOrderSupplier
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Faktur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBatal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDs = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNamas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtIDo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.ComboBox();
            this.txtKeterangan = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAds = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(420, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 112;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(871, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 24);
            this.btnMin.TabIndex = 110;
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
            this.label10.Location = new System.Drawing.Point(404, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 111;
            this.label10.Text = "Data Pemesanan";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(899, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 24);
            this.btnClose.TabIndex = 109;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(59, 19);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(92, 29);
            this.btnTambah.TabIndex = 42;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 95;
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
            this.Faktur,
            this.Supplier,
            this.nSupplier,
            this.Obat,
            this.nObat,
            this.jObat,
            this.sObat,
            this.kObat,
            this.tanggal});
            this.dgvOrder.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrder.Location = new System.Drawing.Point(22, 260);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(883, 291);
            this.dgvOrder.TabIndex = 106;
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // Faktur
            // 
            this.Faktur.HeaderText = "No.Faktur";
            this.Faktur.Name = "Faktur";
            this.Faktur.Width = 120;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "ID Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // nSupplier
            // 
            this.nSupplier.HeaderText = "Nama Supplier";
            this.nSupplier.Name = "nSupplier";
            this.nSupplier.ReadOnly = true;
            this.nSupplier.Width = 150;
            // 
            // Obat
            // 
            this.Obat.HeaderText = "ID Obat";
            this.Obat.Name = "Obat";
            this.Obat.ReadOnly = true;
            this.Obat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nObat
            // 
            this.nObat.HeaderText = "Nama Obat";
            this.nObat.Name = "nObat";
            this.nObat.ReadOnly = true;
            this.nObat.Width = 130;
            // 
            // jObat
            // 
            this.jObat.HeaderText = "Jumlah";
            this.jObat.Name = "jObat";
            this.jObat.ReadOnly = true;
            this.jObat.Width = 80;
            // 
            // sObat
            // 
            this.sObat.HeaderText = "Satuan";
            this.sObat.Name = "sObat";
            this.sObat.ReadOnly = true;
            this.sObat.Width = 80;
            // 
            // kObat
            // 
            this.kObat.HeaderText = "Keterangan";
            this.kObat.Name = "kObat";
            this.kObat.ReadOnly = true;
            this.kObat.Width = 150;
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            this.tanggal.Width = 120;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBatal.Enabled = false;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(428, 19);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 29);
            this.btnBatal.TabIndex = 45;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(22, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 63);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSimpan.Enabled = false;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(654, 19);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 29);
            this.btnSimpan.TabIndex = 47;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(762, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 46;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(195, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 29);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(315, 19);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 29);
            this.btnHapus.TabIndex = 44;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtFaktur
            // 
            this.txtFaktur.Enabled = false;
            this.txtFaktur.Location = new System.Drawing.Point(713, 41);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(192, 20);
            this.txtFaktur.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Tanggal Pemesanan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "No. Faktur Pemesanan";
            // 
            // txtIDs
            // 
            this.txtIDs.Enabled = false;
            this.txtIDs.FormattingEnabled = true;
            this.txtIDs.Location = new System.Drawing.Point(121, 42);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Size = new System.Drawing.Size(90, 21);
            this.txtIDs.TabIndex = 116;
            this.txtIDs.SelectedIndexChanged += new System.EventHandler(this.txtIDs_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 117;
            this.label11.Text = "ID Supplier";
            // 
            // txtNamas
            // 
            this.txtNamas.Enabled = false;
            this.txtNamas.Location = new System.Drawing.Point(217, 43);
            this.txtNamas.Name = "txtNamas";
            this.txtNamas.Size = new System.Drawing.Size(262, 20);
            this.txtNamas.TabIndex = 118;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 119;
            this.label12.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(121, 69);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(400, 39);
            this.txtAlamat.TabIndex = 120;
            this.txtAlamat.Text = "";
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(714, 71);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(191, 20);
            this.dateOrder.TabIndex = 121;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.Enabled = false;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Cyan;
            this.lblAdd.Location = new System.Drawing.Point(489, 156);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(32, 13);
            this.lblAdd.TabIndex = 107;
            this.lblAdd.Text = "Add..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Nama Obat";
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(217, 153);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(262, 20);
            this.txtNama.TabIndex = 123;
            // 
            // txtIDo
            // 
            this.txtIDo.Enabled = false;
            this.txtIDo.FormattingEnabled = true;
            this.txtIDo.Location = new System.Drawing.Point(121, 153);
            this.txtIDo.Name = "txtIDo";
            this.txtIDo.Size = new System.Drawing.Size(90, 21);
            this.txtIDo.TabIndex = 124;
            this.txtIDo.SelectedIndexChanged += new System.EventHandler(this.txtIDo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Jumlah";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Enabled = false;
            this.txtJumlah.Location = new System.Drawing.Point(121, 180);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(90, 20);
            this.txtJumlah.TabIndex = 126;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Enabled = false;
            this.txtSatuan.FormattingEnabled = true;
            this.txtSatuan.Items.AddRange(new object[] {
            "Dos",
            "Pc",
            "Pack",
            ""});
            this.txtSatuan.Location = new System.Drawing.Point(217, 179);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(90, 21);
            this.txtSatuan.TabIndex = 127;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeterangan.Enabled = false;
            this.txtKeterangan.Location = new System.Drawing.Point(121, 206);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(400, 39);
            this.txtKeterangan.TabIndex = 128;
            this.txtKeterangan.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 129;
            this.label4.Text = "Keterangan";
            // 
            // lblAds
            // 
            this.lblAds.AutoSize = true;
            this.lblAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAds.Enabled = false;
            this.lblAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAds.ForeColor = System.Drawing.Color.Cyan;
            this.lblAds.Location = new System.Drawing.Point(489, 45);
            this.lblAds.Name = "lblAds";
            this.lblAds.Size = new System.Drawing.Size(32, 13);
            this.lblAds.TabIndex = 130;
            this.lblAds.Text = "Add..";
            this.lblAds.Click += new System.EventHandler(this.lblAds_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 24);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // frmPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(929, 651);
            this.Controls.Add(this.lblAds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDo);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNamas);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPemesanan";
            this.Text = "Pembelian Stock Obat";
            this.Load += new System.EventHandler(this.frmPemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtIDs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNamas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox txtIDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.ComboBox txtSatuan;
        private System.Windows.Forms.RichTextBox txtKeterangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faktur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;

    }
}