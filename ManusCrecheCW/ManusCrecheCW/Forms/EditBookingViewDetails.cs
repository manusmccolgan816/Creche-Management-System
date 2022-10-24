using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManusCrecheCW.Objects;
using ManusCrecheCW.DBAccess;

namespace ManusCrecheCW.Forms
{
    public partial class EditBookingViewDetails : Form
    {
        Database db;
        int bookingDuration;
        int daysBooked;
        double totalCost;
        int totalCostDiscount;
        List<string> bookedOutCurrentBookingDates; //Might need to do = new List<string>
        int bookedOutDatesCounter;

        public EditBookingViewDetails(Database Db, int BookingDuration, int DaysBooked, double TotalCost, int TotalCostDiscount, List<string> BookedOutCurrentBookingDates, int BookedOutDatesCounter)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            bookingDuration = BookingDuration;
            daysBooked = DaysBooked;
            totalCost = TotalCost;
            totalCostDiscount = TotalCostDiscount;
            bookedOutCurrentBookingDates = BookedOutCurrentBookingDates;
            bookedOutDatesCounter = BookedOutDatesCounter;

            DisplayData();
        }

        public void DisplayData()
        {
            lblBookingDuration.Text = bookingDuration.ToString() + " days";
            lblDaysBooked.Text = daysBooked.ToString();

            if(totalCostDiscount == 0)
            {
                lblTotalCost.Text = "£ " + totalCost.ToString();
            }
            else if(totalCostDiscount == 3)
            {
                lblTotalCost.Text = "£ " + totalCost.ToString() + " *3% discount*";
            }
            else if (totalCostDiscount == 5)
            {
                lblTotalCost.Text = "£ " + totalCost.ToString() + " *5% discount*";
            }

            for (int i = 0; i < bookedOutDatesCounter; i++)
            {
                lstSelectedBookedOutDates.Items.Add(bookedOutCurrentBookingDates[i]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.Turquoise;
        }
    }
}
