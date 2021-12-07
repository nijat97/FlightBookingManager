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
    public partial class NewBooking : Form
    {
        private int ID = 100000;
        private int luggage = 0;

        public NewBooking()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            DataTable dtBookings = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Bookings " +
                    "(BookingNo, FlightNo, PassengerName, PassengerSurname, PassportNo, Luggage, Business, Student, InFlightEntertainment, LunchMenu)" +
                    " VALUES ("+ (ID + 1) +",'" + Flights.flightnumber + "', '" + textBoxName.Text + "', '" + textBoxSurname.Text + 
                    "', '" + textBoxPassport.Text + "', " + luggage + ", " + checkBoxBusiness.Checked + ", "
                    + checkBoxStudent.Checked + ", " +checkBoxEntertainment.Checked + ", " + checkBoxLunch.Checked + ")", con))
                {
                    con.Open();

                    ID++;

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            this.Close();
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT Max(BookingNo) FROM Bookings", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                    {
                        ID = reader.GetInt32(0);
                    }
     
                }
            } 

            textBoxName.Text = Bookings.passengerName;
            labelInfo.Text = "BookingNo: " + (ID+1) + "   Selected flight No: " + Flights.flightnumber +
                "     From: " + Flights.depart_city + " To: " + Flights.dest_city;
        }

        private void buttonAddLuggage_Click(object sender, EventArgs e)
        {
            luggage++;
            labelLuggage.Text = luggage.ToString();
        }
    }
}
