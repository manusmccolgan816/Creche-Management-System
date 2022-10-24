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
    public partial class AddParent : Form 
    {
        Database db;
        ParentDBAccess parentDBA;
        List<int> allInts = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        List<char> alphabet = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public AddParent(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
            parentDBA = new ParentDBAccess(db);
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

        private void btnSaveAndAddChild_MouseEnter(object sender, EventArgs e)
        {
            btnSaveAndAddChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnSaveAndAddChild_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndAddChild.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnSaveParent_MouseEnter(object sender, EventArgs e)
        {
            btnSaveParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnSaveParent_MouseLeave(object sender, EventArgs e)
        {
            btnSaveParent.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Button clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnSaveParent_Click(object sender, EventArgs e)
        {
            if(SaveParent())
            {
                txtParentForename.Text = "";
                txtParentSurname.Text = "";
                txtParentTelNo.Text = "";
                txtParentCity.Text = "";
                txtParentPostcode.Text = "";
                txtParentAddress.Text = "";
            }
        }

        private void btnSaveAndAddChild_Click(object sender, EventArgs e)
        {
            if (SaveParent())
            {
                this.Hide();
                Form FormObject = new AddChild(db, txtParentForename.Text + " " + txtParentSurname.Text);
                FormObject.Show();
            }
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
        private void txtParentForename_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtParentSurname_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtParentTelNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
                lblTelNoErrorMessage.Visible = true;
            }
            else
            {
                lblTelNoErrorMessage.Visible = false;
            }
        }

        private void txtParentCity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Microsoft key enumeration code for backspace is 8
            {
                e.Handled = true;
                lblCityErrorMessage.Visible = true;
            }
            else
            {
                lblCityErrorMessage.Visible = false;
            }
        }
        #endregion
        #endregion

        public bool SaveParent()
        {
            Parent newParent = new Objects.Parent();

            if (SaveParentValidation())
            {
                lblErrorMessage.Visible = false;
                lblForenameErrorMessage.Visible = false;
                lblSurnameErrorMessage.Visible = false;
                lblTelNoErrorMessage.Visible = false;
                lblCityErrorMessage.Visible = false;
                newParent.ID = GetID();
                newParent.Forename = txtParentForename.Text;
                newParent.Surname = txtParentSurname.Text;
                newParent.TelNo = txtParentTelNo.Text;
                newParent.City = txtParentCity.Text;
                newParent.Postcode = txtParentPostcode.Text;
                newParent.Address = txtParentAddress.Text;
                newParent.Deleted = false;
                parentDBA.addParent(newParent);

                MessageBox.Show("Parent added");

                return true;
            }
            return false;
        }

        public bool SaveParentValidation()
        {
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();

            if (txtParentForename.Text == "" || txtParentSurname.Text == "" || txtParentTelNo.Text == "" || txtParentCity.Text == ""
                || txtParentPostcode.Text == "" || txtParentAddress.Text == "")
            {
                lblErrorMessage.Text = "Please fill in every box";
                lblErrorMessage.Visible = true;
                return false;
            }

            if(txtParentPostcode.Text.Length < 5)
            {
                lblErrorMessage.Text = "Postcode does not exist";
                lblErrorMessage.Visible = true;
                return false;
            }

            if(txtParentTelNo.Text.Length < 8)
            {
                lblErrorMessage.Text = "Phone number is too short";
                lblErrorMessage.Visible = true;
                return false;
            }

            foreach(Parent parent in parents)
            {
                if(parent.Deleted == false)
                {
                    if (parent.Forename == txtParentForename.Text && parent.Surname == txtParentSurname.Text && parent.TelNo == txtParentTelNo.Text && parent.City == txtParentCity.Text
                        && parent.Postcode == txtParentPostcode.Text && parent.Address == txtParentAddress.Text)
                    {
                        lblErrorMessage.Text = "Parent already exists";
                        lblErrorMessage.Visible = true;
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetID()
        {
            List<Parent> parents = new List<Parent>();
            parents = parentDBA.getAllParents();
            int greatestID = 0;

            foreach(Parent parent in parents)
            {
                if(parent.ID > greatestID)
                {
                    greatestID = parent.ID;
                }
            }
            greatestID++;
            return greatestID;
        }
    }
}