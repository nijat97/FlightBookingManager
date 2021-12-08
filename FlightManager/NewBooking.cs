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
        private string flightNo = "";
        private int luggage = 0;
        private string depart = "";
        private string dest = "";
        private int price_standard = 0;
        private int price_business = 0;
        private int additional_price = 0;
        private int final_cost = 0;
        public NewBooking()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxPassport.Text == "")
            {
                MessageBox.Show("One or more required fields are empty. Please, fill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataTable dtBookings = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                if (this.Owner is Flights)
                {
                    using (OleDbCommand cmd = new OleDbCommand(
                        "INSERT INTO Bookings " +
                        "(BookingNo, FlightNo, PassengerName, PassengerSurname, PassportNo, Luggage, Business, Student, InFlightEntertainment, LunchMenu, Cost)" +
                        " VALUES (" + ID + ",'" + Flights.flightnumber + "', '" + textBoxName.Text + "', '" + textBoxSurname.Text +
                        "', '" + textBoxPassport.Text + "', " + luggage + ", " + checkBoxBusiness.Checked + ", "
                        + checkBoxStudent.Checked + ", " + checkBoxEntertainment.Checked + ", " + checkBoxLunch.Checked + ", " + final_cost + ")", con))
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }

                    using (OleDbCommand cmd = new OleDbCommand(
                        "UPDATE Flights SET AvailableSeats = AvailableSeats - 1 WHERE FlightNo='" + flightNo + "'", con))
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                else if (this.Owner is Bookings)
                {
                    using (OleDbCommand cmd = new OleDbCommand(
                        "UPDATE Bookings SET" +
                        " PassengerName='" + textBoxName.Text + "', PassengerSurname='" + textBoxSurname.Text +
                        "', PassportNo='" + textBoxPassport.Text + "', Luggage=" + luggage + ", Business=" + checkBoxBusiness.Checked +
                        ", Student=" + checkBoxStudent.Checked + ", InFlightEntertainment=" + checkBoxEntertainment.Checked +
                        ", LunchMenu=" + checkBoxLunch.Checked + ", Cost= " + final_cost + " WHERE BookingNo=" + ID , con))
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
            }
            this.Close();
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();

                if (this.Owner is Flights)
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT Max(BookingNo) FROM Bookings", con))
                    {

                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                        {
                            ID = reader.GetInt32(0);
                            ID++;
                        }

                    }

                    using (OleDbCommand cmd = new OleDbCommand("SELECT Departure, Destination, StandardPrice, BusinessClassPrice FROM Flights WHERE FlightNo='" + Flights.flightnumber + "'", con))
                    {

                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            flightNo = Flights.flightnumber;
                            depart = reader.GetString(0);
                            dest = reader.GetString(1);
                            price_standard = reader.GetInt32(2);
                            price_business = reader.GetInt32(3);
                        }

                    }

                    labelInfo.Text = "BookingNo: " + ID + "   Selected flight No: " + flightNo +
                    "     From: " + depart + " To: " + dest;
                    labelPrice.Text = price_standard.ToString();

                }
                else if (this.Owner is Bookings)
                {

                    buttonBook.Text = "Confirm";
                    using (OleDbCommand cmd = new OleDbCommand("SELECT BookingNo, FlightNo, PassengerName, PassengerSurname, PassportNo, Luggage, Business," +
                    " Student, InFlightEntertainment, LunchMenu, Cost FROM Bookings WHERE BookingNo=" + Bookings.bookNo, con))
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            ID = reader.GetInt32(0);
                            flightNo = reader.GetString(1);
                            textBoxName.Text = reader.GetString(2);
                            textBoxSurname.Text = reader.GetString(3);
                            textBoxPassport.Text = reader.GetString(4);

                            luggage = reader.GetInt32(5);
                            labelLuggage.Text = luggage.ToString();

                            checkBoxBusiness.Checked = reader.GetBoolean(6);
                            checkBoxStudent.Checked = reader.GetBoolean(7);
                            checkBoxEntertainment.Checked = reader.GetBoolean(8);
                            checkBoxLunch.Checked = reader.GetBoolean(9);
                            final_cost = reader.GetInt32(10);

                        }
                    }

                    using (OleDbCommand cmd = new OleDbCommand("SELECT Departure, Destination, StandardPrice, BusinessClassPrice FROM Flights WHERE FlightNo= '" + flightNo + "'", con))
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            depart = reader.GetString(0);
                            dest = reader.GetString(1);
                            price_standard = reader.GetInt32(2);
                            price_business = reader.GetInt32(3);
                        }
                    }

                    labelInfo.Text = "BookingNo: " + ID + "   Selected flight No: " + flightNo +
                    "     From: " + depart + " To: " + dest;

                    if (checkBoxBusiness.Checked) { additional_price = final_cost - price_business; } else { additional_price = final_cost - price_standard; }
                    labelPrice.Text = final_cost.ToString();

                }
                
            }
       

        }

        private void calculateAndShow()
        {
            if (checkBoxBusiness.Checked)
            {
                final_cost = price_business + additional_price;
                labelPrice.Text = final_cost.ToString();
            }
            else
            {
                final_cost = price_standard + additional_price;
                labelPrice.Text = final_cost.ToString();
            }
            
        }

        private void buttonAddLuggage_Click(object sender, EventArgs e)
        {
            if (luggage < 3)
            {
                luggage++;
                labelLuggage.Text = luggage.ToString();
                additional_price += 20;
                calculateAndShow();
            }
        }

        private void buttonRemoveLuggage_Click(object sender, EventArgs e)
        {
            if (luggage > 0)
            {
                luggage--;
                labelLuggage.Text = luggage.ToString();
                additional_price -= 20;
                calculateAndShow();
            }
        }

        private void checkBoxBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBusiness.Checked)
            {
                calculateAndShow();
            }
            else
            {
                calculateAndShow();
            }
        }

        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStudent.Checked)
            {
                additional_price -= 15;
                calculateAndShow();
            }
            else
            {
                additional_price += 15;
                calculateAndShow();
            }
        }

        private void checkBoxEntertainment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntertainment.Checked)
            {
                additional_price += 10;
                calculateAndShow();
            }
            else
            {
                additional_price -= 10;
                calculateAndShow();
            }
        }

        private void checkBoxLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLunch.Checked)
            {
                additional_price += 5;
                calculateAndShow();
            }
            else
            {
                additional_price -= 5;
                calculateAndShow();
            }
        }
    }
}
