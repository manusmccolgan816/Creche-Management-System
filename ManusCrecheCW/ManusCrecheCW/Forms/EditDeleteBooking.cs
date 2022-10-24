using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManusCrecheCW.Forms;
using ManusCrecheCW.Objects;
using ManusCrecheCW.DBAccess;


namespace ManusCrecheCW.Forms
{
    public partial class EditDeleteBooking : Form
    {
        Database db;
        KidDBAccess kidDBA;
        BookingDBAccess bookingDBA;
        BookedOutDBAccess bookedOutDBA;
        Booking selectedBooking = new Objects.Booking();
        List<Booking> bookings = new List<Booking>();
        List<List<string>> allBookingsAndDates = new List<List<string>>();
        List<List<string>> childValuesList = new List<List<string>>();
        List<string> bookingValuesList = new List<string>();
        List<string> bookedOutCurrentBookingDates = new List<string>();
        List<string> bookedDates = new List<string>();
        List<int> bookedDatesNumberOfTimesBooked = new List<int>();
        List<string> bookedOutDates = new List<string>();
        List<string> currentBookingDates = new List<string>();
        bool bookingInPast;
        string startDate;
        string endDate;
        int selectedChildID;
        string selectedChildForename;
        string selectedChildSurname;
        string selectedChildDOB;
        int bookedOutDatesCounter;
        int bookingDuration;
        int daysBooked;
        double totalCost;
        int totalCostDiscount;
        List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public EditDeleteBooking(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();

            db = Db;
            kidDBA = new KidDBAccess(db);
            bookingDBA = new BookingDBAccess(db);
            bookedOutDBA = new BookedOutDBAccess(db);
            calStartDate.MinDate = DateTime.Now.Date;
            calEndDate.MinDate = DateTime.Now.Date.AddMonths(1);
            btnSaveChanges.Enabled = false;
            btnDeleteBooking.Enabled = false;
            btnViewDetails.Enabled = false;
            calStartDate.Enabled = false;
            calEndDate.Enabled = false;
            chkMonday.Enabled = false;
            chkTuesday.Enabled = false;
            chkWednesday.Enabled = false;
            chkThursday.Enabled = false;
            chkFriday.Enabled = false;
            lblNotEditable.Visible = false;
            lblEditErrorMessage.Visible = false;

            PopulateListBox();
        }

