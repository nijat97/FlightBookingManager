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
    public partial class Flights : Form
    {
        public Flights()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Flights where FlightNo like '" + textBoxSearchByFlightNo.Text + "%'", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
              
            }
        }

        private void textBoxSearchByDeparture_TextChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Flights where Departure like '" + textBoxSearchByDeparture.Text + "%'", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

            }
        }

        private void textBoxSearchByDestination_TextChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Flights where Destination like '" + textBoxSearchByDestination.Text + "%'", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

            }
        }
    } 
}
