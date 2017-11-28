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
    public partial class Coolinarka : Form
    {
        public Coolinarka()
        {
            InitializeComponent();
        }

        Login login = new Login("admin", "1234");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbKIme.Text;
            string pass = tbLozinka.Text;

            if (login.LoggedIn(user, pass))
            {
                Kuharica openForm = new Kuharica();
                openForm.Show();
                Visible = false;
            }
        }

        private void linkLRegistrirajSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("U razvoju");
        }

        private void linkLZaboravljeno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("U razvoju");
        }
    }
}
