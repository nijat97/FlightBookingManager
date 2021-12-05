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
using System.Data.OleDb;

namespace FlightManager
{
    public partial class flights : Form
    {
        public flights()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetFlightsList();
        }

        private DataTable GetFlightsList()
        {
            DataTable dtFlights = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Flights", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtFlights.Load(reader);
                }
            }

                return dtFlights;
        }
    } 
}
