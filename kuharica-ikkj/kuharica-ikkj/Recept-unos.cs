using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuharica_ikkj
{
    public partial class Recept_unos : Form
    {
        public Recept_unos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGlavniIzbornik_Click(object sender, EventArgs e)
        {
            Kuharica openForm = new Kuharica();
            openForm.Show();
            Visible = false;
        }

        private void rbGlavnoJelo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
