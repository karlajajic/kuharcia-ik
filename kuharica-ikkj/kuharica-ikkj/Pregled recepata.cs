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
using System.Data.SqlClient;

namespace kuharica_ikkj
{
    public partial class Pregled_recepata : Form
    {
        public Pregled_recepata()
        {
            InitializeComponent();
        }

        private void Pregled_recepata_Load(object sender, EventArgs e)
        {
            ReceptiDataGridView.DataSource = GetData();
        }

        private DataTable GetData ()  //sluzi kako bi dosli do podataka
        {
            DataTable dtRecepti = new DataTable(); // stvaramo tablicu koja ce biti klon one u databaseu

            string connString = ConfigurationManager.ConnectionStrings["kuharica_ikkj.Properties.Settings.kuharicaConnectionString"].ConnectionString; //adresa

            using (SqlConnection con = new SqlConnection(connString)) //poveznica
            {
                using (SqlCommand cmd = new SqlCommand(" SELECT * FROM Recepti", con)) //naredba 
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader(); //stvaramo "citaca"

                    dtRecepti.Load(reader); // "citac" prepisuje podatke u tablicu => nastaje kopija 
                }
            }

            return dtRecepti;
        }
    }
}