        #region Control interaction
        #region Buttons
        #region User feedback
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnViewDetails_MouseEnter(object sender, EventArgs e)
        {
            btnViewDetails.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnViewDetails_MouseLeave(object sender, EventArgs e)
        {
            btnViewDetails.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnSaveChanges_MouseEnter(object sender, EventArgs e)
        {
            btnSaveChanges.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            btnSaveChanges.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnDeleteBooking_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteBooking.ForeColor = System.Drawing.Color.White;
        }

        private void btnDeleteBooking_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteBooking.ForeColor = System.Drawing.Color.Black;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            CalculateDurationAndNoDaysSelected();
            CalculateCost();

            Form FormObject = new EditBookingViewDetails(db, bookingDuration, daysBooked, totalCost, totalCostDiscount, bookedOutCurrentBookingDates, bookedOutDatesCounter);
            FormObject.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(DaySelected())
            {
                bool flag;
                BookedOut newBookedOut = new Objects.BookedOut();
                List<BookedOut> bookedOuts = new List<BookedOut>();
                bookedOuts = bookedOutDBA.getAllBookedOuts();
                lblEditErrorMessage.Visible = false;

                selectedBooking.StartDate = calStartDate.SelectionStart.ToString("dd-MM-yyyy");
                selectedBooking.EndDate = calEndDate.SelectionStart.ToString("dd-MM-yyyy");
                #region Days assignment
                if (chkMonday.Checked)
                {
                    selectedBooking.Mon = true;
                }
                else
                {
                    selectedBooking.Mon = false;
                }

                if (chkTuesday.Checked)
                {
                    selectedBooking.Tue = true;
                }
                else
                {
                    selectedBooking.Tue = false;
                }

                if (chkWednesday.Checked)
                {
                    selectedBooking.Wed = true;
                }
                else
                {
                    selectedBooking.Wed = false;
                }

                if (chkThursday.Checked)
                {
                    selectedBooking.Thurs = true;
                }
                else
                {
                    selectedBooking.Thurs = false;
                }

                if (chkFriday.Checked)
                {
                    selectedBooking.Fri = true;
                }
                else
                {
                    selectedBooking.Fri = false;
                }
                #endregion

                bookingDBA.updateBooking(selectedBooking);

                for (int i = 0; i < bookedOutCurrentBookingDates.Count; i++)
                {
                    flag = false;
                    foreach(BookedOut bookedOut in bookedOuts)
                    {
                        if(bookedOutCurrentBookingDates[i] == bookedOut.Date && selectedBooking.ID == bookedOut.ID)
                        {
                            flag = true;
                        }
                    }
                    if(flag == false)
                    {
                        newBookedOut.ID = GetBookedOutID();
                        newBookedOut.BookingID = selectedBooking.ID;
                        newBookedOut.Date = bookedOutCurrentBookingDates[i];

                        bookedOutDBA.addBookedOut(newBookedOut);
                    }
                }

                MessageBox.Show("Data updated");
            }
            else
            {
                lblEditErrorMessage.Visible = true;
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete this booking?", "Delete", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                selectedBooking.Deleted = true;

                bookingDBA.updateBooking(selectedBooking);

                calStartDate.MinDate = DateTime.Now.Date;
                calEndDate.MinDate = DateTime.Now.AddMonths(1);
                calStartDate.SelectionStart = DateTime.Now;
                calEndDate.SelectionStart = DateTime.Now.AddMonths(1);
                chkMonday.Checked = false;
                chkTuesday.Checked = false;
                chkWednesday.Checked = false;
                chkThursday.Checked = false;
                chkFriday.Checked = false;
                lblBookingID.Text = "";
                lblChildName.Text = "";
                lblGroupID.Text = "";
                lstChildName.Items.Clear();
                cmbBookingDates.Items.Clear();
                txtChildName.Text = "";
                lblNotEditable.Visible = false;
                lblEditErrorMessage.Visible = false;

                btnSaveChanges.Enabled = false;
                btnDeleteBooking.Enabled = false;
                btnViewDetails.Enabled = false;
                calStartDate.Enabled = false;
                calEndDate.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                lblNotEditable.Visible = false;
                lblEditErrorMessage.Visible = false;

                lstChildName.Items.Clear();
                PopulateListBox();
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
        private void txtChildName_TextChanged(object sender, EventArgs e)
        {
            List<Kid> allKids = kidDBA.getAllKids();
            List<Kid> updateKids = new List<Kid>();
            lstChildName.Items.Clear();
            cmbBookingDates.Items.Clear();

            bool letterInput = false;

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (txtChildName.Text.ToLower().Contains(alphabet[i]))
                {
                    letterInput = true;
                }
            }

            if (letterInput == true)
            {
                foreach (Kid kid in allKids)
                {
                    if(kid.Deleted == false)
                    {
                        if ((kid.Forename.ToUpper().Trim() + " " + kid.Surname.ToUpper().Trim()).Contains(txtChildName.Text.ToUpper().Trim()))
                        {
                            updateKids.Add(kid);
                            childValuesList.Add(new List<string> { kid.ID.ToString(), kid.Forename, kid.Surname, kid.DateOfBirth });
                        }
                    }
                }

                foreach (Kid kid in updateKids)
                {
                    if(kid.Deleted == false)
                    {
                        lstChildName.Items.Add(kid.Forename.Trim() + " " + kid.Surname.Trim());
                    }                  
                }
            }

            if (txtChildName.Text == "")
            {
                lstChildName.Items.Clear();
                PopulateListBox();
            }
        }

        private void lstChildName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int childValueCount = 0;
            bool childFound = false;

            calStartDate.SelectionStart = DateTime.Now.Date;
            calEndDate.SelectionStart = DateTime.Now.Date.AddMonths(1);
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;

            calStartDate.MinDate = DateTime.Now.Date;
            calEndDate.MinDate = DateTime.Now.Date.AddMonths(1);
            btnSaveChanges.Enabled = false;
            btnDeleteBooking.Enabled = false;
            btnViewDetails.Enabled = false;
            calStartDate.Enabled = false;
            calEndDate.Enabled = false;
            chkMonday.Enabled = false;
            chkTuesday.Enabled = false;
            chkWednesday.Enabled = false;
            chkThursday.Enabled = false;
            chkFriday.Enabled = false;
            lblNotEditable.Visible = false;
            lblEditErrorMessage.Visible = false;
            lblBookingID.Visible = false;
            lblGroupID.Visible = false;
            lblChildName.Visible = false;

            try
            {
                while (childFound == false)
                {
                    if (lstChildName.SelectedItem.ToString().ToUpper() == (childValuesList[childValueCount][1].Trim() + " "
                        + childValuesList[childValueCount][2].Trim()).ToUpper())
                    {
                        selectedChildID = Convert.ToInt32(childValuesList[childValueCount][0]);
                        selectedChildForename = childValuesList[childValueCount][1];
                        selectedChildSurname = childValuesList[childValueCount][2];
                        selectedChildDOB = childValuesList[childValueCount][3];
                        childFound = true;
                        PopulateBookingsComboBox();
                    }
                    childValueCount++;
                }
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void cmbBookingDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool bookingFound = false;
            bookingInPast = false;

            try
            {
                while (!bookingFound)
                {
                    foreach (Booking booking in bookings)
                    {
                        if (booking.Deleted == false)
                        {
                            if (cmbBookingDates.SelectedItem.ToString().Substring(6, 10) == booking.StartDate
                                && cmbBookingDates.SelectedItem.ToString().Substring(22, 10) == booking.EndDate)
                            {
                                selectedBooking.ID = booking.ID;
                                selectedBooking.KidID = booking.KidID;
                                selectedBooking.StartDate = booking.StartDate;
                                selectedBooking.EndDate = booking.EndDate;
                                selectedBooking.Mon = booking.Mon;
                                selectedBooking.Tue = booking.Tue;
                                selectedBooking.Wed = booking.Wed;
                                selectedBooking.Thurs = booking.Thurs;
                                selectedBooking.Fri = booking.Fri;

                                if (Convert.ToDateTime(booking.StartDate) <= DateTime.Today) //Can only edit bookings that are at least one day in the future
                                {
                                    bookingInPast = true;
                                }

                                bookingFound = true;
                                SelectBooking();
                            }
                        }
                    }
                }
            }
            catch(NullReferenceException)
            {

            }
        }

        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            calEndDate.MinDate = calStartDate.SelectionStart.AddMonths(1);
            startDate = calStartDate.SelectionStart.ToString("dd-MM-yyyy");
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            endDate = calEndDate.SelectionStart.ToString("dd-MM-yyyy");
        }

        private void txtChildName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void chkMonday_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMonday.Checked == true)
            {
                chkMonday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                chkMonday.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void chkTuesday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTuesday.Checked == true)
            {
                chkTuesday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                chkTuesday.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void chkWednesday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWednesday.Checked == true)
            {
                chkWednesday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                chkWednesday.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void chkThursday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThursday.Checked == true)
            {
                chkThursday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                chkThursday.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void chkFriday_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFriday.Checked == true)
            {
                chkFriday.ForeColor = System.Drawing.Color.HotPink;
            }
            else
            {
                chkFriday.ForeColor = System.Drawing.Color.Yellow;
            }
        }
        #endregion
        #endregion

