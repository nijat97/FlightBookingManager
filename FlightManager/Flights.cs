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
        public static string flightnumber = "";
        public static string depart_city = "";
        public static string dest_city = "";
        public static string pass_name = "";
        public static string pass_surname = "";
        public Flights()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewFlights.DataSource = GetFlightsList();
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

        private void searchAndUpdate(string column, string textbox)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Flights where " + column + " like '" + textbox + "%'", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewFlights.DataSource = dt;

                con.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchAndUpdate("FlightNo", textBoxSearchByFlightNo.Text);
        }

        private void textBoxSearchByDeparture_TextChanged(object sender, EventArgs e)
        {
            searchAndUpdate("Departure", textBoxSearchByDeparture.Text);
        }

        private void textBoxSearchByDestination_TextChanged(object sender, EventArgs e)
        {
            searchAndUpdate("Destination", textBoxSearchByDestination.Text);
        }

        private void flightAdd_Click(object sender, EventArgs e)
        {
            NewBooking new_b = new NewBooking();

            if (dataGridViewFlights.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridViewFlights.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewFlights.Rows[selectedrowindex];
                flightnumber = Convert.ToString(selectedRow.Cells["FlightNo"].Value);
                depart_city = Convert.ToString(selectedRow.Cells["Departure"].Value);
                dest_city = Convert.ToString(selectedRow.Cells["Destination"].Value);
            }
            new_b.ShowDialog();
            this.Close();
        }
    } 
}
