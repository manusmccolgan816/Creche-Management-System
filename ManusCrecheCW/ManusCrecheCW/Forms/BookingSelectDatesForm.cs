using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManusCrecheCW.DBAccess;
using ManusCrecheCW.Forms;
using ManusCrecheCW.Objects;

namespace ManusCrecheCW.Forms
{
    public partial class BookingSelectDatesForm : Form
    {
        Database db;
        Kid selectedChild;
        BookingDBAccess bookingDBA;
        BookedOutDBAccess bookedOutDBA;
        List<List<string>> allBookingsAndDates = new List<List<string>>();
        List<string> currentBookingDates = new List<string>();
        List<string> bookedOutCurrentBookingDates = new List<string>();
        List<string> bookedDates = new List<string>();
        List<int> bookedDatesNumberOfTimesBooked = new List<int>();
        List<string> bookedOutDates = new List<string>();
        string startDate;
        string endDate;
        int groupID;
        bool startDateSelected = false;
        bool endDateSelected = false;
        bool monChecked = false;
        bool tueChecked = false;
        bool wedChecked = false;
        bool thursChecked = false;
        bool friChecked = false;
        int bookingDuration;
        int daysBooked;
        double totalCost;

        public BookingSelectDatesForm(Database Db, Parent SelectedParent, Kid SelectedChild)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            selectedChild = SelectedChild;
            bookingDBA = new BookingDBAccess(db);
            bookedOutDBA = new BookedOutDBAccess(db);

            lblBookingDuration.Text = "0";
            lblDaysBooked.Text = "0";
            lblTotalCost.Text = "£0";
            calStartDate.MinDate = DateTime.Now;
            calEndDate.MinDate = DateTime.Now.AddMonths(1);
            groupID = GetGroupID();
            lblChildName.Text = selectedChild.Forename.Trim() + " " + selectedChild.Surname.Trim();
            lblChildGroupID.Text = groupID.ToString();
            IdentifyBookedOutDates();
        }

        #region Control interaction
        #region Buttons
        #region User feedback
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnContinue_MouseEnter(object sender, EventArgs e)
        {
            btnCheckout.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnCheckout.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Clicks
        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult homeConfirmation = MessageBox.Show("Are you sure you want to return to the menu screen? All details will be lost.", "Return to menu", MessageBoxButtons.YesNo);

            if (homeConfirmation == DialogResult.Yes)
            {
                this.Hide();
                Form FormObject = new CrecheMenuScreen(db);
                FormObject.Show();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(CheckoutValidation())
            {
                DialogResult checkoutConfirmation = MessageBox.Show("Are you sure you want to make this booking and return to the Crèche menu screen?", "Make booking", MessageBoxButtons.YesNo);

                lblErrorMessage.Visible = false;

                if (checkoutConfirmation == DialogResult.Yes)
                {
                    Booking newBooking = new Objects.Booking();
                    BookedOut newBookedOut = new Objects.BookedOut();

                    newBooking.ID = GetBookingID();
                    newBooking.KidID = selectedChild.ID;
                    newBooking.GroupID = groupID;
                    newBooking.StartDate = calStartDate.SelectionStart.Date.ToString("dd-MM-yyyy");
                    newBooking.EndDate = calEndDate.SelectionStart.Date.ToString("dd-MM-yyyy");
                    #region Days assignment
                    if (monChecked)
                    {
                        newBooking.Mon = true;
                    }
                    else
                    {
                        newBooking.Mon = false;
                    }

                    if (tueChecked)
                    {
                        newBooking.Tue = true;
                    }
                    else
                    {
                        newBooking.Tue = false;
                    }

                    if (wedChecked)
                    {
                        newBooking.Wed = true;
                    }
                    else
                    {
                        newBooking.Wed = false;
                    }

                    if (thursChecked)
                    {
                        newBooking.Thurs = true;
                    }
                    else
                    {
                        newBooking.Thurs = false;
                    }

                    if (friChecked)
                    {
                        newBooking.Fri = true;
                    }
                    else
                    {
                        newBooking.Fri = false;
                    }
                    #endregion
                    newBooking.Deleted = false;
                    bookingDBA.addBooking(newBooking);

                    for (int i = 0; i < bookedOutCurrentBookingDates.Count; i++)
                    {
                        newBookedOut.ID = GetBookedOutID();
                        newBookedOut.BookingID = newBooking.ID;
                        newBookedOut.Date = bookedOutCurrentBookingDates[i];

                        bookedOutDBA.addBookedOut(newBookedOut);
                    }

                    this.Hide();
                    Form FormObject = new CrecheMenuScreen(db);
                    FormObject.Show();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult resetConfirmation = MessageBox.Show("Are you sure you want to reset all data entered on this form?", "Reset data", MessageBoxButtons.YesNo);

            if (resetConfirmation == DialogResult.Yes)
            {
                calStartDate.SetDate(DateTime.Now);
                calEndDate.SetDate(DateTime.Now.AddMonths(1));
                chkMonday.Checked = false;
                chkTuesday.Checked = false;
                chkWednesday.Checked = false;
                chkThursday.Checked = false;
                chkFriday.Checked = false;
                lblBookingDuration.Text = "0";
                lblDaysBooked.Text = "0";
                lblTotalCost.Text = "£0";
                lstSelectedBookedOutDates.Items.Clear();

                bookingDuration = 0;
                daysBooked = 0;
                totalCost = 0;
            }
        }
        #endregion
        #endregion

        #region Menu strip
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("User Guide.docx");
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void afterSchoolClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void adviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new BookingSelectChildForm(db);
            FormObject.Show();
        }

        private void parentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AddParent(db);
            FormObject.Show();
        }

        private void childToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AddChild(db);
            FormObject.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality has not been added due to the fact that the same skills were shown elsewhere");
        }