        public void SelectBooking()
        {
            if (bookingInPast)
            {
                calStartDate.MinDate = Convert.ToDateTime(selectedBooking.StartDate);
                calEndDate.MinDate = Convert.ToDateTime(selectedBooking.StartDate).AddMonths(1);
                btnSaveChanges.Enabled = false;
                calStartDate.Enabled = false;
                calEndDate.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                lblNotEditable.Visible = true;
                btnDeleteBooking.Enabled = true;
                btnViewDetails.Enabled = true;
            }
            else
            {
                calStartDate.MinDate = DateTime.Now.Date;
                calEndDate.MinDate = DateTime.Now.Date.AddMonths(1);
                btnSaveChanges.Enabled = true;
                btnDeleteBooking.Enabled = true;
                btnViewDetails.Enabled = true;
                calStartDate.Enabled = true;
                calEndDate.Enabled = true;
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
                lblNotEditable.Visible = false;
            }

            lblBookingID.Text = selectedBooking.ID.ToString();
            lblGroupID.Text = GetGroupID().ToString();
            lblChildName.Text = lstChildName.SelectedItem.ToString();
            calStartDate.SelectionStart = Convert.ToDateTime(selectedBooking.StartDate);
            calEndDate.SelectionStart = Convert.ToDateTime(selectedBooking.EndDate);
            if (selectedBooking.Mon)
            {
                chkMonday.Checked = true;
            }
            if (selectedBooking.Tue)
            {
                chkTuesday.Checked = true;
            }
            if (selectedBooking.Wed)
            {
                chkWednesday.Checked = true;
            }
            if (selectedBooking.Thurs)
            {
                chkThursday.Checked = true;
            }
            if (selectedBooking.Fri)
            {
                chkFriday.Checked = true;
            }

            lblBookingID.Visible = true;
            lblGroupID.Visible = true;
            lblChildName.Visible = true;
            panEditBooking.Enabled = true;

            IdentifyBookedOutDates(); 
        }

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
                if(booking.GroupID == GetGroupID() && Convert.ToDateTime(booking.EndDate) > DateTime.Now && selectedBooking.ID != booking.ID) //If the GroupID is the same as that of the current booking and the booking hasn't already finished
                {
                    flag = false;
                    dateCount = Convert.ToDateTime(booking.StartDate).Date;    
                    string[] datesOfSelectedBooking;

                    while(flag == false)
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
                        else if(datesOfSelectedBooking[i] != null)
                        {
                            allBookingsAndDates[bookingCount].Add(datesOfSelectedBooking[i]);
                            datesInListCounter++;
                        }
                    }
                    counter = 0;
                    bookingCount++;
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
                if (GetGroupID() == 1)
                {
                    if (bookedDatesNumberOfTimesBooked[i] >= 6)
                    {
                        bookedOutDates.Add(bookedDates[i]);
                    }
                }
                else if (GetGroupID() == 2)
                {
                    if (bookedDatesNumberOfTimesBooked[i] >= 10)
                    {
                        bookedOutDates.Add(bookedDates[i]);
                    }
                }
                else if (GetGroupID() == 3)
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
            DateTime dateCount = Convert.ToDateTime(selectedChildDOB);
            int monthCounter = 0;

