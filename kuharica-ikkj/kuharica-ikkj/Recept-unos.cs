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

        private void tbNazivRecepta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnosNovogRecepta_Click(object sender, EventArgs e)
        {

            string name = tbNazivRecepta.Text;
            string ingrediant = tbSastojci.Text;
            string preptime = tbPriprema.Text;
            string preparation = tbPPriprema.Text;
            string course= "";

            if (rbPredjelo.Checked) course = "p";
            if (rbGlavnoJelo.Checked) course = "g";
            if (rbDesert.Checked) course = "d";

            Recept r = new Recept(name, ingrediant, preptime, preparation);

            if (r.UnosR(name, ingrediant, preptime, preparation))
            {
                if (rbPredjelo.Checked || rbGlavnoJelo.Checked || rbDesert.Checked)
                    MessageBox.Show("Recept je unesen!");
                else MessageBox.Show("Odaberite tip jela!");
            }
        }
    }
}
