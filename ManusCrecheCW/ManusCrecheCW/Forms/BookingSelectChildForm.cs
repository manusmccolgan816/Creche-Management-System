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
    public partial class BookingSelectChildForm : Form
    {
        Database db;
        ParentDBAccess parentDBA;
        KidDBAccess kidDBA;
        Parent selectedParent = new Objects.Parent();
        Kid selectedChild = new Objects.Kid();
        List<List<string>> parentValuesList = new List<List<string>>();
        List<List<string>> childValuesList = new List<List<string>>();
        string selectedParentIDInList;
        string selectedParentForenameInList;
        string selectedParentSurnameInList;
        string selectedParentTelNoInList;
        string selectedParentCityInList;
        string selectedParentPostcodeInList;
        string selectedParentAddressInList;
        int selectedParentID;
        string selectedParentForename;
        string selectedParentSurname;
        string selectedParentTelNo;
        string selectedParentCity;
        string selectedParentPostcode;
        string selectedParentAddress;
        bool newParent = false;
        bool newChild;
        string childDOB;
        List<int> allInts = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int selectedChildID;
        int selectedChildParentID;
        string selectedChildForename;
        string selectedChildSurname;
        string selectedChildDOB;

        public BookingSelectChildForm(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            parentDBA = new ParentDBAccess(db);
            kidDBA = new KidDBAccess(db);
            calChildDateOfBirth.MaxDate = DateTime.Now.AddMonths(-6);
            calChildDateOfBirth.MinDate = DateTime.Now.AddYears(-4);
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

        private void btnConfirmParent_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnConfirmParent_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmParent.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnConfirmChild_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnConfirmChild_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmChild.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void radNewParent_MouseEnter(object sender, EventArgs e)
        {
            radNewParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radNewParent_MouseLeave(object sender, EventArgs e)
        {
            radNewParent.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void radExistingParent_MouseEnter(object sender, EventArgs e)
        {
            radExistingParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radExistingParent_MouseLeave(object sender, EventArgs e)
        {
            radExistingParent.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void radNewChild_MouseEnter(object sender, EventArgs e)
        {
            radNewChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radNewChild_MouseLeave(object sender, EventArgs e)
        {
            radNewChild.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void radExistingChild_MouseEnter(object sender, EventArgs e)
        {
            radExistingChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void radExistingChild_MouseLeave(object sender, EventArgs e)
        {
            radExistingChild.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnConfirmParent_Click(object sender, EventArgs e)
        {
            if(newParent == true)
            {
                SaveNewParent();
            }
            else
            {
                SelectExistingParent();
            }
        }

        private void btnConfirmChild_Click(object sender, EventArgs e)
        {
            if(newChild == true)
            {
                SaveNewChild();
            }
            else
            {
                SelectExistingChild();
            }
        }
        #endregion
        #endregion

        #region Radio buttons
        private void radNewParent_CheckedChanged(object sender, EventArgs e)
        {
            newParent = true;
            panChildInfo.Enabled = false;
            cmbChildName.Items.Clear();
            lstParentName.SelectedIndex = -1;
            lblParentErrorMessage.Visible = false;
            panExistingParentDetails.Visible = false;
            panNewParentDetails.Visible = true;
            lblParentName.Visible = false;
        }

        private void radExistingParent_CheckedChanged(object sender, EventArgs e)
        {
            newParent = false;
            lblParentErrorMessage.Visible = false;
            panNewParentDetails.Visible = false;
            panExistingParentDetails.Visible = true;
        }

        private void radNewChild_CheckedChanged(object sender, EventArgs e)
        {
            newChild = true;
            lblChildErrorMessage.Visible = false;
            panExistingChild.Visible = false;
            //panNewChild.Enabled = true;
            panNewChild.Visible = true;
        }

        private void radExistingChild_CheckedChanged(object sender, EventArgs e)
        {
            newChild = false;
            lblChildErrorMessage.Visible = false;
            panNewChild.Visible = false;
            panExistingChild.Visible = true;
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
        private void txtParentName_TextChanged(object sender, EventArgs e)
        {
            List<Parent> allParents = parentDBA.getAllParents();
            List<Parent> updateParents = new List<Parent>();
            List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            bool letterInput = false;
            lstParentName.Items.Clear();

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (txtParentName.Text.ToLower().Contains(alphabet[i]))
                {
                    letterInput = true;
                }
            }

            if(letterInput == true)
            {
                foreach (Parent parent in allParents)
                {
                    if(parent.Deleted == false)
                    {
                        if ((parent.Forename.ToUpper().Trim() + " " + parent.Surname.ToUpper().Trim()).Contains(txtParentName.Text.ToUpper().Trim()))
                        {
                            updateParents.Add(parent);
                            selectedParentIDInList = parent.ID.ToString();
                            selectedParentForenameInList = parent.Forename.Trim();
                            selectedParentSurnameInList = parent.Surname.Trim();
                            selectedParentTelNoInList = parent.TelNo;
                            selectedParentCityInList = parent.City;
                            selectedParentPostcodeInList = parent.Postcode;
                            selectedParentAddressInList = parent.Address;
                            parentValuesList.Add(new List<string> { selectedParentIDInList, selectedParentForenameInList, selectedParentSurnameInList, selectedParentTelNoInList,
                            selectedParentCityInList, selectedParentPostcodeInList, selectedParentAddressInList }); //Stores values for future reference
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
                        selectedParentID = Convert.ToInt32(parentValuesList[parentValueCount][0]); //Sets selectedParentID to the ID of the parent with the corresponding name
                        selectedParentForename = parentValuesList[parentValueCount][1];
                        selectedParentSurname = parentValuesList[parentValueCount][2];
                        selectedParentTelNo = parentValuesList[parentValueCount][3];
                        selectedParentCity = parentValuesList[parentValueCount][4];
                        selectedParentPostcode = parentValuesList[parentValueCount][5];
                        selectedParentAddress = parentValuesList[parentValueCount][6];
                        parentFound = true;
                        lblParentName.Text = lstParentName.SelectedItem.ToString();
                        lblParentName.Visible = true;
                        SelectExistingParent();
                    }
                    parentValueCount++;
                }
            }
            catch(NullReferenceException)
            {

            }
        }

        private void calChildDateOfBirth_DateChanged(object sender, DateRangeEventArgs e)
        {
            childDOB = calChildDateOfBirth.SelectionStart.ToString("dd-MM-yyyy");
        }

        private void cmbChildName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int childValueCount = 0;
            bool childFound = false;

            try
            {
                while (childFound == false)
                {
                    if (cmbChildName.SelectedItem.ToString().ToUpper() == (childValuesList[childValueCount][2] + " " + childValuesList[childValueCount][3]).ToUpper())
                    {
                        selectedChildID = Convert.ToInt32(childValuesList[childValueCount][0]);
                        selectedChildParentID = Convert.ToInt32(childValuesList[childValueCount][1]);
                        selectedChildForename = childValuesList[childValueCount][2];
                        selectedChildSurname = childValuesList[childValueCount][3];
                        selectedChildDOB = childValuesList[childValueCount][4];
                        childFound = true;
                    }
                    childValueCount++;
                }
            }
            catch(NullReferenceException)
            {

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

        private void txtParentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
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

        private void txtParentCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
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
        #endregion
        #endregion

        #region Adding/selecting parent
        public void SelectExistingParent()
        {
            selectedParent.ID = selectedParentID;
            selectedParent.Forename = selectedParentForename;
            selectedParent.Surname = selectedParentSurname;
            selectedParent.TelNo = selectedParentTelNo;
            selectedParent.City = selectedParentCity;
            selectedParent.Postcode = selectedParentPostcode;
            selectedParent.Address = selectedParentAddress;

            PopulateChildComboBox();
            lblChildErrorMessage.Visible = false;
            panChildInfo.Enabled = true;
        }

        public void SaveNewParent()
        {
            Parent newParent = new Objects.Parent();

            if (SaveNewParentValidation())
            {
                lblParentErrorMessage.Visible = false;
                
                newParent.ID = GetParentID();
                newParent.Forename = txtParentForename.Text;
                newParent.Surname = txtParentSurname.Text;
                newParent.TelNo = txtParentTelNo.Text;
                newParent.City = txtParentCity.Text;
                newParent.Postcode = txtParentPostcode.Text;
                newParent.Address = txtParentAddress.Text;
                newParent.Deleted = false;

                parentDBA.addParent(newParent);

                selectedParent.ID = newParent.ID;
                selectedParent.Forename = txtParentForename.Text;
                selectedParent.Surname = txtParentSurname.Text;
                selectedParent.TelNo = txtParentTelNo.Text;
                selectedParent.City = txtParentCity.Text;
                selectedParent.Postcode = txtParentPostcode.Text;
                selectedParent.Address = txtParentAddress.Text;

                MessageBox.Show("Parent added");

                panParentInfo.Enabled = false;
                panChildInfo.Enabled = true;
                radExistingChild.Enabled = false;
                radNewChild.Checked = true;
                newChild = true;
            }
        }

        public bool SaveNewParentValidation()
        {
            List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();

            if (txtParentForename.Text == "" || txtParentSurname.Text == "" || txtParentTelNo.Text == "" || txtParentCity.Text == ""
                || txtParentPostcode.Text == "" || txtParentAddress.Text == "")
            {
                lblParentErrorMessage.Text = "Please fill in every box";
                lblParentErrorMessage.Visible = true;
                return false;
            }

            if (txtParentPostcode.Text.Length < 5)
            {
                lblParentErrorMessage.Text = "Postcode does not exist";
                lblParentErrorMessage.Visible = true;
                return false;
            }

            if (txtParentTelNo.Text.Length < 8)
            {
                lblParentErrorMessage.Text = "Phone number is too\nshort";
                lblParentErrorMessage.Visible = true;
                return false;
            }

            foreach (Parent parent in parents)
            {
                if (parent.Deleted == false)
                {
                    if (parent.Forename == txtParentForename.Text && parent.Surname == txtParentSurname.Text && parent.TelNo == txtParentTelNo.Text && parent.City == txtParentCity.Text
                        && parent.Postcode == txtParentPostcode.Text && parent.Address == txtParentAddress.Text)
                    {
                        lblParentErrorMessage.Text = "Parent already exists";
                        lblParentErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }
        #endregion

        #region Adding/selecting child
        public void SelectExistingChild()
        {
            if(SelectExistingChildValidation())
            {
                selectedChild.ID = selectedChildID;
                selectedChild.ParentID = selectedChildParentID;
                selectedChild.Forename = selectedChildForename;
                selectedChild.Surname = selectedChildSurname;
                selectedChild.DateOfBirth = selectedChildDOB;

                this.Hide();
                Form FormObject = new BookingSelectDatesForm(db, selectedParent, selectedChild);
                FormObject.Show();
            }
        }

        public bool SelectExistingChildValidation()
        {
            if (cmbChildName.SelectedItem == null)
            {
                lblChildErrorMessage.Text = "Please select a child";
                lblChildErrorMessage.Visible = true;
                return false;
            }

            return true;
        }

        public void SaveNewChild()
        {
            Kid newKid = new Objects.Kid();

            if (SaveNewChildValidation())
            {
                lblChildErrorMessage.Visible = false;
                newKid.ID = GetChildID();
                newKid.ParentID = selectedParent.ID;
                newKid.Forename = txtChildForename.Text;
                newKid.Surname = txtChildSurname.Text;
                newKid.DateOfBirth = childDOB;
                newKid.Deleted = false;
                kidDBA.addKid(newKid);

                selectedChild.ID = newKid.ID;
                selectedChild.ParentID = selectedParent.ID;
                selectedChild.Forename = txtChildForename.Text;
                selectedChild.Surname = txtChildSurname.Text;
                selectedChild.DateOfBirth = childDOB;

                MessageBox.Show("Child added");

                this.Hide();
                Form FormObject = new BookingSelectDatesForm(db, selectedParent, selectedChild);
                FormObject.Show();
            }
        }

        public bool SaveNewChildValidation()
        {
            List<Kid> kids = kidDBA.getAllKids();
            childValuesList = new List<List<string>>();

            if (txtChildForename.Text == "" || txtChildSurname.Text == "" || childDOB == null)
            {
                lblChildErrorMessage.Text = "Please fill in all details";
                lblChildErrorMessage.Visible = true;
                return false;
            }

            foreach (Kid kid in kids)
            {
                if (kid.Deleted == false)
                {
                    if (kid.Forename == txtChildForename.Text && kid.Surname == txtChildSurname.Text && kid.DateOfBirth == childDOB && kid.ParentID == selectedParent.ID)
                    {
                        lblChildErrorMessage.Text = "Child already exists";
                        lblChildErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }
        #endregion

        public void PopulateChildComboBox()
        {
            List<Kid> allKids = kidDBA.getAllKids();
            DateTime dateCount;
            int monthCounter = 0;
            bool flag = false;
            bool overAge = false;
            cmbChildName.Items.Clear();
            childValuesList = new List<List<string>>();

            foreach (Kid kid in allKids)
            {
                if (kid.Deleted == false)
                {
                    if (kid.ParentID == selectedParent.ID)
                    {
                        dateCount = Convert.ToDateTime(kid.DateOfBirth).Date;
                        while (!flag)
                        {
                            if (dateCount.Date > DateTime.Now.Date)
                            {
                                monthCounter--;

                                if (monthCounter >= 60)
                                {
                                    overAge = true;
                                }
                                flag = true;
                            }
                            dateCount = dateCount.AddMonths(1);
                            monthCounter++;
                        }
                        if(!overAge)
                        {
                            cmbChildName.Items.Add(kid.Forename.Trim() + " " + kid.Surname.Trim());
                            childValuesList.Add(new List<string> { kid.ID.ToString(), kid.ParentID.ToString(), kid.Forename.Trim(), kid.Surname.Trim(), kid.DateOfBirth });
                        }
                    } 
                }
            }
        }

        public int GetParentID()
        {
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();
            int greatestID = 0;

            foreach (Parent parent in parents)
            {
                if (parent.ID > greatestID)
                {
                    greatestID = parent.ID;
                }
            }
            greatestID++;
            return greatestID;
        }

        public int GetChildID()
        {
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();
            int greatestID = 0;

            foreach (Kid kid in kids)
            {
                if (kid.ID > greatestID)
                {
                    greatestID = kid.ID;
                }
            }
            greatestID++;
            return greatestID;
        }

        public void PopulateListBox()
        {
            List<Parent> allParents = parentDBA.getAllParents();
            lblParentName.Visible = false;

            if (txtParentName.Text == "")
            {
                foreach (Parent parent in allParents)
                {
                    if (parent.Deleted == false)
                    {
                        lstParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim());
                        selectedParentIDInList = parent.ID.ToString();
                        selectedParentForenameInList = parent.Forename.Trim();
                        selectedParentSurnameInList = parent.Surname.Trim();
                        selectedParentTelNoInList = parent.TelNo;
                        selectedParentCityInList = parent.City;
                        selectedParentPostcodeInList = parent.Postcode;
                        selectedParentAddressInList = parent.Address;
                        parentValuesList.Add(new List<string> { selectedParentIDInList, selectedParentForenameInList, selectedParentSurnameInList, selectedParentTelNoInList,
                            selectedParentCityInList, selectedParentPostcodeInList, selectedParentAddressInList });
                    }
                }
            }
        }
    }
}