            while (true)
            {
                if (dateCount.Date > DateTime.Now.Date)
                {
                    monthCounter--;

                    if (monthCounter >= 6 && monthCounter < 18)
                    {
                        return 1;
                    }
                    if (monthCounter >= 18 && monthCounter < 30)
                    {
                        return 2;
                    }
                    if (monthCounter >= 30 && monthCounter < 48)
                    {
                        return 3;
                    }
                }
                dateCount = dateCount.AddMonths(1);
                monthCounter++;
            }
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

        public bool CalculateCost()
        {
            DateTime dateCount = DateTime.Now;
            int dateCountCount = 0;

            while (true)
            {
                if (dateCount.Date >= calStartDate.SelectionStart.Date)
                {
                    if (dateCountCount < 3)
                    {
                        totalCost = daysBooked * 15;
                        totalCostDiscount = 0;
                    }
                    else if (dateCountCount < 6)
                    {
                        totalCost = (daysBooked * 15) * 0.97;
                        totalCostDiscount = 3;
                    }
                    else
                    {
                        totalCost = (daysBooked * 15) * 0.95;
                        totalCostDiscount = 5;
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
            bookedOutDatesCounter = 0;
            bookedOutCurrentBookingDates.Clear();

            while (true)
            {
                if (DaySelected())
                {
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Monday && chkMonday.Checked == true)
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
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Tuesday && chkTuesday.Checked == true)
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
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Wednesday && chkWednesday.Checked == true)
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
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Thursday && chkThursday.Checked == true)
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
                    if (dateCount.Date.DayOfWeek == DayOfWeek.Friday && chkFriday.Checked == true)
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

                if (dateCount.Date == calEndDate.SelectionStart.Date)
                {
                    bookingDuration = dateCountCount;
                    daysBooked = dayCount;

                    return true;
                }
                dateCount = dateCount.AddDays(1);
                dateCountCount++;
            }
        }

        public bool DaySelected()
        {
            if (chkMonday.Checked == false && chkTuesday.Checked == false && chkWednesday.Checked == false && chkThursday.Checked == false && chkFriday.Checked == false)
            {
                return false;
            }
            return true;
        }

        public void PopulateBookingsComboBox()
        {
            bookings = bookingDBA.getAllBookings();
            cmbBookingDates.Items.Clear();

            foreach (Booking booking in bookings)
            {
                if(booking.Deleted == false)
                {
                    if (booking.KidID == selectedChildID)
                    {
                        cmbBookingDates.Items.Add("From  " + booking.StartDate + "  to  " + booking.EndDate);
                    }
                }
            }
        }

        public void PopulateListBox()
        {
            List<Kid> allKids = kidDBA.getAllKids();

            if (txtChildName.Text == "")
            {
                foreach (Kid kid in allKids)
                {
                    if (kid.Deleted == false)
                    {
                        lstChildName.Items.Add(kid.Forename.Trim() + " " + kid.Surname.Trim());
                        childValuesList.Add(new List<string> { kid.ID.ToString(), kid.Forename, kid.Surname, kid.DateOfBirth });
                    }
                }
            }
        }
    }
}