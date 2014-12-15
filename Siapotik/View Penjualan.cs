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
    public partial class viewPenjualan : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        public viewPenjualan()
        {
            InitializeComponent();
        }

        private void viewPenjualan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            search();
        }

        private void search()
        {
            da = new SqlDataAdapter(
                "Select T_Penjualan.Kode_Penjualan, Nama_Obat, Jumlah, Nama_Pasien, Nama_Dokter, Tanggal from T_Penjualan  JOIN T_DetailPenjualan ON T_Penjualan.Kode_Penjualan = T_DetailPenjualan.Kode_Penjualan JOIN T_Pasien ON T_Penjualan.ID_Pasien = T_Pasien.ID_Pasien JOIN T_Obat ON T_DetailPenjualan.ID_Obat = T_Obat.ID_Obat JOIN T_Dokter ON T_Penjualan.ID_Dokter = T_Dokter.ID_Dokter", conn);
            dt = new DataTable();
            dv = new DataView();
            dt.Clear();
            da.Fill(dt);
            dv = dt.DefaultView;
            dgvPenjualan.DataSource = dv;
            dgvPenjualan.ReadOnly = true;
            dgvPenjualan.Columns[1].Width = 220;
            dgvPenjualan.Columns[3].Width = 250;
            dgvPenjualan.Columns[4].Width = 250;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtPilih.Text == "Kode Penjualan")
            {
                dv.RowFilter = "Kode_Penjualan like '%" + txtID.Text + "%'";
            }
            else if (txtPilih.Text == "Nama Obat")
            {
                dv.RowFilter = "Nama_Obat like '%" + txtID.Text + "%'";
            }
            else if (txtPilih.Text == "Nama Pasien")
            {
                dv.RowFilter = "Nama_Pasien like '%" + txtID.Text + "%'";
            }
            else if (txtPilih.Text == "Nama Dokter")
            {
                dv.RowFilter = "Nama_Dokter like '%" + txtID.Text + "%'";
            }
            else if (txtPilih.Text == "Tanggal")
            {
                dv.RowFilter = "Tanggal like '%" + txtID.Text + "%'";
            }
        }
    }
}
