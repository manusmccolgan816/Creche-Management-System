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
using ManusCrecheCW.Forms;
using ManusCrecheCW.DBAccess;

namespace ManusCrecheCW.Forms
{
    public partial class AddChild : Form
    {
        Database db;
        KidDBAccess kidDBA;
        ParentDBAccess parentDBA;
        string selectedDate;
        string selectedParent;
        List<List<string>> parentIDNamesList = new List<List<string>>(); //Need to use this to find parentID
        string selectedParentForename;
        string selectedParentSurname;
        string selectedParentID;
        int parentID;

        public AddChild(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            kidDBA = new KidDBAccess(db);
            parentDBA = new ParentDBAccess(db);
            calChildDateOfBirth.MaxDate = DateTime.Now.AddMonths(-6);
            calChildDateOfBirth.MinDate = DateTime.Now.AddYears(-4);
            PopulateListBox(); //This is unique to this constructor
        }

        public AddChild(Database Db, string SelectedParent)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            selectedParent = SelectedParent;
            kidDBA = new KidDBAccess(db);
            parentDBA = new ParentDBAccess(db);
            calChildDateOfBirth.MaxDate = DateTime.Now.AddMonths(-6);
            calChildDateOfBirth.MinDate = DateTime.Now.AddYears(-4);
            txtChildParentName.Text = selectedParent; //This is unique to this constructor
            lstChildParentName.SelectedIndex = 0; //This is unique to this constructor
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

        private void btnSaveChild_MouseEnter(object sender, EventArgs e)
        {
            btnSaveChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnSaveChild_MouseLeave(object sender, EventArgs e)
        {
            btnSaveChild.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnSaveChild_Click(object sender, EventArgs e)
        {
            Kid newKid = new Objects.Kid();

            if (SaveChildValidation())
            {
                lblErrorMessage.Visible = false;
                lblForenameErrorMessage.Visible = false;
                lblSurnameErrorMessage.Visible = false;
                lblParentNameErrorMessage.Visible = false;
                newKid.ID = GetID();
                newKid.ParentID = parentID;
                newKid.Forename = txtChildForename.Text;
                newKid.Surname = txtChildSurname.Text;
                newKid.DateOfBirth = selectedDate;
                newKid.Deleted = false;

                kidDBA.addKid(newKid);
                MessageBox.Show("Child added");

                txtChildForename.Text = "";
                txtChildSurname.Text = "";
                txtChildParentName.Text = "";
                lstChildParentName.Items.Clear();
                PopulateListBox();
                calChildDateOfBirth.SetDate(DateTime.Now.Date.AddMonths(-6));
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
        private void txtChildParentName_TextChanged_1(object sender, EventArgs e)
        {
            List<Parent> allParents = parentDBA.getAllParents();
            List<Parent> updateParents = new List<Parent>();
            List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            bool letterInput = false;
            lstChildParentName.Items.Clear();

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (txtChildParentName.Text.ToLower().Contains(alphabet[i]))
                {
                    letterInput = true;
                }
            }

            if (letterInput == true) //This ensures that a search isn't made when only a space is input
            {
                foreach (Parent parent in allParents)
                {
                    if (parent.Deleted == false)
                    {
                        if ((parent.Forename.ToUpper().Trim() + " " + parent.Surname.ToUpper().Trim()).Contains(txtChildParentName.Text.ToUpper().Trim())) //If parent forename contains the text in the text box
                        {
                            updateParents.Add(parent);
                            selectedParentForename = parent.Forename.Trim();
                            selectedParentSurname = parent.Surname.Trim();
                            selectedParentID = parent.ID.ToString();
                            parentIDNamesList.Add(new List<string> { selectedParentForename, selectedParentSurname, selectedParentID }); //Stores values so that the parent can be identified by ID if selected
                        }
                    }
                }

                foreach (Parent parent in updateParents)
                {
                    if (parent.Deleted == false)
                    {
                        lstChildParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim()); //Adds parent to list box
                    }
                }
            }
            if (txtChildParentName.Text == "")
            {
                lstChildParentName.Items.Clear();
                PopulateListBox();
            }
        }

        private void lstChildParentName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int parentIDCount = 0;
            bool IDFound = false;
            lblParentNameErrorMessage.Visible = false;

            try
            {
                while (IDFound == false)
                {
                    if (lstChildParentName.SelectedItem.ToString().ToUpper() == (parentIDNamesList[parentIDCount][0] + " " + parentIDNamesList[parentIDCount][1]).ToUpper())
                    {
                        parentID = Convert.ToInt32(parentIDNamesList[parentIDCount][2]); //Sets parentID to the ID of the parent with the corresponding name
                        lblParentName.Text = lstChildParentName.SelectedItem.ToString();
                        lblParentName.Visible = true;
                        IDFound = true;
                    }
                    parentIDCount++;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void calChildDateOfBirth_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            selectedDate = calChildDateOfBirth.SelectionStart.ToString("dd-MM-yyyy");
        }

        private void txtChildForename_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
                lblForenameErrorMessage.Visible = true;
            }
            else
            {
                lblForenameErrorMessage.Visible = false;
            }
        }

        private void txtChildSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
                lblSurnameErrorMessage.Visible = true;
            }
            else
            {
                lblSurnameErrorMessage.Visible = false;
            }
        }

        private void txtChildParentName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
                lblParentNameErrorMessage.Visible = true;
            }
            else
            {
                lblParentNameErrorMessage.Visible = false;
            }
        }
        #endregion
        #endregion

        public bool SaveChildValidation()
        {
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();

            if (txtChildForename.Text == "" || txtChildSurname.Text == "" || lstChildParentName.SelectedItem == null || selectedDate == null)
            {
                lblErrorMessage.Text = "Please fill in all details";
                lblErrorMessage.Visible = true;
                return false;
            }

            foreach(Kid kid in kids)
            {
                if(kid.Deleted == false)
                {
                    if(kid.Forename == txtChildForename.Text && kid.Surname == txtChildSurname.Text && kid.DateOfBirth == selectedDate && kid.ParentID == parentID)
                    {
                        lblErrorMessage.Text = "Child already exists";
                        lblErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetID()
        {
            List<Kid> kids = new List<Kid>();
            kids = kidDBA.getAllKids();
            int greatestID = 0;

            foreach(Kid kid in kids)
            {
                if(kid.ID > greatestID)
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

            if (txtChildParentName.Text == "")
            {
                foreach(Parent parent in allParents)
                {
                    if(parent.Deleted == false)
                    {
                        lstChildParentName.Items.Add(parent.Forename.Trim() + " " + parent.Surname.Trim());
                        selectedParentForename = parent.Forename.Trim();
                        selectedParentSurname = parent.Surname.Trim();
                        selectedParentID = parent.ID.ToString();
                        parentIDNamesList.Add(new List<string> { selectedParentForename, selectedParentSurname, selectedParentID });
                    }
                }
            }
        }
    }
}