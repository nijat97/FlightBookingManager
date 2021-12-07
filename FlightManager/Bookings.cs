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
    public partial class Bookings : Form
    {
        public static string passengerName = "";

        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            dataGridViewBookings.DataSource = GetBookingData();
        }

        private DataTable GetBookingData()
        {
            DataTable dtBookings = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Bookings", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtBookings.Load(reader);
                }
            }

            return dtBookings;
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            Flights new_flights = new Flights();
            new_flights.ShowDialog();
            dataGridViewBookings.DataSource = GetBookingData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            NewBooking newBook = new NewBooking();

            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridViewBookings.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewBookings.Rows[selectedrowindex];
                passengerName = Convert.ToString(selectedRow.Cells["PassengerName"].Value);
            }
            newBook.ShowDialog();
            dataGridViewBookings.DataSource = GetBookingData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataTable dtBookings = new DataTable();
            
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridViewBookings.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewBookings.Rows[selectedrowindex];
                string selectedNo = Convert.ToString(selectedRow.Cells["BookingNo"].Value);


                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(
                        "DELETE FROM Bookings WHERE BookingNo =" + selectedNo , con))
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                dataGridViewBookings.DataSource = GetBookingData();
            }
            else
            {
                MessageBox.Show("No data to delete!");
            }

        }
    }
}
