using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuharica_finalno
{
    public partial class Detalji : Form
    {
        public Detalji(string name, string ptime, string preparation, string course, string ingrediant, string image)
        {
            InitializeComponent();

            tbName.Text = name;
            tbPtime.Text = ptime;
            tbCourse.Text = course;
            tbIngrediant.Text = ingrediant;
            tbPreparation.Text = preparation;

            if (image == "kajgana") PBDetaljnije.Image = Properties.Resources.kajgana;
            else if (image == "francuska") PBDetaljnije.Image = Properties.Resources.francuska;
            else if (image == "piletina") PBDetaljnije.Image = Properties.Resources.Piletina;
            else if (image == "makaroni") PBDetaljnije.Image = Properties.Resources.makaroni;
            else if (image == "rafaelo_kuglice") PBDetaljnije.Image = Properties.Resources.rafaelo_kuglice;
            else  PBDetaljnije.Image = Properties.Resources.krem_juha;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPovratak_Click_1(object sender, EventArgs e)
        {
            Kuharica kuharica = new Kuharica();
            kuharica.Show();
            Visible = false;
        }
    }
}
