using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuharicaT
{
    public partial class Detalji : Form
    {
        public Detalji( string name, string ptime, string preparation, string course, string ingrediant )
        {
            InitializeComponent();

            tbName.Text = name;
            tbPtime.Text = ptime;
            tbCourse.Text = course;
            tbIngrediant.Text = ingrediant;
            tbPreparation.Text = preparation;

        }


        private void lblNaziv_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Form1 povratak = new Form1();
            povratak.Show();
            Visible = false;
        }
    }
}
