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
    public partial class frmObat : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public frmObat()
        {
            InitializeComponent();
        }

        private void frmObat_Load(object sender, EventArgs e)
        {
            //long beli = Convert.ToInt64(txtHarga.Text);
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            cekGolongan();
            tampilData();
        }

        private void tampilData()
        {
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter("Select ID_Obat, Nama_Obat, Golongan, Harga_Obat, Stok, Kadaluarsa, Keterangan, Harga_Jual from T_Obat JOIN T_Golongan_Obat ON T_Obat.Kode_Golongan = T_Golongan_Obat.Kode_Golongan", conn);
                da.Fill(ds, "Test");
                dgvObat.ReadOnly = true;
                dgvObat.AllowUserToAddRows = false;
                dgvObat.AllowUserToDeleteRows = false;
                dgvObat.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                dgvObat.DataSource = ds.Tables["Test"];
            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmGolObat golObat = new frmGolObat();
            golObat.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cekharga()
        {
            if (txtHarga.Text != "0" && txtHarga.Text != "" || txtJumlah.Text !="" && txtJumlah.Text !="0")
            {
                txtHargaJual.Enabled = true;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                aktif();
                bersihtxt();
                btnBatal.Enabled = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                cekGolongan();
                btnTambah.Text = "Simpan";
                txtHarga.Text = "0";
                txtJumlah.Text = "0";
                cekharga();
            }
            else
            {
                if (kdObat.Text == "" || txtNama.Text == "" || txtGolongan.Text == "" || txtGolongan2.Text == "")
                {
                    MessageBox.Show("Data Obat Belum Lengkap! Lengkapi Terlebih Dahulu", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql, pesan;
                        sql = ("Select ID_Obat from T_Obat Where ID_Obat='" + kdObat.Text + "'");
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Maaf Data dengan Kode Tersebut Telah Ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kdObat.Focus();
                            kdObat.Clear();
                        }
                        else
                        {
                            reader.Close();
                            sql = String.Concat("Insert Into T_Obat Values ('",
                            kdObat.Text, "', '", txtGolongan.Text, "', '", txtNama.Text, "', '", txtHarga.Text, "', '", txtJumlah.Text, "', '", dateKadaluarsa.Text, "', '", txtKeterangan.Text, "', '", txtHargaJual.Text, "')");
                            cmd.Connection = conn;
                            cmd.CommandText = sql;
                            DialogResult result = MessageBox.Show("Simpan Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Disimpan");
                                MessageBox.Show(pesan, "Success");
                            }
                            else
                            {
                                distxt();
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Terjadi kesalahan karena: " + err);
                    }
                    tampilData();
                    btnTambah.Text = "Tambah";
                    btnBatal.Enabled = false;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pesan;
            if (btnEdit.Text == "Edit")
            {
                aktif();
                kdObat.Enabled = false;
                btnEdit.Text = "Update";
                btnBatal.Enabled = true;
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                cekGolongan();
                cekharga();
            }
            else
            {
                if (txtNama.Text == "" || txtGolongan.Text == "" || txtGolongan2.Text == "")
                {
                    MessageBox.Show("Data Obat Belum Lengkap! Lengkapi Terlebih Dahulu", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string sql = "UPDATE T_Obat SET ID_Obat='" + kdObat.Text + "', Kode_Golongan='" + txtGolongan.Text + "',Nama_Obat='" + txtNama.Text + "', Stok='" + txtJumlah.Text + "', Harga_Obat='" + txtHarga.Text + "', Kadaluarsa='" + dateKadaluarsa.Text + "', Keterangan = '" + txtKeterangan.Text + "', Harga_Jual='" + txtHargaJual.Text + "' WHERE ID_Obat='" + kdObat.Text + "'";
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
                            distxt();
                        }
                        conn.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Terjadi kesalahan karena: " + err);
                    }
                    tampilData();
                    btnEdit.Text = "Edit";
                    btnBatal.Enabled = false;
                    btnTambah.Enabled = true;
                    btnHapus.Enabled = true;
                }
            }
        }

        private void cekGolongan()
        {
            conn.Open();
            txtGolongan.Items.Clear();
            string sql = "Select Kode_Golongan from T_Golongan_Obat";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtGolongan.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        private void bersihtxt()
        {
            kdObat.Clear();
            txtNama.Clear();
            txtGolongan.Text = "";
            txtGolongan2.Clear();
            txtJumlah.Clear();
            dateKadaluarsa.Clear();
            txtHarga.Clear();
            txtKeterangan.Clear();
            txtHargaJual.Clear();
        }

        private void distxt()
        {
            kdObat.Enabled = false;
            txtNama.Enabled = false;
            txtGolongan.Enabled = false;
            txtKeterangan.Enabled = false;
            lblAdd.Enabled = false;
            txtHargaJual.Enabled = false;
        }

        private void aktif()
        {
            kdObat.Enabled = true;
            txtNama.Enabled = true;
            txtGolongan.Enabled = true;
            txtKeterangan.Enabled = true;
            lblAdd.Enabled = true;
        }

        private void dgvObat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string dates = this.dateKadaluarsa.Value.Date.ToString();
            distxt();
            kdObat.Text = dgvObat.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvObat.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGolongan2.Text = dgvObat.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHarga.Text = dgvObat.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtJumlah.Text = dgvObat.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateKadaluarsa.Text = dgvObat.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtKeterangan.Text = dgvObat.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtHargaJual.Text = dgvObat.Rows[e.RowIndex].Cells[7].Value.ToString();
            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            conn.Close();
            conn.Open();
            string sql = "Select Kode_Golongan from T_Golongan_Obat where Golongan = '" + txtGolongan2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            reader.Read();
            //{
            txtGolongan.Text = (reader.GetString(0));
            //}
            reader.Close();
            conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string pesan;
            try
            {
                string sql = "DELETE FROM T_Obat WHERE ID_Obat='" + kdObat.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                DialogResult result = MessageBox.Show("Yakin Hapus Data Ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    pesan = String.Concat(cmd.ExecuteNonQuery(), " Data Berhasil Dihapus");
                    MessageBox.Show(pesan, "Success");
                }
                else
                {
                    btnTambah.Focus();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan karena: " + err);
            }
            conn.Close();
            tampilData();
        }

        private void txtGolongan_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sql = "Select Golongan from T_Golongan_Obat where Kode_Golongan = '" + txtGolongan.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtGolongan2.Text = (reader.GetString(0));
            }
            conn.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihtxt();
            distxt();
            btnTambah.Text = "Tambah";
            btnTambah.Enabled = true;
            btnBatal.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        //    if(kdObat.Text=="")
        //    MessageBox.Show("Kode Obat Belum di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    else if (txtNama.Text == "")
        //    MessageBox.Show("Nama Obat Belum di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    else if (txtGolongan.Text == "")
        //    MessageBox.Show("Kode Golongan Obat Belum di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    else if (txtJumlah.Text == "")
        //    MessageBox.Show("Jumlah Obat Belum di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    else if (txtHarga.Text == "")
        //    MessageBox.Show("Harga Jual Obat Belum di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        private void lblAdd_Click(object sender, EventArgs e)
        {
            frmGolObat golobat = new frmGolObat();
            golobat.Show();
        }
    }
}
