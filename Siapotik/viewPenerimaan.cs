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
    public partial class viewPenerimaan : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        public viewPenerimaan()
        {
            InitializeComponent();
        }

        private void viewPenerimaan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            search();
        }

        private void search()
        {
            da = new SqlDataAdapter(
                "Select T_DetailPenerimaan.Kode_Faktur, Nama, Nama_Obat, Jumlah, Tanggal from T_Penerimaan  JOIN T_DetailPenerimaan ON T_Penerimaan.Kode_Faktur = T_DetailPenerimaan.Kode_Faktur JOIN T_Supplier ON T_Penerimaan.ID_Supplier = T_Supplier.ID_Supplier JOIN T_Obat ON T_DetailPenerimaan.ID_Obat = T_Obat.ID_Obat", conn);
            dt = new DataTable();
            dv = new DataView();
            dt.Clear();
            da.Fill(dt);
            dv = dt.DefaultView;
            dgvPenerimaan.DataSource = dv;
            dgvPenerimaan.ReadOnly = true;
            dgvPenerimaan.Columns[1].Width = 220;
            dgvPenerimaan.Columns[2].Width = 200;
            dgvPenerimaan.Columns[4].Width = 130;
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtPilih.Text == "Kode Faktur")
            {
                dv.RowFilter = "Kode_Faktur like '%" + txtID.Text + "%'";
            }
            else if (txtPilih.Text == "Nama Obat")
            {
                dv.RowFilter = "Nama_Obat like '%" + txtID.Text + "%'";
            }
        }
    }
}
