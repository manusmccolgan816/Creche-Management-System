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
    public partial class ViewDataForm : Form
    {
        Database db;
        DataTable table;
        ParentDBAccess parentDBA;
        KidDBAccess kidDBA;
        BookingDBAccess bookingDBA;
        BookedOutDBAccess bookedOutDBA;
        GroupDBAccess groupDBA;
        StaffGroupDBAccess staffGroupDBA;
        StaffDBAccess staffDBA;

        public ViewDataForm(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();

            db = Db;
            parentDBA = new ParentDBAccess(db);
            kidDBA = new KidDBAccess(db);
            bookingDBA = new BookingDBAccess(db);
            bookedOutDBA = new BookedOutDBAccess(db);
            groupDBA = new GroupDBAccess(db);
            staffGroupDBA = new StaffGroupDBAccess(db);
            staffDBA = new StaffDBAccess(db);
        }

        #region Control interaction
        #region User feedback
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void radParent_MouseEnter_1(object sender, EventArgs e)
        {
            radParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radParent_MouseLeave_1(object sender, EventArgs e)
        {
            radParent.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radKid_MouseEnter_1(object sender, EventArgs e)
        {
            radKid.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radKid_MouseLeave_1(object sender, EventArgs e)
        {
            radKid.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radBooking_MouseEnter_1(object sender, EventArgs e)
        {
            radBooking.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radBooking_MouseLeave_1(object sender, EventArgs e)
        {
            radBooking.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radBookedOut_MouseEnter_1(object sender, EventArgs e)
        {
            radBookedOut.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radBookedOut_MouseLeave_1(object sender, EventArgs e)
        {
            radBookedOut.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radGroup_MouseEnter_1(object sender, EventArgs e)
        {
            radGroup.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radGroup_MouseLeave_1(object sender, EventArgs e)
        {
            radGroup.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radStaffGroup_MouseEnter_1(object sender, EventArgs e)
        {
            radStaffGroup.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radStaffGroup_MouseLeave_1(object sender, EventArgs e)
        {
            radStaffGroup.ForeColor = System.Drawing.Color.Yellow;
        }

        private void radStaff_MouseEnter_1(object sender, EventArgs e)
        {
            radStaff.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radStaff_MouseLeave_1(object sender, EventArgs e)
        {
            radStaff.ForeColor = System.Drawing.Color.Yellow;
        }
        #endregion

        #region Button clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }
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

        private void reoprtToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void radParent_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Forename");
            table.Columns.Add("Surname");
            table.Columns.Add("Phone number");
            table.Columns.Add("City");
            table.Columns.Add("Postcode");
            table.Columns.Add("Address");
            table.Columns.Add("Deleted");

            foreach (Parent parent in parents)
            {
                table.Rows.Add(parent.ID, parent.Forename, parent.Surname, parent.TelNo, parent.City, parent.Postcode, parent.Address, parent.Deleted);
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 8;
            dgvTables.Columns[1].Width = 707 / 8;
            dgvTables.Columns[2].Width = 707 / 8;
            dgvTables.Columns[3].Width = 707 / 8;
            dgvTables.Columns[4].Width = 707 / 8;
            dgvTables.Columns[5].Width = 707 / 8;
            dgvTables.Columns[6].Width = 707 / 8;
            dgvTables.Columns[7].Width = 707 / 8;
        }

        private void radKid_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Parent name");
            table.Columns.Add("Forename");
            table.Columns.Add("Surname");
            table.Columns.Add("D.O.B.");
            table.Columns.Add("Deleted");

            foreach (Kid kid in kids)
            {
                foreach(Parent parent in parents)
                {
                    if(parent.ID == kid.ParentID)
                    {
                        table.Rows.Add(kid.ID, parent.Forename.Trim() + " " + parent.Surname.Trim(), kid.Forename, kid.Surname, kid.DateOfBirth, kid.Deleted);
                    }
                }               
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 6;
            dgvTables.Columns[1].Width = 707 / 6;
            dgvTables.Columns[2].Width = 707 / 6;
            dgvTables.Columns[3].Width = 707 / 6;
            dgvTables.Columns[4].Width = 707 / 6;
            dgvTables.Columns[5].Width = 707 / 6;
        }

        private void radBooking_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Child name");
            table.Columns.Add("Group");
            table.Columns.Add("Start date");
            table.Columns.Add("End date");
            table.Columns.Add("Monday");
            table.Columns.Add("Tueday");
            table.Columns.Add("Wednesday");
            table.Columns.Add("Thursday");
            table.Columns.Add("Friday");
            table.Columns.Add("Deleted");

            foreach (Booking booking in bookings)
            {
                foreach(Kid kid in kids)
                {
                    if(kid.ID == booking.KidID)
                    {
                        table.Rows.Add(booking.ID, kid.Forename.Trim() + " " + kid.Surname.Trim(), booking.GroupID, booking.StartDate, booking.EndDate, booking.Mon, booking.Tue, booking.Wed, booking.Thurs, booking.Fri, booking.Deleted);
                    }                    
                }
                
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 11;
            dgvTables.Columns[1].Width = 707 / 11;
            dgvTables.Columns[2].Width = 707 / 11;
            dgvTables.Columns[3].Width = 707 / 11;
            dgvTables.Columns[4].Width = 707 / 11;
            dgvTables.Columns[5].Width = 707 / 11;
            dgvTables.Columns[6].Width = 707 / 11;
            dgvTables.Columns[7].Width = 707 / 11;
            dgvTables.Columns[8].Width = 707 / 11;
            dgvTables.Columns[9].Width = 707 / 11;
            dgvTables.Columns[10].Width = 707 / 11;
        }

        private void radBookedOut_CheckedChanged_1(object sender, EventArgs e)
        {
            List<BookedOut> bookedOuts = new List<BookedOut>();
            bookedOuts = bookedOutDBA.getAllBookedOuts();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Booking ID");
            table.Columns.Add("Date");

            foreach (BookedOut bookedOut in bookedOuts)
            {
                table.Rows.Add(bookedOut.ID, bookedOut.BookingID, bookedOut.Date);
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 3;
            dgvTables.Columns[1].Width = 707 / 3;
            dgvTables.Columns[2].Width = 707 / 3;
        }

        private void radGroup_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Group> groups = new List<Group>();
            groups = groupDBA.getAllGroups();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Max number of kids");
            table.Columns.Add("AgeRange");

            foreach (Group group in groups)
            {
                table.Rows.Add(group.ID, group.MaxNoKids, group.AgeRange);
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 722 / 3;
            dgvTables.Columns[1].Width = 722 / 3;
            dgvTables.Columns[2].Width = 722 / 3;
        }

        private void radStaffGroup_CheckedChanged_1(object sender, EventArgs e)
        {
            List<StaffGroup> staffGroups = new List<StaffGroup>();
            staffGroups = staffGroupDBA.getAllStaffGroups();
            List<Staff> staffMembers = new List<Staff>();
            staffMembers = staffDBA.getAllStaff();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Staff name");
            table.Columns.Add("Group");
            table.Columns.Add("Date");

            foreach (StaffGroup staffGroup in staffGroups)
            {
                foreach(Staff staffMember in staffMembers)
                {
                    if(staffMember.ID == staffGroup.StaffID)
                    {
                        table.Rows.Add(staffGroup.ID, staffMember.Forename.Trim() + " " + staffMember.Surname.Trim(), staffGroup.GroupID, staffGroup.Date);
                    }
                }
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 4;
            dgvTables.Columns[1].Width = 707 / 4;
            dgvTables.Columns[2].Width = 707 / 4;
            dgvTables.Columns[3].Width = 707 / 4;
        }

        private void radStaff_CheckedChanged_1(object sender, EventArgs e)
        {
            List<Staff> staffMembers = new List<Staff>();
            staffMembers = staffDBA.getAllStaff();
            table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Forename");
            table.Columns.Add("Surname");
            table.Columns.Add("Phone number");

            foreach (Staff staffMember in staffMembers)
            {
                table.Rows.Add(staffMember.ID, staffMember.Forename, staffMember.Surname, staffMember.TelNo);
            }

            dgvTables.DataSource = table;

            dgvTables.Columns[0].Width = 707 / 4;
            dgvTables.Columns[1].Width = 707 / 4;
            dgvTables.Columns[2].Width = 707 / 4;
            dgvTables.Columns[3].Width = 707 / 4;
        }
        #endregion
        #endregion
    }
}