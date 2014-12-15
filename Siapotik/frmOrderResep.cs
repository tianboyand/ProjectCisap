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
    public partial class frmOrderResep : Form
    {
        SqlConnection conn;
        public frmOrderResep()
        {
            InitializeComponent();
        }

        private void frmOrderResep_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            //cekDokter();
            //cekPasien();
        }

        private void hitungItem()
        {
            long line = 0;
            int rows = dgvOrder.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvOrder.Rows[i].Cells[3].Value);
                txtTotalItem.Text = line.ToString();
            }
        }

        private void hitungBayar()
        {
            long line = 0;
            int rows = dgvOrder.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvOrder.Rows[i].Cells[6].Value);
                txtTotalBayar.Text = line.ToString();
            }
        }

        private void cekObat()
        {
            Obat.Items.Clear();
            conn.Open();
            string sql = "Select * from T_Obat";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Obat.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void cekDokter()
        {
            conn.Open();
            txtIDd.Items.Clear();
            string sql = "Select ID_Dokter from T_Dokter";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIDd.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void cekPasien()
        {
            conn.Open();
            txtIDd.Items.Clear();
            string sql = "Select ID_Pasien from T_Pasien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIDp.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void txtIDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select * from T_Dokter where ID_Dokter = '" + txtIDd.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNamad.Text = (reader.GetString(1));
                txtAlamatd.Text = (reader.GetString(3));
            }
            conn.Close();
        }

        private void autonumber()
        {
            int hitung;
            string urut;
            conn.Open();
            // Mempersiapkan koneksi database;

            // Perintah untuk mendapatkan nilai terbesar dari field nomor
            SqlCommand cmd = new SqlCommand("select Kode_Penjualan from T_Penjualan where Kode_Penjualan in(select max(Kode_Penjualan) from T_Penjualan) order by Kode_Penjualan desc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            // Jika data ditemukan
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt32(reader[0].ToString().Substring(reader["Kode_Penjualan"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string BRG
                urut = "POBX" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                // Jika tidak ditemukan maka mengisi variable urut dengan BRG0001
                urut = "POBX00001";
            }
            reader.Close();
            txtFaktur.Text = urut;
            conn.Close();
        }

        private void bersih()
        {
            txtFaktur.Clear();
            txtIDd.Text = "";
            txtAlamatd.Clear();
            txtNamad.Clear();
            txtIDp.Text = "";
            txtAlamatp.Clear();
            txtNamap.Clear();
            txtTotalBayar.Clear();
            txtTotalItem.Clear();
            txtBayar.Clear();
            txtKembalian.Clear();
            dgvOrder.Rows.Clear();
        }

        private void disTxt()
        {
            txtIDd.Enabled = false;
            txtIDp.Enabled = false;
            dgvOrder.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            lblAdd.Enabled = false;
            lblAddp.Enabled = false;
        }

        private void aktif()
        {
            txtIDd.Enabled = true;
            txtIDp.Enabled = true;
            dgvOrder.Enabled = true;
            btnBatal.Enabled = true;
            btnHapus.Enabled = true;
            lblAdd.Enabled = true;
            lblAddp.Enabled = true;
        }

        private void txtIDd_Click(object sender, EventArgs e)
        {
            cekDokter();
        }

        private void txtIDp_Click(object sender, EventArgs e)
        {
            cekPasien();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "Tambah")
            {
                cekObat();
                cekDokter();
                cekPasien();
                aktif();
                bersih();
                autonumber();
                btnSimpan.Text = "Simpan";
            }
            else
            {
                if (txtFaktur.Text == "")
                {
                    MessageBox.Show("No.Faktur Belum Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFaktur.Focus();
                }
                else if (txtIDd.Text == "")
                {
                    MessageBox.Show("ID Dokter Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIDd.Focus();
                }
                else if (txtIDp.Text == "")
                {
                    MessageBox.Show("ID Pasien Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIDp.Focus();
                }
                else if (dgvOrder.Rows.Count - 1 == 0)
                {
                    MessageBox.Show("Data Obat Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, sql1, ubah;
                        sql = String.Concat("Insert Into T_Penjualan (Kode_Penjualan,Total_Item,Total_Bayar,Tanggal,ID_Dokter,ID_Pasien) Values(@p0,@p1,@p2,@p3,@p8,@p9)");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@p0", txtFaktur.Text);
                        cmd.Parameters.AddWithValue("@p1", txtTotalItem.Text);
                        cmd.Parameters.AddWithValue("@p2", txtTotalBayar.Text);
                        cmd.Parameters.AddWithValue("@p3", dateOrder.Text);
                        cmd.Parameters.AddWithValue("@p8", txtIDd.Text);
                        cmd.Parameters.AddWithValue("@p9", txtIDp.Text);
                        cmd.ExecuteNonQuery();
                        //for (int i = 0; i < rows - 1; i++)
                        //{
                        //    string value1 = txtFaktur.Text;
                        //    string value2 = dgvOrder.Rows[i].Cells[0].Value.ToString();
                        //    string value3 = dgvOrder.Rows[i].Cells[3].Value.ToString();
                        //    sql1 = String.Concat("Insert Into T_DetailPenerimaan Values ('",
                        //    value1, "', '", value2, "', '", value3, "')");
                        //    cmd = new SqlCommand();
                        //    cmd.Connection = conn;
                        //    cmd.CommandText = sql1;
                        //    cmd.ExecuteNonQuery();
                        //}
                        for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                        {
                            sql1 = String.Concat("Insert Into T_DetailPenjualan (Kode_Penjualan,ID_Obat,Jumlah) Values(@p5,@p6,@p7)");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql1;
                            cmd.Parameters.AddWithValue("@p5", txtFaktur.Text);
                            cmd.Parameters.AddWithValue("@p6", dgvOrder.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p7", dgvOrder.Rows[i].Cells[3].Value);
                            cmd.ExecuteNonQuery();
                            ubah = String.Concat("Update T_Obat SET Stok = Stok-@p9, Harga_Obat=@p10 WHERE ID_Obat=@p8");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = ubah;
                            cmd.Parameters.AddWithValue("@p8", dgvOrder.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p9", dgvOrder.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@p10", dgvOrder.Rows[i].Cells[2].Value);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data Berhasil Disimpan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        disTxt();
                        conn.Close();
                        btnSimpan.Text = "Tambah";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Terjadi kesalahan karena: " + err);
                    }
                }
            }
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            bersih();
            disTxt();
            btnSimpan.Text = "Tambah";
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvOrder.SelectedRows)
            {
                dgvOrder.Rows.RemoveAt(item.Index);
                MessageBox.Show("Data Berhasil Dihapus");
            }
        }

        private void lblAdd_Click_1(object sender, EventArgs e)
        {
            frmDokter dokter = new frmDokter();
            dokter.Show();
        }

        private void lblAddp_Click_1(object sender, EventArgs e)
        {
            frmPasien pasien = new frmPasien();
            pasien.Show();
        }

        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cekObat();
            if (e.ColumnIndex == 0)
            {
                dgvOrder.Rows[e.RowIndex].Cells[0].Value = dgvOrder.Rows[e.RowIndex].Cells[0].Value;
                conn.Open();
                string sql = "Select * FROM T_Obat where ID_Obat = '" + dgvOrder.Rows[e.RowIndex].Cells[0].Value + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOrder.Rows[e.RowIndex].Cells[1].Value = reader.GetString(2);
                    dgvOrder.Rows[e.RowIndex].Cells[2].Value = reader.GetInt64(3);
                    dgvOrder.Rows[e.RowIndex].Cells[3].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[4].Value = reader.GetInt64(4);
                    dgvOrder.Rows[e.RowIndex].Cells[5].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[6].Value = 0;
                    dgvOrder.Rows[e.RowIndex].Cells[7].Value = reader.GetString(6);
                }
                long stok = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[4].Value);
                long harga = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[2].Value);
                if (harga == 0)
                {
                    MessageBox.Show("Harga Obat Masih kosong! Tidak Dapat Dijual", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvOrder.Rows.RemoveAt(e.RowIndex);
                }
                else if (stok == 0)
                {
                    MessageBox.Show("Stok Obat Masih kosong! Tidak Dapat Dijual", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvOrder.Rows.RemoveAt(e.RowIndex);
                }
                conn.Close();
            }

            if (e.ColumnIndex == 3)
            {
                long cell4 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[4].Value);
                long cell3 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[3].Value);
                long cell2 = Convert.ToInt64(dgvOrder.Rows[e.RowIndex].Cells[2].Value);

                dgvOrder.Rows[e.RowIndex].Cells[5].Value = cell4 - cell3;
                dgvOrder.Rows[e.RowIndex].Cells[6].Value = cell2 * cell3;
            }

            hitungItem();
            hitungBayar();
        }

        private void txtBayar_Enter_1(object sender, EventArgs e)
        {
            long kembalian, bayar, totalbayar;
            bayar = long.Parse(this.txtBayar.Text);
            totalbayar = long.Parse(this.txtTotalBayar.Text);
            kembalian = bayar - totalbayar;
            this.txtKembalian.Text = Convert.ToString(kembalian);
        }

        private void txtIDp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select * from T_Pasien where ID_Pasien = '" + txtIDp.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNamap.Text = (reader.GetString(1));
                txtAlamatp.Text = (reader.GetString(3));
            }
            conn.Close();
        }
    }
}
