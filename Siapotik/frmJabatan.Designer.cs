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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.kdJabatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 29);
            this.button3.TabIndex = 44;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 29);
            this.button2.TabIndex = 43;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 29);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Tambah";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJabatan
            // 
            this.txtJabatan.Location = new System.Drawing.Point(160, 66);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(218, 20);
            this.txtJabatan.TabIndex = 40;
            // 
            // kdJabatan
            // 
            this.kdJabatan.Location = new System.Drawing.Point(160, 32);
            this.kdJabatan.Name = "kdJabatan";
            this.kdJabatan.Size = new System.Drawing.Size(117, 20);
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
            // frmJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 168);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.kdJabatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJabatan";
            this.Text = "Jabatan Pegawai";
            this.Load += new System.EventHandler(this.frmJabatan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.TextBox kdJabatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}