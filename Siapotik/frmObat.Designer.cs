namespace Siapotik
{
    partial class frmObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.baru = new System.Windows.Forms.ToolStripButton();
            this.simpan = new System.Windows.Forms.ToolStripButton();
            this.batal = new System.Windows.Forms.ToolStripButton();
            this.edit = new System.Windows.Forms.ToolStripButton();
            this.hapus = new System.Windows.Forms.ToolStripButton();
            this.keluar = new System.Windows.Forms.ToolStripButton();
            this.selesai = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golonganObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jlhStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baru,
            this.simpan,
            this.batal,
            this.edit,
            this.hapus,
            this.keluar,
            this.selesai});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(893, 71);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 25;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // baru
            // 
            this.baru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baru.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baru.Image = ((System.Drawing.Image)(resources.GetObject("baru.Image")));
            this.baru.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.baru.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baru.Name = "baru";
            this.baru.Size = new System.Drawing.Size(113, 68);
            this.baru.Text = "Baru";
            // 
            // simpan
            // 
            this.simpan.Enabled = false;
            this.simpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan.Image = ((System.Drawing.Image)(resources.GetObject("simpan.Image")));
            this.simpan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.simpan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(136, 68);
            this.simpan.Text = "Simpan";
            // 
            // batal
            // 
            this.batal.Enabled = false;
            this.batal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batal.Image = ((System.Drawing.Image)(resources.GetObject("batal.Image")));
            this.batal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.batal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(117, 68);
            this.batal.Text = "Batal";
            // 
            // edit
            // 
            this.edit.Enabled = false;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(108, 68);
            this.edit.Text = "Edit";
            // 
            // hapus
            // 
            this.hapus.Enabled = false;
            this.hapus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus.Image = ((System.Drawing.Image)(resources.GetObject("hapus.Image")));
            this.hapus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(126, 68);
            this.hapus.Text = "Hapus";
            // 
            // keluar
            // 
            this.keluar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.keluar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keluar.Image = ((System.Drawing.Image)(resources.GetObject("keluar.Image")));
            this.keluar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keluar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(127, 68);
            this.keluar.Text = "Keluar";
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // selesai
            // 
            this.selesai.Enabled = false;
            this.selesai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selesai.Image = ((System.Drawing.Image)(resources.GetObject("selesai.Image")));
            this.selesai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.selesai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selesai.Name = "selesai";
            this.selesai.Size = new System.Drawing.Size(131, 68);
            this.selesai.Text = "Selesai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kode Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Golongan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Jumlah Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Harga Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kadaluarsa";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(137, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(632, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(632, 202);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(235, 20);
            this.textBox5.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeObat,
            this.namaObat,
            this.golonganObat,
            this.jlhStock,
            this.hargaSatuan,
            this.totalHarga,
            this.kadaluarsa});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 238);
            this.dataGridView1.TabIndex = 40;
            // 
            // kodeObat
            // 
            this.kodeObat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeObat.HeaderText = "Kode Obat";
            this.kodeObat.Name = "kodeObat";
            this.kodeObat.Width = 83;
            // 
            // namaObat
            // 
            this.namaObat.HeaderText = "Nama Obat";
            this.namaObat.Name = "namaObat";
            this.namaObat.Width = 200;
            // 
            // golonganObat
            // 
            this.golonganObat.HeaderText = "Golongan";
            this.golonganObat.Name = "golonganObat";
            this.golonganObat.Width = 150;
            // 
            // jlhStock
            // 
            this.jlhStock.HeaderText = "Jumlah Stock";
            this.jlhStock.Name = "jlhStock";
            // 
            // hargaSatuan
            // 
            this.hargaSatuan.HeaderText = "Harga Satuan";
            this.hargaSatuan.Name = "hargaSatuan";
            this.hargaSatuan.Width = 150;
            // 
            // totalHarga
            // 
            this.totalHarga.HeaderText = "Total";
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Width = 200;
            // 
            // kadaluarsa
            // 
            this.kadaluarsa.HeaderText = "Kadaluarsa";
            this.kadaluarsa.Name = "kadaluarsa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(292, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Add..";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 544);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Obat";
            this.Load += new System.EventHandler(this.frmObat_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton baru;
        internal System.Windows.Forms.ToolStripButton simpan;
        internal System.Windows.Forms.ToolStripButton batal;
        internal System.Windows.Forms.ToolStripButton edit;
        internal System.Windows.Forms.ToolStripButton hapus;
        internal System.Windows.Forms.ToolStripButton keluar;
        internal System.Windows.Forms.ToolStripButton selesai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn golonganObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jlhStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadaluarsa;
        private System.Windows.Forms.Label label8;
    }
}