        private void bookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteBooking(db);
            FormObject.Show();
        }

        private void parentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteParent(db);
            FormObject.Show();
        }

        private void childToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteChild(db);
            FormObject.Show();
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality has not been added due to the fact that the same skills were shown elsewhere");
        }

        private void assignStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AssignStaffForm(db);
            FormObject.Show();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new ViewDataForm(db);
            FormObject.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new ReportForm(db);
            FormObject.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeProgramConfirmation = MessageBox.Show("Are you sure you want to close the program?", "Close program", MessageBoxButtons.YesNo);

            if (closeProgramConfirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Other
        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            calEndDate.MinDate = calStartDate.SelectionStart.AddMonths(1);
            startDateSelected = true;
            startDate = calStartDate.SelectionStart.ToString("dd-MM-yyyy");

            if(endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
            else if (endDateSelected)
            {
                CalculateDurationAndNoDaysSelected();
            }
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            endDateSelected = true;
            endDate = calEndDate.SelectionStart.ToString("dd-MM-yyyy");

            if (startDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
            else if (startDateSelected)
            {
                CalculateDurationAndNoDaysSelected();
            }
        }

        private void chkMonday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonday.Checked == true)
            {
                monChecked = true;
                chkMonday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                monChecked = false;
                chkMonday.ForeColor = System.Drawing.Color.Yellow;

                if (!DaySelected())
                {
                    totalCost = 0;
                    lblTotalCost.Text = "£0";
                    daysBooked = 0;
                    lblDaysBooked.Text = "0";
                    currentBookingDates.Clear();
                    bookedOutCurrentBookingDates.Clear();
                    lstSelectedBookedOutDates.Items.Clear();
                }
            }

            if (startDateSelected && endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
        }

        private void chkTuesday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTuesday.Checked == true)
            {
                tueChecked = true;
                chkTuesday.ForeColor = System.Drawing.Color.HotPink;

            }
            else
            {
                tueChecked = false;
                chkTuesday.ForeColor = System.Drawing.Color.Yellow;

                if (!DaySelected())
                {
                    totalCost = 0;
                    lblTotalCost.Text = "£0";
                    daysBooked = 0;
                    lblDaysBooked.Text = "0";
                    currentBookingDates.Clear();
                    bookedOutCurrentBookingDates.Clear();
                    lstSelectedBookedOutDates.Items.Clear();
                }
            }

            if (startDateSelected && endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
        }

        private void chkWednesday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWednesday.Checked == true)
            {
                wedChecked = true;
                chkWednesday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                wedChecked = false;
                chkWednesday.ForeColor = System.Drawing.Color.Yellow;

                if (!DaySelected())
                {
                    totalCost = 0;
                    lblTotalCost.Text = "£0";
                    daysBooked = 0;
                    lblDaysBooked.Text = "0";
                    currentBookingDates.Clear();
                    bookedOutCurrentBookingDates.Clear();
                    lstSelectedBookedOutDates.Items.Clear();
                }
            }

            if (startDateSelected && endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
        }

        private void chkThursday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThursday.Checked == true)
            {
                thursChecked = true;
                chkThursday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                thursChecked = false;
                chkThursday.ForeColor = System.Drawing.Color.Yellow;

                if (!DaySelected())
                {
                    totalCost = 0;
                    lblTotalCost.Text = "£0";
                    daysBooked = 0;
                    lblDaysBooked.Text = "0";
                    currentBookingDates.Clear();
                    bookedOutCurrentBookingDates.Clear();
                    lstSelectedBookedOutDates.Items.Clear();
                }
            }

            if (startDateSelected && endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
        }

        private void chkFriday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFriday.Checked == true)
            {
                friChecked = true;
                chkFriday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                friChecked = false;
                chkFriday.ForeColor = System.Drawing.Color.Yellow;

                if (!DaySelected())
                {
                    totalCost = 0;
                    lblTotalCost.Text = "£0";
                    daysBooked = 0;
                    lblDaysBooked.Text = "0";
                    currentBookingDates.Clear();
                    bookedOutCurrentBookingDates.Clear();
                    lstSelectedBookedOutDates.Items.Clear();
                }
            }

            if (startDateSelected && endDateSelected && DaySelected())
            {
                CalculateDurationAndNoDaysSelected();
                CalculateCost();
            }
        }
        #endregion
        #endregion

        public void IdentifyBookedOutDates()
        {
            int counter = 0;
            int bookingCount = 0;
            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            int datesInListCounter = 0;
            bool flag = false;
            DateTime dateCount;
            string latestBookedOutDate = "";

            #region Adding all previous selected dates to list
            foreach (Booking booking in bookings)
            {
                if(booking.Deleted == false)
                {
                    if (booking.GroupID == groupID && Convert.ToDateTime(booking.EndDate) > DateTime.Now) //If the GroupID is the same as that of the current booking and the booking hasn't already finished
                    {
                        flag = false;
                        dateCount = Convert.ToDateTime(booking.StartDate).Date;
                        string[] datesOfSelectedBooking;

                        while (flag == false)
                        {
                            if (dateCount == Convert.ToDateTime(booking.EndDate).Date) //If every date has been checked
                            {
                                flag = true;
                            }
                            counter++;
                            dateCount = dateCount.AddDays(1);
                        }

                        flag = false;
                        dateCount = Convert.ToDateTime(booking.StartDate).Date;
                        datesOfSelectedBooking = new string[counter];
                        counter = 0;

                        while (flag == false)
                        {
                            if (dateCount.DayOfWeek == DayOfWeek.Monday && booking.Mon == true)
                            {
                                datesOfSelectedBooking[counter] = dateCount.ToString();
                            }
                            else if (dateCount.DayOfWeek == DayOfWeek.Tuesday && booking.Tue == true)
                            {
                                datesOfSelectedBooking[counter] = dateCount.ToString();
                            }
                            else if (dateCount.DayOfWeek == DayOfWeek.Wednesday && booking.Wed == true)
                            {
                                datesOfSelectedBooking[counter] = dateCount.ToString();
                            }
                            else if (dateCount.DayOfWeek == DayOfWeek.Thursday && booking.Thurs == true)
                            {
                                datesOfSelectedBooking[counter] = dateCount.ToString();
                            }
                            else if (dateCount.DayOfWeek == DayOfWeek.Friday && booking.Fri == true)
                            {
                                datesOfSelectedBooking[counter] = dateCount.ToString();
                            }

                            if (dateCount == Convert.ToDateTime(booking.EndDate).Date) //If every date has been checked
                            {
                                flag = true;
                            }
                            counter++;
                            dateCount = dateCount.AddDays(1);
                        }

                        flag = false;

                        for (int i = 0; i < datesOfSelectedBooking.Length; i++)
                        {
                            if (flag == false && datesOfSelectedBooking[i] != null) //This if statement should only be entered once
                            {
                                allBookingsAndDates.Add(new List<string> { datesOfSelectedBooking[i] });
                                datesInListCounter++;
                                flag = true;
                            }
                            else if (datesOfSelectedBooking[i] != null)
                            {
                                allBookingsAndDates[bookingCount].Add(datesOfSelectedBooking[i]);
                                datesInListCounter++;
                            }
                        }
                        counter = 0;
                        bookingCount++;
                    }
                }
            }
            #endregion

            foreach (List<string> list in allBookingsAndDates)
            {
                foreach(string stringo in list)
                {
                    if(!bookedDates.Contains(stringo))
                    {
                        bookedDates.Add(stringo);
                        bookedDatesNumberOfTimesBooked.Add(0);

                        foreach (List<string> list2 in allBookingsAndDates)
                        {
                            foreach (string stringo2 in list2)
                            {
                                if (stringo2 == stringo)
                                {
                                    bookedDatesNumberOfTimesBooked[counter]++;
                                }
                            }
                        }
                        counter++;
                    }
                }
            }

            for (int i = 0; i < bookedDatesNumberOfTimesBooked.Count; i++)
            {
                if (groupID == 1)
                {
                    if (bookedDatesNumberOfTimesBooked[i] >= 6)
                    {
                        bookedOutDates.Add(bookedDates[i]);
                    }
                }
                else if (groupID == 2)
                {
                    if (bookedDatesNumberOfTimesBooked[i] >= 10)
                    {
                        bookedOutDates.Add(bookedDates[i]);
                    }
                }
                else if (groupID == 3)
                {
                    if (bookedDatesNumberOfTimesBooked[i] >= 9)
                    {
                        bookedOutDates.Add(bookedDates[i]);
                    }
                }
            }

            for (int i = 0; i < bookedOutDates.Count; i++) //Finds latest booked out date
            {
                if(i == 0)
                {
                    latestBookedOutDate = bookedOutDates[i];
                }
                else if(Convert.ToDateTime(bookedOutDates[i]) > Convert.ToDateTime(latestBookedOutDate))
                {
                    latestBookedOutDate = bookedOutDates[i];
                }
            }

            counter = 0;
            flag = false;
            dateCount = Convert.ToDateTime(DateTime.Now).Date;

            if(bookedOutDates.Count != 0)
            {
                foreach(string date in bookedOutDates)
                {
                    calStartDate.AddBoldedDate(Convert.ToDateTime(date));
                    calEndDate.AddBoldedDate(Convert.ToDateTime(date));
                }
            }
        }

        public int GetGroupID()
        {
            DateTime dateCount = Convert.ToDateTime(selectedChild.DateOfBirth);
            int monthCounter = 0;

            while(true)
            {
                if (dateCount.Date > DateTime.Now.Date)
                {
                    monthCounter--;

                    if(monthCounter >= 6 && monthCounter < 18)
                    {
                        return 1;
                    }
                    if(monthCounter >= 18 && monthCounter < 30)
                    {
                        return 2;
                    }
                    if(monthCounter >= 30 && monthCounter <= 60) //Child may be up to 5 years of age if they were members before thet were 5
                    {
                        return 3;
                    }
                }
                dateCount = dateCount.AddMonths(1);
                monthCounter++;
            }
        }

        public int GetBookingID()
        {
            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            int greatestID = 0;

            foreach (Booking booking in bookings)
            {
                if (booking.ID > greatestID)
                {
                    greatestID = booking.ID;
                }
            }
            greatestID++;
            return greatestID;
        }

        public int GetBookedOutID()
        {
            List<BookedOut> bookedOuts = new List<BookedOut>();
            bookedOuts = bookedOutDBA.getAllBookedOuts();
            int greatestID = 0;

            foreach (BookedOut bookedOut in bookedOuts)
            {
                if (bookedOut.ID > greatestID)
                {
                    greatestID = bookedOut.ID;
                }
            }
            greatestID++;
            return greatestID;
        }

        public bool CheckoutValidation()
        {
            if (startDateSelected == false || endDateSelected == false)
            {
                lblErrorMessage.Text = "Please select a start and end date";
                lblErrorMessage.Visible = true;
                return false;
            }
            else if (DaySelected() == false)
            {
                lblErrorMessage.Text = "Please select which days you want to book";
                lblErrorMessage.Visible = true;
                return false;
            }
            else if(daysBooked == 0)
            {
                lblErrorMessage.Text = "No days have been booked";
                lblErrorMessage.Visible = true;
                return false;
            }

            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            string earliestStartDate = "01-12-3000";
            string latestEndDate = "01-01-2000";

            while (true)
            {
                foreach (Booking booking in bookings)
                {
                    if(booking.Deleted == false)
                    {
                        if (booking.KidID == selectedChild.ID)
                        {
                            if (Convert.ToDateTime(booking.StartDate) < Convert.ToDateTime(earliestStartDate))
                            {
                                earliestStartDate = booking.StartDate;
                            }
                            if (Convert.ToDateTime(booking.EndDate) > Convert.ToDateTime(latestEndDate))
                            {
                                latestEndDate = booking.EndDate;
                            }
                        }
                    }
                }
                if(calStartDate.SelectionStart >= Convert.ToDateTime(earliestStartDate) && calStartDate.SelectionStart <= Convert.ToDateTime(latestEndDate))
                {
                    lblErrorMessage.Text = "Two bookings of the same child must not overlap";
                    lblErrorMessage.Visible = true;
                    return false;
                }
                if(calEndDate.SelectionStart >= Convert.ToDateTime(earliestStartDate) && calEndDate.SelectionStart <= Convert.ToDateTime(latestEndDate))
                {
                    lblErrorMessage.Text = "Two bookings of the same child must not overlap";
                    lblErrorMessage.Visible = true;
                    return false;
                }

                return true;
            }
        }

        public bool CalculateCost()
        {
            DateTime dateCount = DateTime.Now;
            int dateCountCount = 0;

            while(true)
            {
                if(dateCount.Date >= calStartDate.SelectionStart.Date)
                {
                    if(dateCountCount < 3)
                    {
                        totalCost = daysBooked * 15;
                        lblTotalCost.Text = "£ " + totalCost.ToString();
                    }
                    else if(dateCountCount < 6)
                    {
                        totalCost = (daysBooked * 15) * 0.97;
                        lblTotalCost.Text = "£ " + totalCost.ToString() + "   *3% discount applied*";
                    }
                    else
                    {
                        totalCost = (daysBooked * 15) * 0.95;
                        lblTotalCost.Text = "£ " + totalCost.ToString() + "   *5% discount applied*";
                    }
                    return true;
                }
                dateCount = dateCount.AddMonths(1);
                dateCountCount++;
            }
        }

        public bool CalculateDurationAndNoDaysSelected()
        {
            DateTime dateCount = calStartDate.SelectionStart;
            int dateCountCount = 0;
            int dayCount = 0;
            int bookedOutDatesCounter = 0;
            bookedOutCurrentBookingDates.Clear();
            lstSelectedBookedOutDates.Items.Clear();

            while (true)
            {
                if(DaySelected())
                {
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Monday && monChecked == true)
                    {
                        if(bookedOutDates.Contains(dateCount.Date.ToString()))
                        {
                            bookedOutCurrentBookingDates.Add(dateCount.ToString().Substring(0, dateCount.ToString().Length - 9));
                            bookedOutDatesCounter++;
                        }
                        else
                        {
                            dayCount++;
                            currentBookingDates.Add(dateCount.Date.ToString());
                        }
                    }
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Tuesday && tueChecked == true)
                    {
                        if (bookedOutDates.Contains(dateCount.Date.ToString()))
                        {
                            bookedOutCurrentBookingDates.Add(dateCount.ToString().Substring(0, dateCount.ToString().Length - 9));
                            bookedOutDatesCounter++;
                        }
                        else
                        {
                            dayCount++;
                            currentBookingDates.Add(dateCount.Date.ToString());
                        }
                    }
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Wednesday && wedChecked == true)
                    {
                        if (bookedOutDates.Contains(dateCount.Date.ToString()))
                        {
                            bookedOutCurrentBookingDates.Add(dateCount.ToString().Substring(0, dateCount.ToString().Length - 9));
                            bookedOutDatesCounter++;
                        }
                        else
                        {
                            dayCount++;
                            currentBookingDates.Add(dateCount.Date.ToString());
                        }
                    }
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Thursday && thursChecked == true)
                    {
                        if (bookedOutDates.Contains(dateCount.Date.ToString()))
                        {
                            bookedOutCurrentBookingDates.Add(dateCount.ToString().Substring(0, dateCount.ToString().Length - 9));
                            bookedOutDatesCounter++;
                        }
                        else
                        {
                            dayCount++;
                            currentBookingDates.Add(dateCount.Date.ToString());
                        }
                    }
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Friday && friChecked == true)
                    {
                        if (bookedOutDates.Contains(dateCount.Date.ToString()))
                        {
                            bookedOutCurrentBookingDates.Add(dateCount.ToString().Substring(0, dateCount.ToString().Length - 9));
                            bookedOutDatesCounter++;
                        }
                        else
                        {
                            dayCount++;
                            currentBookingDates.Add(dateCount.Date.ToString());
                        }
                    }
                }

                if (dateCount.Date == calEndDate.SelectionStart.Date) //Need to use .Date so that time does not effect the comparision
                {
                    bookingDuration = dateCountCount;
                    daysBooked = dayCount;

                    lblBookingDuration.Text = bookingDuration.ToString() + " days";
                    if(bookedOutDatesCounter > 0)
                    {
                        if(bookedOutDatesCounter == 1)
                        {
                            lblDaysBooked.Text = daysBooked.ToString() + " (not including the " + bookedOutDatesCounter + " already booked out day)";
                        }
                        else
                        {
                            lblDaysBooked.Text = daysBooked.ToString() + " (not including the " + bookedOutDatesCounter + " already booked out days)";
                        }

                        for(int i = 0; i < bookedOutDatesCounter; i++)
                        {
                            lstSelectedBookedOutDates.Items.Add(bookedOutCurrentBookingDates[i]);
                        }
                    }
                    else
                    {
                        lblDaysBooked.Text = daysBooked.ToString();
                    }
                    return true;
                }
                dateCount = dateCount.AddDays(1);
                dateCountCount++;
            } 
        }

        public bool DaySelected()
        {
            if (monChecked == false && tueChecked == false && wedChecked == false && thursChecked == false && friChecked == false)
            {
                return false;
            }
            return true;
        }
    }
}