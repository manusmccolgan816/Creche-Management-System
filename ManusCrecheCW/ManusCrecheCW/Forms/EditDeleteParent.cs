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
    public partial class EditDeleteParent : Form
    {
        Database db;
        ParentDBAccess parentDBA;
        KidDBAccess kidDBA;
        BookingDBAccess bookingDBA;
        Parent selectedParent = new Objects.Parent();
        List<List<string>> parentValuesList = new List<List<string>>();
        List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
        'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public EditDeleteParent(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();

            db = Db;
            parentDBA = new ParentDBAccess(db);
            kidDBA = new KidDBAccess(db);
            bookingDBA = new BookingDBAccess(db);
            txtParentForename.Enabled = false;
            txtParentSurname.Enabled = false;
            txtParentTelNo.Enabled = false;
            txtParentCity.Enabled = false;
            txtParentPostcode.Enabled = false;
            txtParentAddress.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnDeleteParent.Enabled = false;
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

        private void btnDeleteParent_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteParent.ForeColor = System.Drawing.Color.White;
        }

        private void btnDeleteParent_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteParent.ForeColor = System.Drawing.Color.Black;
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
            if (EditParentValidation())
            {
                lblEditErrorMessage.Visible = false;

                selectedParent.Forename = txtParentForename.Text;
                selectedParent.Surname = txtParentSurname.Text;
                selectedParent.TelNo = txtParentTelNo.Text;
                selectedParent.City = txtParentCity.Text;
                selectedParent.Postcode = txtParentPostcode.Text;
                selectedParent.Address = txtParentAddress.Text;

                parentDBA.updateParent(selectedParent);
                MessageBox.Show("Data updated");
                lblParentName.Text = selectedParent.Forename + " " + selectedParent.Surname;
                lstParentName.Items.Clear();
                PopulateListBox();
            }
        }

        private void btnDeleteParent_Click(object sender, EventArgs e)
        {
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();
            List<Booking> bookings = new List<Booking>();
            bookings = bookingDBA.getAllBookings();
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete this parent? Doing so will delete all children of this parent and all future bookings of those children", "Delete", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                selectedParent.Deleted = true;
                parentDBA.updateParent(selectedParent);

                foreach(Kid kid in kids)
                {
                    if(kid.Deleted == false)
                    {
                        if(kid.ParentID == selectedParent.ID)
                        {
                            foreach(Booking booking in bookings)
                            {
                                if(booking.Deleted == false)
                                {
                                    if(booking.KidID == kid.ID)
                                    {
                                        if(Convert.ToDateTime(booking.StartDate) > DateTime.Now.Date) //Delete future bookings of that child, as they will never happen
                                        {
                                            booking.Deleted = true;
                                            bookingDBA.updateBooking(booking);
                                        }
                                    }
                                }
                            }
                            kid.Deleted = true;
                            kidDBA.updateKid(kid);
                        }
                    }
                }

                lblParentID.Text = "";
                lblParentName.Text = "";
                txtParentForename.Text = "";
                txtParentSurname.Text = "";
                txtParentTelNo.Text = "";
                txtParentCity.Text = "";
                txtParentPostcode.Text = "";
                txtParentAddress.Text = "";
                txtParentName.Text = "";
                lblEditErrorMessage.Visible = false;

                txtParentForename.Enabled = false;
                txtParentSurname.Enabled = false;
                txtParentTelNo.Enabled = false;
                txtParentCity.Enabled = false;
                txtParentPostcode.Enabled = false;
                txtParentAddress.Enabled = false;
                btnSaveChanges.Enabled = false;
                btnDeleteParent.Enabled = false;

                lstParentName.Items.Clear();
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
        private void txtChildParentName_TextChanged(object sender, EventArgs e)
        {
            lstParentName.Items.Clear();
            List<Parent> allParents = parentDBA.getAllParents();
            List<Parent> updateParents = new List<Parent>();

            bool letterInput = false;

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (txtParentName.Text.ToLower().Contains(alphabet[i]))
                {
                    letterInput = true;
                }
            }

            if (letterInput == true)
            {
                foreach (Parent parent in allParents)
                {
                    if(parent.Deleted == false)
                    {
                        if ((parent.Forename.ToUpper().Trim() + " " + parent.Surname.ToUpper().Trim()).Contains(txtParentName.Text.ToUpper().Trim()))
                        {
                            updateParents.Add(parent);
                            parentValuesList.Add(new List<string> { parent.ID.ToString(), parent.Forename.Trim(), parent.Surname.Trim(), parent.TelNo,
                            parent.City, parent.Postcode, parent.Address }); //Stores values for future reference
                        }
                    }
                }

                foreach (Parent parent in updateParents)
                {
                    if(parent.Deleted == false)
                    {
                        lstParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim());
                    }
                }
            }

            if (txtParentName.Text == "")
            {
                lstParentName.Items.Clear();
                PopulateListBox();
            }
        }

        private void txtParentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void lstParentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parentValueCount = 0;
            bool parentFound = false;

            try
            {
                while (parentFound == false)
                {
                    if (lstParentName.SelectedItem.ToString().ToUpper() == (parentValuesList[parentValueCount][1] + " " + parentValuesList[parentValueCount][2]).ToUpper())
                    {
                        selectedParent.ID = Convert.ToInt32(parentValuesList[parentValueCount][0]); //Sets selectedParentID to the ID of the parent with the corresponding name
                        selectedParent.Forename = parentValuesList[parentValueCount][1];
                        selectedParent.Surname = parentValuesList[parentValueCount][2];
                        selectedParent.TelNo = parentValuesList[parentValueCount][3];
                        selectedParent.City = parentValuesList[parentValueCount][4];
                        selectedParent.Postcode = parentValuesList[parentValueCount][5];
                        selectedParent.Address = parentValuesList[parentValueCount][6];
                        parentFound = true;
                        SelectParent();
                    }
                    parentValueCount++;
                }
            }
            catch(System.NullReferenceException)
            {

            }
        }

        private void txtParentForename_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtParentSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtParentTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }

        private void txtParentCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
            }
        }
        #endregion
        #endregion

        public void SelectParent()
        {
            lblParentID.Text = selectedParent.ID.ToString();
            lblParentName.Text = selectedParent.Forename + " " + selectedParent.Surname;
            txtParentForename.Text = selectedParent.Forename;
            txtParentSurname.Text = selectedParent.Surname;
            txtParentTelNo.Text = selectedParent.TelNo;
            txtParentCity.Text = selectedParent.City;
            txtParentPostcode.Text = selectedParent.Postcode;
            txtParentAddress.Text = selectedParent.Address;
            lblEditErrorMessage.Visible = false;
            lblParentID.Visible = true;
            lblParentName.Visible = true;
            txtParentForename.Enabled = true;
            txtParentSurname.Enabled = true;
            txtParentTelNo.Enabled = true;
            txtParentCity.Enabled = true;
            txtParentPostcode.Enabled = true;
            txtParentAddress.Enabled = true;
            btnSaveChanges.Enabled = true;
            btnDeleteParent.Enabled = true;
        }

        public bool EditParentValidation()
        {
            List<int> allInts = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();

            if (txtParentForename.Text == "" || txtParentSurname.Text == "" || txtParentTelNo.Text == "" || txtParentCity.Text == ""
                || txtParentPostcode.Text == "" || txtParentAddress.Text == "")
            {
                lblEditErrorMessage.Text = "Please fill in every box";
                lblEditErrorMessage.Visible = true;
                return false;
            }

            if (txtParentPostcode.Text.Length < 5)
            {
                lblEditErrorMessage.Text = "Postcode does not exist";
                lblEditErrorMessage.Visible = true;
                return false;
            }

            if (txtParentTelNo.Text.Length < 8)
            {
                lblEditErrorMessage.Text = "Phone number is too short";
                lblEditErrorMessage.Visible = true;
                return false;
            }

            foreach (Parent parent in parents)
            {
                if (parent.Deleted == false)
                {
                    if (parent.Forename == txtParentForename.Text && parent.Surname == txtParentSurname.Text && parent.TelNo == txtParentTelNo.Text && parent.City == txtParentCity.Text
                        && parent.Postcode == txtParentPostcode.Text && parent.Address == txtParentAddress.Text)
                    {
                        lblEditErrorMessage.Text = "Parent already exists";
                        lblEditErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }

        public void PopulateListBox()
        {
            List<Parent> allParents = parentDBA.getAllParents();
            parentValuesList = new List<List<string>>();

            if (txtParentName.Text == "")
            {
                foreach (Parent parent in allParents)
                {
                    if (parent.Deleted == false)
                    {
                        lstParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim());
                        parentValuesList.Add(new List<string> { parent.ID.ToString(), parent.Forename.Trim(), parent.Surname.Trim(), parent.TelNo,
                            parent.City, parent.Postcode, parent.Address });
                    }
                }
            }
        }
    }
}