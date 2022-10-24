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
    public partial class AssignStaffForm : Form
    {
        Database db;
        StaffDBAccess staffDBA;
        StaffGroupDBAccess staffGroupDBA;
        List<List<string>> group1DatesAndStaffMembers = new List<List<string>>();
        List<List<string>> group2DatesAndStaffMembers = new List<List<string>>();
        List<List<string>> group3DatesAndStaffMembers = new List<List<string>>();
        List<string> alreadyUsedStaff = new List<string>();
        List<Staff> staffMembers = new List<Staff>();
        int staffID11;
        int staffID12;
        int staffID21;
        int staffID22;
        int staffID31;
        int staffID32;

        public AssignStaffForm(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();

            db = Db;
            staffDBA = new StaffDBAccess(db);
            staffGroupDBA = new StaffGroupDBAccess(db);
            calDate.MinDate = DateTime.Now;
            staffMembers = staffDBA.getAllStaff();

            PopulateComboBoxes();
            CheckShifts();
        }

        #region Control interaction
        #region Buttons
        #region User feedback
        private void btnGroup1Assign_MouseEnter(object sender, EventArgs e)
        {
            btnGroup1Assign.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnGroup1Assign_MouseLeave(object sender, EventArgs e)
        {
            btnGroup1Assign.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnGroup2Assign_MouseEnter(object sender, EventArgs e)
        {
            btnGroup2Assign.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnGroup2Assign_MouseLeave(object sender, EventArgs e)
        {
            btnGroup2Assign.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnGroup3Assign_MouseEnter(object sender, EventArgs e)
        {
            btnGroup3Assign.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnGroup3Assign_MouseLeave(object sender, EventArgs e)
        {
            btnGroup3Assign.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnGroup1Assign_Click(object sender, EventArgs e)
        {
            if (AssignStaffValidation1())
            {
                StaffGroup newStaffGroup = new Objects.StaffGroup();
                lblErrorMessage1.Visible = false;

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID11;
                newStaffGroup.GroupID = 1;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID12;
                newStaffGroup.GroupID = 1;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                panGroup1.Enabled = false;
            }
        }

        private void btnGroup2Assign_Click(object sender, EventArgs e)
        {
            if (AssignStaffValidation2())
            {
                StaffGroup newStaffGroup = new Objects.StaffGroup();
                lblErrorMessage2.Visible = false;

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID21;
                newStaffGroup.GroupID = 2;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID22;
                newStaffGroup.GroupID = 2;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                panGroup2.Enabled = false;
            }
        }

        private void btnGroup3Assign_Click(object sender, EventArgs e)
        {
            if (AssignStaffValidation3())
            {
                StaffGroup newStaffGroup = new Objects.StaffGroup();
                lblErrorMessage3.Visible = false;

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID31;
                newStaffGroup.GroupID = 3;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                newStaffGroup.ID = GetStaffGroupID();
                newStaffGroup.StaffID = staffID32;
                newStaffGroup.GroupID = 3;
                newStaffGroup.Date = calDate.SelectionStart.ToString("dd-MM-yyyy");

                staffGroupDBA.addStaffGroup(newStaffGroup);

                panGroup3.Enabled = false;
            }
        }

        private void picGroup1Staff1_Click(object sender, EventArgs e)
        {
            cmbGroup1Staff1.SelectedIndex = -1;
            CheckSelectedStaff(11);
        }

        private void picGroup1Staff2_Click(object sender, EventArgs e)
        {
            cmbGroup1Staff2.SelectedIndex = -1;
            CheckSelectedStaff(12);
        }

        private void picGroup2Staff1_Click(object sender, EventArgs e)
        {
            cmbGroup2Staff1.SelectedIndex = -1;
            CheckSelectedStaff(21);
        }

        private void picGroup2Staff2_Click(object sender, EventArgs e)
        {
            cmbGroup2Staff2.SelectedIndex = -1;
            CheckSelectedStaff(22);
        }

        private void picGroup3Staff1_Click(object sender, EventArgs e)
        {
            cmbGroup3Staff1.SelectedIndex = -1;
            CheckSelectedStaff(31);
        }

        private void picGroup3Staff2_Click(object sender, EventArgs e)
        {
            cmbGroup3Staff2.SelectedIndex = -1;
            CheckSelectedStaff(32);
        }
        #endregion
        #endregion

        #region Menu strip
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
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("User Guide.docx");
        }

        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            cmbGroup1Staff1.Items.Clear();
            cmbGroup1Staff2.Items.Clear();
            cmbGroup2Staff1.Items.Clear();
            cmbGroup2Staff2.Items.Clear();
            cmbGroup3Staff1.Items.Clear();
            cmbGroup3Staff2.Items.Clear();
            PopulateComboBoxes();
            CheckShifts();
        }

        private void cmbGroup1Staff1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGroup1Staff1.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup1Staff1.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID11 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup1Staff1.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff2.Items.Count; i++)
                        {
                            if (cmbGroup1Staff2.Items[i].ToString() == cmbGroup1Staff1.SelectedItem.ToString())
                            {
                                cmbGroup1Staff2.Items.Remove(cmbGroup1Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff1.Items.Count; i++)
                        {
                            if (cmbGroup2Staff1.Items[i].ToString() == cmbGroup1Staff1.SelectedItem.ToString())
                            {
                                cmbGroup2Staff1.Items.Remove(cmbGroup1Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff2.Items.Count; i++)
                        {
                            if (cmbGroup2Staff2.Items[i].ToString() == cmbGroup1Staff1.SelectedItem.ToString())
                            {
                                cmbGroup2Staff2.Items.Remove(cmbGroup1Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff1.Items.Count; i++)
                        {
                            if (cmbGroup3Staff1.Items[i].ToString() == cmbGroup1Staff1.SelectedItem.ToString())
                            {
                                cmbGroup3Staff1.Items.Remove(cmbGroup1Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff2.Items.Count; i++)
                        {
                            if (cmbGroup3Staff2.Items[i].ToString() == cmbGroup1Staff1.SelectedItem.ToString())
                            {
                                cmbGroup3Staff2.Items.Remove(cmbGroup1Staff1.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(11);
            }
        }

        private void cmbGroup1Staff2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup1Staff2.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup1Staff2.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID12 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup1Staff2.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff1.Items.Count; i++)
                        {
                            if (cmbGroup1Staff1.Items[i].ToString() == cmbGroup1Staff2.SelectedItem.ToString())
                            {
                                cmbGroup1Staff1.Items.Remove(cmbGroup1Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff1.Items.Count; i++)
                        {
                            if (cmbGroup2Staff1.Items[i].ToString() == cmbGroup1Staff2.SelectedItem.ToString())
                            {
                                cmbGroup2Staff1.Items.Remove(cmbGroup1Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff2.Items.Count; i++)
                        {
                            if (cmbGroup2Staff2.Items[i].ToString() == cmbGroup1Staff2.SelectedItem.ToString())
                            {
                                cmbGroup2Staff2.Items.Remove(cmbGroup1Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff1.Items.Count; i++)
                        {
                            if (cmbGroup3Staff1.Items[i].ToString() == cmbGroup1Staff2.SelectedItem.ToString())
                            {
                                cmbGroup3Staff1.Items.Remove(cmbGroup1Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff2.Items.Count; i++)
                        {
                            if (cmbGroup3Staff2.Items[i].ToString() == cmbGroup1Staff2.SelectedItem.ToString())
                            {
                                cmbGroup3Staff2.Items.Remove(cmbGroup1Staff2.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(12);
            }
        }

        private void cmbGroup2Staff1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGroup2Staff1.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup2Staff1.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID21 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup2Staff1.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff1.Items.Count; i++)
                        {
                            if (cmbGroup1Staff1.Items[i].ToString() == cmbGroup2Staff1.SelectedItem.ToString())
                            {
                                cmbGroup1Staff1.Items.Remove(cmbGroup2Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup1Staff2.Items.Count; i++)
                        {
                            if (cmbGroup1Staff2.Items[i].ToString() == cmbGroup2Staff1.SelectedItem.ToString())
                            {
                                cmbGroup1Staff2.Items.Remove(cmbGroup2Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff2.Items.Count; i++)
                        {
                            if (cmbGroup2Staff2.Items[i].ToString() == cmbGroup2Staff1.SelectedItem.ToString())
                            {
                                cmbGroup2Staff2.Items.Remove(cmbGroup2Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff1.Items.Count; i++)
                        {
                            if (cmbGroup3Staff1.Items[i].ToString() == cmbGroup2Staff1.SelectedItem.ToString())
                            {
                                cmbGroup3Staff1.Items.Remove(cmbGroup2Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff2.Items.Count; i++)
                        {
                            if (cmbGroup3Staff2.Items[i].ToString() == cmbGroup2Staff1.SelectedItem.ToString())
                            {
                                cmbGroup3Staff2.Items.Remove(cmbGroup2Staff1.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(21);
            }
        }

        private void cmbGroup2Staff2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGroup2Staff2.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup2Staff2.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID22 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup2Staff2.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff1.Items.Count; i++)
                        {
                            if (cmbGroup1Staff1.Items[i].ToString() == cmbGroup2Staff2.SelectedItem.ToString())
                            {
                                cmbGroup1Staff1.Items.Remove(cmbGroup2Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup1Staff2.Items.Count; i++)
                        {
                            if (cmbGroup1Staff2.Items[i].ToString() == cmbGroup2Staff2.SelectedItem.ToString())
                            {
                                cmbGroup1Staff2.Items.Remove(cmbGroup2Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff1.Items.Count; i++)
                        {
                            if (cmbGroup2Staff1.Items[i].ToString() == cmbGroup2Staff2.SelectedItem.ToString())
                            {
                                cmbGroup2Staff1.Items.Remove(cmbGroup2Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff1.Items.Count; i++)
                        {
                            if (cmbGroup3Staff1.Items[i].ToString() == cmbGroup2Staff2.SelectedItem.ToString())
                            {
                                cmbGroup3Staff1.Items.Remove(cmbGroup2Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff2.Items.Count; i++)
                        {
                            if (cmbGroup3Staff2.Items[i].ToString() == cmbGroup2Staff2.SelectedItem.ToString())
                            {
                                cmbGroup3Staff2.Items.Remove(cmbGroup2Staff2.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(22);
            }
        }

        private void cmbGroup3Staff1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGroup3Staff1.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup3Staff1.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID31 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup3Staff1.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff1.Items.Count; i++)
                        {
                            if (cmbGroup1Staff1.Items[i].ToString() == cmbGroup3Staff1.SelectedItem.ToString())
                            {
                                cmbGroup1Staff1.Items.Remove(cmbGroup3Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup1Staff2.Items.Count; i++)
                        {
                            if (cmbGroup1Staff2.Items[i].ToString() == cmbGroup3Staff1.SelectedItem.ToString())
                            {
                                cmbGroup1Staff2.Items.Remove(cmbGroup3Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff1.Items.Count; i++)
                        {
                            if (cmbGroup2Staff1.Items[i].ToString() == cmbGroup3Staff1.SelectedItem.ToString())
                            {
                                cmbGroup2Staff1.Items.Remove(cmbGroup3Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff2.Items.Count; i++)
                        {
                            if (cmbGroup2Staff2.Items[i].ToString() == cmbGroup3Staff1.SelectedItem.ToString())
                            {
                                cmbGroup2Staff2.Items.Remove(cmbGroup3Staff1.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff2.Items.Count; i++)
                        {
                            if (cmbGroup3Staff2.Items[i].ToString() == cmbGroup3Staff1.SelectedItem.ToString())
                            {
                                cmbGroup3Staff2.Items.Remove(cmbGroup3Staff1.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(31);
            }
        }

        private void cmbGroup3Staff2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup3Staff2.SelectedIndex != -1)
            {
                foreach (Staff staffMember in staffMembers)
                {
                    if (cmbGroup3Staff2.SelectedItem.ToString() == staffMember.Forename.Trim() + " " + staffMember.Surname.Trim())
                    {
                        staffID32 = staffMember.ID;
                        alreadyUsedStaff.Add(cmbGroup3Staff2.SelectedItem.ToString());

                        for (int i = 0; i < cmbGroup1Staff1.Items.Count; i++)
                        {
                            if (cmbGroup1Staff1.Items[i].ToString() == cmbGroup3Staff2.SelectedItem.ToString())
                            {
                                cmbGroup1Staff1.Items.Remove(cmbGroup3Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup1Staff2.Items.Count; i++)
                        {
                            if (cmbGroup1Staff2.Items[i].ToString() == cmbGroup3Staff2.SelectedItem.ToString())
                            {
                                cmbGroup1Staff2.Items.Remove(cmbGroup3Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff1.Items.Count; i++)
                        {
                            if (cmbGroup2Staff1.Items[i].ToString() == cmbGroup3Staff2.SelectedItem.ToString())
                            {
                                cmbGroup2Staff1.Items.Remove(cmbGroup3Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup2Staff2.Items.Count; i++)
                        {
                            if (cmbGroup2Staff2.Items[i].ToString() == cmbGroup3Staff2.SelectedItem.ToString())
                            {
                                cmbGroup2Staff2.Items.Remove(cmbGroup3Staff2.SelectedItem);
                            }
                        }
                        for (int i = 0; i < cmbGroup3Staff1.Items.Count; i++)
                        {
                            if (cmbGroup3Staff1.Items[i].ToString() == cmbGroup3Staff2.SelectedItem.ToString())
                            {
                                cmbGroup3Staff1.Items.Remove(cmbGroup3Staff2.SelectedItem);
                            }
                        }
                    }
                }
                CheckSelectedStaff(32);
            }
        }
        #endregion
        #endregion

        public void CheckSelectedStaff(int CmbNumber)
        {
            bool stringoMet;
            List<string> alreadyUsedStaffNewlyRemoved = new List<string>();

            foreach(string stringo in alreadyUsedStaff)
            {
                stringoMet = false;

                if(cmbGroup1Staff1.SelectedItem != null)
                {
                    if (cmbGroup1Staff1.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }

                if(cmbGroup1Staff2.SelectedItem != null)
                {
                    if (cmbGroup1Staff2.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }

                if(cmbGroup2Staff1.SelectedItem != null)
                {
                    if (cmbGroup2Staff1.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }
           
                if(cmbGroup2Staff2.SelectedItem != null)
                {
                    if (cmbGroup2Staff2.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }

                if(cmbGroup3Staff1.SelectedItem != null)
                {
                    if (cmbGroup3Staff1.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }

                if(cmbGroup3Staff2.SelectedItem != null)
                {
                    if (cmbGroup3Staff2.SelectedItem.ToString() == stringo)
                    {
                        stringoMet = true;
                    }
                }
             

                if (stringoMet == false)
                {
                    alreadyUsedStaffNewlyRemoved.Add(stringo);
                }
            }

            foreach(string stringo1 in alreadyUsedStaffNewlyRemoved)
            {
                alreadyUsedStaff.Remove(stringo1);
                if(CmbNumber != 11)
                {
                    cmbGroup1Staff1.Items.Add(stringo1);
                }
                if (CmbNumber != 12)
                {
                    cmbGroup1Staff2.Items.Add(stringo1);
                }
                if (CmbNumber != 21)
                {
                    cmbGroup2Staff1.Items.Add(stringo1);
                }
                if (CmbNumber != 22)
                {
                    cmbGroup2Staff2.Items.Add(stringo1);
                }
                if (CmbNumber != 31)
                {
                    cmbGroup3Staff1.Items.Add(stringo1);
                }
                if (CmbNumber != 32)
                {
                    cmbGroup3Staff2.Items.Add(stringo1);
                }
            }
        }

        public void CheckShifts()
        {
            int[] groupStaffCounter = new int[3];

            if(calDate.SelectionStart.Date.DayOfWeek != DayOfWeek.Saturday && calDate.SelectionStart.Date.DayOfWeek != DayOfWeek.Sunday)
            {
                List<StaffGroup> staffGroups = new List<StaffGroup>();
                staffGroups = staffGroupDBA.getAllStaffGroups();

                lblErrorMessage1.Visible = false;
                lblErrorMessage2.Visible = false;
                lblErrorMessage3.Visible = false;
                panGroup1.Enabled = true;
                panGroup2.Enabled = true;
                panGroup3.Enabled = true;

                foreach (StaffGroup staffGroup in staffGroups)
                {
                    if (staffGroup.Date == calDate.SelectionStart.ToString("dd-MM-yyyy"))
                    {
                        if (staffGroup.GroupID == 1)
                        {
                            groupStaffCounter[0]++;
                        }
                        else if (staffGroup.GroupID == 2)
                        {
                            groupStaffCounter[1]++;
                        }
                        else if (staffGroup.GroupID == 3)
                        {
                            groupStaffCounter[2]++;
                        }
                    }
                }

                if (groupStaffCounter[0] >= 2)
                {
                    panGroup1.Enabled = false;
                }
                if (groupStaffCounter[1] >= 2)
                {
                    panGroup2.Enabled = false;
                }
                if (groupStaffCounter[2] >= 2)
                {
                    panGroup3.Enabled = false;
                }

                if(panGroup1.Enabled == true && panGroup2.Enabled == true && panGroup3.Enabled == true)
                {
                    alreadyUsedStaff.Clear();
                }
            }
            else
            {
                panGroup1.Enabled = false;
                panGroup2.Enabled = false;
                panGroup3.Enabled = false;
            }
        }

        public void PopulateComboBoxes()
        {
            int staffMemberCounter = 0;
            List<StaffGroup> staffGroups = new List<StaffGroup>();
            staffGroups = staffGroupDBA.getAllStaffGroups();
            alreadyUsedStaff.Clear();

            foreach (Staff staffMember in staffMembers)
            {
                cmbGroup1Staff1.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                cmbGroup1Staff2.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                cmbGroup2Staff1.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                cmbGroup2Staff2.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                cmbGroup3Staff1.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                cmbGroup3Staff2.Items.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                foreach (StaffGroup staffGroup in staffGroups)
                {
                    if(staffGroup.Date == calDate.SelectionStart.ToString("dd-MM-yyyy"))
                    {
                        if(staffMember.ID == staffGroup.StaffID)
                        {
                            if (staffGroup.GroupID == 1)
                            {
                                if(staffMemberCounter % 2 == 0) //If number is even
                                {
                                    cmbGroup1Staff1.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                else
                                {
                                    cmbGroup1Staff2.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                cmbGroup2Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup2Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup3Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup3Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                alreadyUsedStaff.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                            }
                            else if (staffGroup.GroupID == 2)
                            {
                                if (staffMemberCounter % 2 == 0) //If number is even
                                {
                                    cmbGroup2Staff1.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                else
                                {
                                    cmbGroup2Staff2.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                cmbGroup1Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup1Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup3Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup3Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                alreadyUsedStaff.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                            }
                            else if (staffGroup.GroupID == 3)
                            {
                                if (staffMemberCounter % 2 == 0) //If number is even
                                {
                                    cmbGroup3Staff1.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                else
                                {
                                    cmbGroup3Staff2.SelectedItem = (staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                }
                                cmbGroup1Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup1Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup2Staff1.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                cmbGroup2Staff2.Items.Remove(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                                alreadyUsedStaff.Add(staffMember.Forename.Trim() + " " + staffMember.Surname.Trim());
                            }
                            staffMemberCounter++;
                        }                      
                    }
                }
            }
        }

        public bool AssignStaffValidation1()
        {
            try
            {
                if (cmbGroup1Staff1.SelectedItem.ToString() == cmbGroup1Staff2.SelectedItem.ToString() || cmbGroup1Staff1.Text == "" || cmbGroup1Staff2.Text == "")
                {
                    lblErrorMessage1.Text = "Please select two\ndifferent staff members";
                    lblErrorMessage1.Visible = true;
                    return false;
                }
            }
            catch //If object reference error is thrown, it means that there is no selected index for at least one of the combo boxes, meaning that the error message must be shown
            {
                lblErrorMessage1.Text = "Please select two\ndifferent staff members";
                lblErrorMessage1.Visible = true;
                return false;
            }
            return true;
        }

        public bool AssignStaffValidation2()
        {
            try
            {
                if (cmbGroup2Staff1.SelectedItem.ToString() == cmbGroup2Staff2.SelectedItem.ToString() || cmbGroup2Staff1.Text == "" || cmbGroup2Staff2.Text == "")
                {
                    lblErrorMessage2.Text = "Please select two\ndifferent staff members";
                    lblErrorMessage2.Visible = true;
                    return false;
                }
            }
            catch //If object reference error is thrown, it means that there is no selected index for at least one of the combo boxes, meaning that the error message must be shown
            {
                lblErrorMessage2.Text = "Please select two\ndifferent staff members";
                lblErrorMessage2.Visible = true;
                return false;
            }
            return true;
        }

        public bool AssignStaffValidation3()
        {
            try
            {
                if (cmbGroup3Staff1.SelectedItem.ToString() == cmbGroup3Staff2.SelectedItem.ToString() || cmbGroup3Staff1.Text == "" || cmbGroup3Staff2.Text == "")
                {
                    lblErrorMessage3.Text = "Please select two\ndifferent staff members";
                    lblErrorMessage3.Visible = true;
                    return false;
                }
            }
            catch //If object reference error is thrown, it means that there is no selected index for at least one of the combo boxes, meaning that the error message must be shown
            {
                lblErrorMessage3.Text = "Please select two\ndifferent staff members";
                lblErrorMessage3.Visible = true;
                return false;
            }
            return true;
        }

        public int GetStaffGroupID()
        {
            List<StaffGroup> staffGroups = new List<StaffGroup>();
            staffGroups = staffGroupDBA.getAllStaffGroups();
            int greatestID = 0;

            foreach (StaffGroup staffGroup in staffGroups)
            {
                if (staffGroup.ID > greatestID)
                {
                    greatestID = staffGroup.ID;
                }
            }
            greatestID++;
            return greatestID;
        }
    }
}