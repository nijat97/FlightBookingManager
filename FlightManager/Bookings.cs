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
    }
}
