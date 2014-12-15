using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Siapotik
{
    public partial class frmOrderSupplier : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmOrderSupplier()
        {
            InitializeComponent();
        }

        public void koneks()
        {
            classKoneksi konek = new classKoneksi();
            konek.openKoneksi();
        }

        public void konekc()
        {
            classKoneksi konek = new classKoneksi();
            konek.closeKoneksi();
        }

        private void frmPemesanan_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            //classKoneksi konek = new classKoneksi();
            //konek.koneksi();
            konekc();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            cekObat();
            if (btnTambah.Text == "Tambah")
            {
                //aktif();
                dgvOrder.Rows.Clear();
                aktifTxt();
                bersihTxt();
                autonumber();
                cekSupplier();
                btnBatal.Enabled = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                btnSimpan.Enabled = true;
                btnTambah.Text = "Add Item";
            }
            else
            {
                if (txtIDo.Text == "" || txtJumlah.Text == "" || txtSatuan.Text == "")
                {
                    MessageBox.Show("Data belum lengkap!");
                }
                else
                {
                    string[] baris = new string[] { txtFaktur.Text, txtIDs.Text, txtNamas.Text, txtIDo.Text, txtNama.Text, txtJumlah.Text, txtSatuan.Text,
                txtKeterangan.Text, dateOrder.Text};
                    dgvOrder.Rows.Add(baris);
                    bersihTxt();
                }
                txtIDs.Enabled = false;
                lblAds.Enabled = false;
                btnEdit.Enabled = true;
                btnEdit.Text = "Update";
                btnHapus.Enabled = true;
            }

                //cekGolongan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                conn.Open();
               // aktif();
                //kdObat.Enabled = false;
                btnEdit.Text = "Update";
                btnBatal.Enabled = true;
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                conn.Close();
                //cekGolongan();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE T_ SET ID_Supplier='" + txtIDs.Text + "',Kode_Obat='" + txtIDo.Text + "',Jumlah='" + txtJumlah.Text + "', Satuan='" + txtSatuan.Text + 
                    "', Keterangan='" + txtKeterangan.Text + "', Tanggal='" + dateOrder.Text + "' WHERE Faktur_Pemesanan='" + txtFaktur.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    DialogResult result = MessageBox.Show("Yakin Ubah Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Diupdate");
                        MessageBox.Show(pesan, "Success");
                    }
                    else
                    {
                       // distxt();
                    }
                    conn.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Terjadi kesalahan karena: " + err);
                }
                //tampilData();
                btnEdit.Text = "Edit";
                btnBatal.Enabled = false;
                btnTambah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvOrder.SelectedRows)
            {
                dgvOrder.Rows.RemoveAt(item.Index);
                MessageBox.Show("Data Berhasil Dihapus");
            }
            bersihTxt();
        }

        private void txtIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select Nama,Alamat from T_Supplier where ID_Supplier = '" + txtIDs.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNamas.Text = (reader.GetString(0));
                txtAlamat.Text = (reader.GetString(1));
            }
            conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            int rows = dgvOrder.Rows.Count;

                for (int i = 0; i < rows - 1; i++)
                {
                    string value1 = dgvOrder.Rows[i].Cells[0].Value.ToString();
                    string value2 = dgvOrder.Rows[i].Cells[1].Value.ToString();
                    string value3 = dgvOrder.Rows[i].Cells[3].Value.ToString();
                    string value4 = dgvOrder.Rows[i].Cells[5].Value.ToString();
                    string value5 = dgvOrder.Rows[i].Cells[6].Value.ToString();
                    string value6 = dgvOrder.Rows[i].Cells[7].Value.ToString();
                    string value7 = dgvOrder.Rows[i].Cells[8].Value.ToString();
                    string sql;
                    sql = String.Concat("Insert Into T_Pemesanan Values ('",
                    value1, "', '", value2, "', '", value3, "', '", value4, "', '", value5, "', '", value6, "', '", value7, "')");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;                          
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            MessageBox.Show("Data Berhasil Disimpan","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvOrder.Rows.Clear();    
            bersihHead();
            disTxt(); 
            conn.Close();
           // }
            //catch (Exception err)
            //{
            //    MessageBox.Show("Terjadi kesalahan karena: " + err);
            //}
            btnTambah.Text = "Tambah";
            btnBatal.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void bersihTxt()
        {
            txtIDo.Text = "";
            txtNama.Text = "";
            txtJumlah.Text = "";
            txtSatuan.Text = "";
            txtKeterangan.Text = "";
        }

        private void disTxt()
        {
            txtIDo.Enabled = false;
            txtJumlah.Enabled = false;
            txtSatuan.Enabled = false;
            lblAdd.Enabled = false;
        }

        private void bersihHead()
        {
            txtIDs.Text = "";
            txtFaktur.Text = "";
            txtNamas.Text = "";
            txtAlamat.Text = "";
            dateOrder.Text = "";
        }

        private void aktifTxt()
        {
            txtIDs.Enabled = true;
            lblAds.Enabled = true;
            txtIDo.Enabled = true;
            lblAdd.Enabled = true;
            txtJumlah.Enabled = true;
            txtSatuan.Enabled = true;
        }


        private void autonumber()
        {
            int hitung;
            string urut;
            conn.Open();
            // Mempersiapkan koneksi database;

            // Perintah untuk mendapatkan nilai terbesar dari field nomor
            SqlCommand cmd = new SqlCommand("select Faktur_Pemesanan from T_Pemesanan where Faktur_Pemesanan in(select max(Faktur_Pemesanan) from T_Pemesanan) order by Faktur_Pemesanan desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            // Jika data ditemukan
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["Faktur_Pemesanan"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "POF" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                // Jika tidak ditemukan maka mengisi variable urut dengan BRG0001
                urut = "POF00001";
            }
            reader.Close();
            txtFaktur.Text = urut;
            conn.Close();
        }

        private void lblAds_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.Show();
        }

        private void cekSupplier()
        {
            conn.Open();
            txtIDs.Items.Clear();
            string sql = "Select ID_Supplier from T_Supplier";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                txtIDs.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void cekObat()
        {
            
            txtIDo.Items.Clear();
            string sql = "Select ID_Obat from T_DataObat";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIDo.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void txtIDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select Nama_Obat,Keterangan from T_DataObat where ID_Obat = '" + txtIDo.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNama.Text = (reader.GetString(0));
                txtKeterangan.Text = (reader.GetString(1));
            }
            conn.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihHead();
            bersihTxt();
            dgvOrder.Rows.Clear(); 
            btnTambah.Text = "Tambah";
            disTxt();
            txtIDs.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = false;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = int.Parse(e.RowIndex.ToString());
            txtFaktur.Text = dgvOrder[0, baris].Value.ToString();
            txtIDs.Text = dgvOrder[1, baris].Value.ToString();
            txtNamas.Text = dgvOrder[2, baris].Value.ToString();
            txtIDo.Text = dgvOrder[3, baris].Value.ToString();
            txtNama.Text = dgvOrder[4, baris].Value.ToString();
            txtJumlah.Text = dgvOrder[5, baris].Value.ToString();
            txtSatuan.Text = dgvOrder[6, baris].Value.ToString();
            txtKeterangan.Text = dgvOrder[7, baris].Value.ToString();
        }

    }
}
