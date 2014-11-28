using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siapotik
{
    public partial class frmObat : Form
    {
        public frmObat()
        {
            InitializeComponent();
        }

        private void frmObat_Load(object sender, EventArgs e)
        {

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
    }
}
