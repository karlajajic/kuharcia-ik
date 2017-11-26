using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient; //povezujemo s databaseom

namespace kuharica_ikkj
{
    public partial class Recept_unos : Form
    {

       

        public Recept_unos()
        {
            InitializeComponent();
        }

        private void btnGlavniIzbornik_Click(object sender, EventArgs e)
        {
             Kuharica openForm = new Kuharica();
             openForm.Show();
             Visible = false;
        }

        int x = 2;
        int y = 2;


        private void btnUnosNovogRecepta_Click(object sender, EventArgs e)
        {
            string name = tbNazivRecepta.Text;
            string ingrediant = tbSastojci.Text;
            string preptime = tbPriprema.Text;
            string preparation = tbPPriprema.Text;
            string course = cbTipJela.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ingrediant) || string.IsNullOrEmpty(preptime) || string.IsNullOrEmpty(preparation) || string.IsNullOrEmpty(course))
                MessageBox.Show("Unesite sve podatke!");
            else
            {
                y = x++;
                x = y;

                string connString = ConfigurationManager.ConnectionStrings["kuharica_ikkj.Properties.Settings.kuharicaConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connString)) //poveznica
                {
                    string query = "INSERT INTO Recepti (Id, Naziv, Tip, Vrijeme) VALUES ('" + x + "', '" + tbNazivRecepta.Text + "', '" + cbTipJela.Text + "', '" + tbPriprema.Text + "')";
                    using (SqlCommand cmd = new SqlCommand(query, con)) //naredba 
                    {
                       
                        con.Open();
                        //string query = "INSERT INTO Recepti (Naziv, Tip, Vrijeme pripreme) VALUES ('" + tbNazivRecepta.Text + "', '" + cbTipJela.Text + "', '" + tbPriprema.Text + "')";
                        // SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                        //SDA.SelectCommand.ExecuteNonQuery();
    
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Recept je unesen");
                       
                    }
                }
            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void rbGlavnoJelo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbNazivRecepta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
