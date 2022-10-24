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
    public partial class EditDeleteChild : Form
    {
        Database db;
        ParentDBAccess parentDBA;
        KidDBAccess kidDBA;
        BookingDBAccess bookingDBA;
        Kid selectedChild = new Objects.Kid();
        List<List<string>> childValuesList = new List<List<string>>();
        List<List<string>> parentValuesList = new List<List<string>>();
        int selectedChildID;
        int selectedChildParentID;
        string selectedChildForename;
        string selectedChildSurname;
        string selectedChildDOB;
        int parentIDPlaceholder;
        string childDOBPlaceholder;
        List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public EditDeleteChild(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();

            db = Db;
            parentDBA = new ParentDBAccess(db);
            kidDBA = new KidDBAccess(db);
            bookingDBA = new BookingDBAccess(db);
            calChildDateOfBirth.MaxDate = DateTime.Now.AddMonths(-6);
            calChildDateOfBirth.MinDate = DateTime.Now.AddYears(-4);

            txtChildForename.Enabled = false;
            txtChildSurname.Enabled = false;
            txtChildParentName.Enabled = false;
            lstChildParentName.Enabled = false;
            calChildDateOfBirth.Enabled = false;

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

        private void btnSaveChanges_MouseEnter(object sender, EventArgs e)
        {
            btnSaveChanges.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            btnSaveChanges.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnDeleteChild_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteChild.ForeColor = System.Drawing.Color.White;
        }

        private void btnDeleteChild_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteChild.ForeColor = System.Drawing.Color.Black;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) 
        {
            lblEditErrorMessage.Visible = true;

            if(EditChildValidation())
            {
                lblEditErrorMessage.Visible = false;

                selectedChild.ParentID = parentIDPlaceholder;
                selectedChild.Forename = txtChildForename.Text;
                selectedChild.Surname = txtChildSurname.Text;
                selectedChild.DateOfBirth = childDOBPlaceholder;

                kidDBA.updateKid(selectedChild);
                MessageBox.Show("Data updated");
                lblChildName.Text = selectedChild.Forename + " " + selectedChild.Surname;
                lstChildName.Items.Clear();
                PopulateListBox();
            }
            lstChildName.Items.Clear();
            PopulateListBox();
        }

        private void btnDeleteChild_Click(object sender, EventArgs e)
        {
            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete this child? Doing so will delete all future bookings under this child", "Delete", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                selectedChild.Deleted = true;

                kidDBA.updateKid(selectedChild);

                foreach(Booking booking in bookings)
                {
                    if(booking.Deleted == false)
                    {
                        if(booking.KidID == selectedChild.ID)
                        {
                            if (Convert.ToDateTime(booking.StartDate) > DateTime.Now.Date) //Delete future bookings of that child, as they will never be attended
                            {
                                booking.Deleted = true;
                                bookingDBA.updateBooking(booking);
                            }
                        }
                    }
                }

                txtChildForename.Text = "";
                txtChildSurname.Text = "";
                calChildDateOfBirth.SelectionStart = DateTime.Now.Date.AddMonths(-6);
                txtChildParentName.Text = "";
                lstChildParentName.Items.Clear();
                lblChildID.Text = "";
                lblChildName.Text = "";
                lblChildParentID.Text = "";
                lstChildName.Items.Clear();
                txtChildName.Text = "";
                lblEditErrorMessage.Visible = false;
                txtChildForename.Enabled = false;
                txtChildSurname.Enabled = false;
                txtChildParentName.Enabled = false;
                lstChildParentName.Enabled = false;
                calChildDateOfBirth.Enabled = false;
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
            lstChildName.Items.Clear();
            List<Kid> allKids = kidDBA.getAllKids();
            List<Kid> updateKids = new List<Kid>();

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
                        if(Convert.ToDateTime(kid.DateOfBirth) > calChildDateOfBirth.MinDate)
                        {
                            if ((kid.Forename.ToUpper().Trim() + " " + kid.Surname.ToUpper().Trim()).Contains(txtChildName.Text.ToUpper().Trim()))
                            {
                                updateKids.Add(kid);
                                childValuesList.Add(new List<string> { kid.ID.ToString(), kid.ParentID.ToString(), kid.Forename,
                            kid.Surname, kid.DateOfBirth });
                            }
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

        private void txtChildName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void lstChildName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int childValueCount = 0;
            bool childFound = false;

            try
            {
                while (childFound == false)
                {
                    if (lstChildName.SelectedItem.ToString().ToUpper() == (childValuesList[childValueCount][2].Trim() + " "
                        + childValuesList[childValueCount][3].Trim()).ToUpper())
                    {
                        selectedChildID = Convert.ToInt32(childValuesList[childValueCount][0]);
                        selectedChildParentID = Convert.ToInt32(childValuesList[childValueCount][1]);
                        selectedChildForename = childValuesList[childValueCount][2];
                        selectedChildSurname = childValuesList[childValueCount][3];
                        selectedChildDOB = childValuesList[childValueCount][4];
                        childFound = true;
                        SelectChild();
                    }
                    childValueCount++;
                }
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void txtChildForename_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtChildSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtChildParentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtChildParentName_TextChanged(object sender, EventArgs e)
        {
            lstChildParentName.Items.Clear();
            List<Parent> allParents = parentDBA.getAllParents();
            List<Parent> updateParents = new List<Parent>();

            bool letterInput = false;

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (txtChildParentName.Text.ToLower().Contains(alphabet[i]))
                {
                    letterInput = true;
                }
            }

            if (letterInput == true)
            {
                foreach (Parent parent in allParents)
                {
                    if ((parent.Forename.ToUpper().Trim() + " " + parent.Surname.ToUpper().Trim()).Contains(txtChildParentName.Text.ToUpper().Trim()))
                    {
                        updateParents.Add(parent);
                        parentValuesList.Add(new List<string> { parent.Forename.Trim(), parent.Surname.Trim(), parent.ID.ToString() });
                    }
                }

                foreach (Parent parent in updateParents)
                {
                    lstChildParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim());
                }
                if (txtChildParentName.Text == "")
                {
                    lstChildParentName.Items.Clear();
                }
            }
        }

        private void lstChildParentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parentIDCount = 0;
            bool IDFound = false;

            try
            {
                while (IDFound == false)
                {
                    if (lstChildParentName.SelectedItem.ToString().ToUpper() == (parentValuesList[parentIDCount][0] + " " + parentValuesList[parentIDCount][1]).ToUpper())
                    {
                        parentIDPlaceholder = Convert.ToInt32(parentValuesList[parentIDCount][2]);
                        lblChildParentID.Text = parentIDPlaceholder.ToString();
                        IDFound = true;
                    }
                    parentIDCount++;
                }
            }
            catch(NullReferenceException)
            {

            }
        }

        private void calChildDateOfBirth_DateChanged(object sender, DateRangeEventArgs e)
        {
            childDOBPlaceholder = calChildDateOfBirth.SelectionStart.ToString("dd-MM-yyyy");
        }
        #endregion
        #endregion

        public void SelectChild()
        {
            List<Parent> allParents = parentDBA.getAllParents();

            selectedChild.ID = selectedChildID;
            selectedChild.ParentID = selectedChildParentID;
            selectedChild.Forename = selectedChildForename;
            selectedChild.Surname = selectedChildSurname;
            selectedChild.DateOfBirth = selectedChildDOB;

            foreach (Parent parent in allParents)
            {
                if (parent.ID == selectedChildParentID)
                {
                    txtChildParentName.Text = parent.Forename.Trim() + " " + parent.Surname.Trim();
                    lstChildParentName.SelectedIndex = 0;
                }
            }

            lblEditErrorMessage.Visible = false;
            lblChildID.Text = selectedChildID.ToString();
            lblChildName.Text = selectedChild.Forename.Trim() + " " + selectedChild.Surname.Trim();
            lblChildParentID.Text = selectedChildParentID.ToString();
            txtChildForename.Text = selectedChildForename;
            txtChildSurname.Text = selectedChildSurname;
            calChildDateOfBirth.SelectionStart = Convert.ToDateTime(selectedChildDOB);
            lblChildID.Visible = true;
            lblChildName.Visible = true;
            lblChildParentID.Visible = true;
            txtChildForename.Enabled = true;
            txtChildSurname.Enabled = true;
            txtChildParentName.Enabled = true;
            lstChildParentName.Enabled = true;
            calChildDateOfBirth.Enabled = true;
            
        }

        public bool EditChildValidation()
        {
            List<Kid> kids = kidDBA.getAllKids();
            childValuesList = new List<List<string>>();

            if (txtChildForename.Text == "" || txtChildSurname.Text == "" || lstChildParentName.SelectedItem == null || calChildDateOfBirth.SelectionStart == null) //ADD FUNCTIONALITY TO CHECK IF PARENT HAS BEEN SELECTED
            {
                lblEditErrorMessage.Text = "Please fill in every box";
                lblEditErrorMessage.Visible = true;
                return false;
            }

            foreach (Kid kid in kids)
            {
                if (kid.Deleted == false)
                {
                    if (kid.Forename == txtChildForename.Text && kid.Surname == txtChildSurname.Text && kid.DateOfBirth == childDOBPlaceholder && kid.ParentID == parentIDPlaceholder)
                    {
                        lblEditErrorMessage.Text = "Child already exists";
                        lblEditErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }

        public void PopulateListBox()
        {
            List<Kid> allKids = kidDBA.getAllKids();
            childValuesList = new List<List<string>>();

            if (txtChildName.Text == "")
            {
                foreach (Kid kid in allKids)
                {
                    if (kid.Deleted == false)
                    {
                        if(Convert.ToDateTime(kid.DateOfBirth) > calChildDateOfBirth.MinDate)
                        {
                            lstChildName.Items.Add(kid.Forename.Trim() + " " + kid.Surname.Trim());
                            childValuesList.Add(new List<string> { kid.ID.ToString(), kid.ParentID.ToString(), kid.Forename,
                            kid.Surname, kid.DateOfBirth });
                        }
                    }
                }
            }
        }
    }
}