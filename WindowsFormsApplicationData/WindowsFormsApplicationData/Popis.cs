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

namespace WindowsFormsApplicationData
{
    public partial class Popis : Form
    {
        public Popis()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Data.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from tbTable", con);
            con.Open();

            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            DGWPopis.DataSource = source;
            con.Close();


        }

        private void Popis_Load(object sender, EventArgs e)
        {

        }
    }
}
