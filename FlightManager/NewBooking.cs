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
        public NewBooking()
        {
            InitializeComponent();
            checkBoxStudent.CheckedChanged += myEventHandler;
            checkBoxBusiness.CheckedChanged += myEventHandler;
            checkBoxEntertainment.CheckedChanged += myEventHandler;
            checkBoxLunch.CheckedChanged += myEventHandler;
            buttonAddLuggage.Click += myEventHandler;
            buttonRemoveLuggage.Click += myEventHandler;
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
                        "(BookingNo, FlightNo, PassengerName, PassengerSurname, PassportNo, Luggage, Business, Student, InFlightEntertainment, LunchMenu)" +
                        " VALUES (" + ID + ",'" + Flights.flightnumber + "', '" + textBoxName.Text + "', '" + textBoxSurname.Text +
                        "', '" + textBoxPassport.Text + "', " + luggage + ", " + checkBoxBusiness.Checked + ", "
                        + checkBoxStudent.Checked + ", " + checkBoxEntertainment.Checked + ", " + checkBoxLunch.Checked + ")", con))
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
                        ", LunchMenu=" + checkBoxLunch.Checked + " WHERE BookingNo=" + ID , con))
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

                if(this.Owner is Flights)
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

                    using (OleDbCommand cmd = new OleDbCommand("SELECT Departure, Destination, StandardPrice, BusinessClassPrice FROM Flights WHERE FlightNo='" + Flights.flightnumber +"'", con))
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
                else if(this.Owner is Bookings)
                {
                    buttonBook.Text = "Confirm";
                    using (OleDbCommand cmd = new OleDbCommand("SELECT BookingNo, FlightNo, PassengerName, PassengerSurname, PassportNo, Luggage, Business," +
                    " Student, InFlightEntertainment, LunchMenu FROM Bookings WHERE BookingNo=" + Bookings.bookNo, con))
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


                        }
                    }

                    using (OleDbCommand cmd = new OleDbCommand("SELECT Departure, Destination, Standard Price, Business Class Price FROM Flights WHERE FlightNo= '" + flightNo + "'" , con))
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
                    labelPrice.Text = price_standard.ToString();

                }
                
            }
       

        }

        private void myEventHandler(object sender, EventArgs e)
        {
            if (checkBoxBusiness.Checked)
            {
                labelPrice.Text = calculatePrice(price_business).ToString();
            }
            else
            {
                labelPrice.Text = calculatePrice(price_standard).ToString();
            }
        }

        private double calculatePrice(double price)
        {
            price += luggage * 20;

            if (checkBoxEntertainment.Checked)
            {
                price += 10;
            }
            else
            {
                price -= 10;
            }

            if (checkBoxLunch.Checked)
            {
                price += 15;
            }
            else
            {
                price -= 15;
            }

            if (checkBoxStudent.Checked)
            {
                price = price - price * 0.2;
            }
            else
            {
                price = price / 0.8;
            }

            return price;
        }

        private void buttonAddLuggage_Click(object sender, EventArgs e)
        {
            if (luggage < 3)
            {
                luggage++;
                labelLuggage.Text = luggage.ToString();
            }
        }

        private void buttonRemoveLuggage_Click(object sender, EventArgs e)
        {
            if (luggage > 0)
            {
                luggage--;
                labelLuggage.Text = luggage.ToString();
            }
        }
    }
}
