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
    public partial class frmPenjualan : Form
    {
        SqlConnection conn;
        public frmPenjualan()
        {
            InitializeComponent();
        }

        private void frmPenjualan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
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
                urut = "POB" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                // Jika tidak ditemukan maka mengisi variable urut dengan BRG0001
                urut = "POB00001";
            }
            reader.Close();
            txtFaktur.Text = urut;
            conn.Close();
        }

        private void dgvJual_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvJual.Rows[e.RowIndex].Cells[0].Value = dgvJual.Rows[e.RowIndex].Cells[0].Value;
                conn.Open();
                string sql = "Select * FROM T_Obat where ID_Obat = '" + dgvJual.Rows[e.RowIndex].Cells[0].Value + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvJual.Rows[e.RowIndex].Cells[1].Value = reader.GetString(2);
                    dgvJual.Rows[e.RowIndex].Cells[2].Value = reader.GetInt64(7);
                    dgvJual.Rows[e.RowIndex].Cells[3].Value = 0;
                    dgvJual.Rows[e.RowIndex].Cells[4].Value = reader.GetInt64(4);
                    dgvJual.Rows[e.RowIndex].Cells[5].Value = 0;
                    dgvJual.Rows[e.RowIndex].Cells[6].Value = 0;
                    dgvJual.Rows[e.RowIndex].Cells[7].Value = reader.GetString(6);
                }
                conn.Close();
            }

            if (e.ColumnIndex == 3)
            {
                long cell4 = Convert.ToInt64(dgvJual.Rows[e.RowIndex].Cells[4].Value);
                long cell3 = Convert.ToInt64(dgvJual.Rows[e.RowIndex].Cells[3].Value);
                long cell2 = Convert.ToInt64(dgvJual.Rows[e.RowIndex].Cells[2].Value);

                dgvJual.Rows[e.RowIndex].Cells[5].Value = cell4 - cell3;
                dgvJual.Rows[e.RowIndex].Cells[6].Value = cell2 * cell3;
            }

            hitungItem();
            hitungBayar();
        }

        private void hitungItem()
        {
            long line = 0;
            int rows = dgvJual.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvJual.Rows[i].Cells[3].Value);
                txtTotalItem.Text = line.ToString();
            }
        }

        private void hitungBayar()
        {
            long line = 0;
            int rows = dgvJual.Rows.Count;
            for (int i = 0; i < rows - 1; i++)
            {
                line = line + Convert.ToInt64(dgvJual.Rows[i].Cells[6].Value);
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "Tambah")
            {
                cekObat();
                aktif();
                bersih();
                autonumber();
                btnSimpan.Text = "Simpan";
            }
            else
            {
                if (dgvJual.Rows.Count - 1 == 0)
                {
                    MessageBox.Show("Data Obat Belum Diisi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, sql1, ubah;
                        sql = String.Concat("Insert Into T_Penjualan (Kode_Penjualan,Total_Item,Total_Bayar,Tanggal) Values(@p0,@p1,@p2,@p3)");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@p0", txtFaktur.Text);
                        cmd.Parameters.AddWithValue("@p1", txtTotalItem.Text);
                        cmd.Parameters.AddWithValue("@p2", txtTotalBayar.Text);
                        cmd.Parameters.AddWithValue("@p3", dateOrder.Text);
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
                        for (int i = 0; i < dgvJual.Rows.Count - 1; i++)
                        {
                            sql1 = String.Concat("Insert Into T_DetailPenjualan (Kode_Penjualan,ID_Obat,Jumlah) Values(@p5,@p6,@p7)");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = sql1;
                            cmd.Parameters.AddWithValue("@p5", txtFaktur.Text);
                            cmd.Parameters.AddWithValue("@p6", dgvJual.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p7", dgvJual.Rows[i].Cells[3].Value);
                            cmd.ExecuteNonQuery();
                            ubah = String.Concat("Update T_Obat SET Stok = Stok-@p9, Harga_Obat=@p10 WHERE ID_Obat=@p8");
                            cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = ubah;
                            cmd.Parameters.AddWithValue("@p8", dgvJual.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@p9", dgvJual.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@p10", dgvJual.Rows[i].Cells[2].Value);
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

        private void bersih()
        {
            txtFaktur.Clear();
            txtTotalBayar.Clear();
            txtTotalItem.Clear();
            dgvJual.Rows.Clear();
        }

        private void disTxt()
        {
            dgvJual.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void aktif()
        {
            dgvJual.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmObat obat = new frmObat();
            obat.Show();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
            disTxt();
            btnSimpan.Text = "Tambah";
        }
    }
}
