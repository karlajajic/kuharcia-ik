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

namespace Pokusaj_databasea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnUnos_Click(object sender, EventArgs e)
        {

        }

        private void probajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.probajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pokusajDataSet1);

        }

        private void probajBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.probajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pokusajDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokusajDataSet1.Probaj' table. You can move, or remove it, as needed.
            this.probajTableAdapter.Fill(this.pokusajDataSet1.Probaj);

        }
    }
}
