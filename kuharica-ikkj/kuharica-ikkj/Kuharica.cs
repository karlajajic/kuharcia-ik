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
    public partial class Kuharica : Form
    {
        public Kuharica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recept_unos openForm1 = new Recept_unos();
            openForm1.Show();
            Visible = false;
        }
    }
}
