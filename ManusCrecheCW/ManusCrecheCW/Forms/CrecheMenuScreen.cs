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

namespace ManusCrecheCW
{
    public partial class CrecheMenuScreen : Form
    {
        Database db;

        public CrecheMenuScreen(Database Db)
        {
            InitializeComponent();
            this.CenterToScreen();
            db = Db;
        }

        #region Control interaction
        #region User feedback
        private void btnBooking_MouseEnter(object sender, EventArgs e)
        {
            btnAddBooking.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnBooking_MouseLeave(object sender, EventArgs e)
        {
            btnAddBooking.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnViewData_MouseEnter(object sender, EventArgs e)
        {
            btnViewData.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnViewData_MouseLeave(object sender, EventArgs e)
        {
            btnViewData.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnEditStaff_MouseEnter(object sender, EventArgs e)
        {
            btnAssignStaff.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnEditStaff_MouseLeave(object sender, EventArgs e)
        {
            btnAssignStaff.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnAddParent_MouseEnter(object sender, EventArgs e)
        {
            btnAddParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnAddParent_MouseLeave(object sender, EventArgs e)
        {
            btnAddParent.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnAddChild_MouseEnter(object sender, EventArgs e)
        {
            btnAddChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnAddChild_MouseLeave(object sender, EventArgs e)
        {
            btnAddChild.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnAddStaff_MouseEnter(object sender, EventArgs e)
        {
            btnAddStaff.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnAddStaff_MouseLeave(object sender, EventArgs e)
        {
            btnAddStaff.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnEditBooking_MouseEnter(object sender, EventArgs e)
        {
            btnEditBooking.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnEditBooking_MouseLeave(object sender, EventArgs e)
        {
            btnEditBooking.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnEditParent_MouseEnter(object sender, EventArgs e)
        {
            btnEditParent.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnEditParent_MouseLeave(object sender, EventArgs e)
        {
            btnEditParent.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnEditChild_MouseEnter(object sender, EventArgs e)
        {
            btnEditChild.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnEditChild_MouseLeave(object sender, EventArgs e)
        {
            btnEditChild.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnEditStaff_MouseEnter_1(object sender, EventArgs e)
        {
            btnEditStaff.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnEditStaff_MouseLeave_1(object sender, EventArgs e)
        {
            btnEditStaff.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            btnReport.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            btnReport.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Clicks
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new MainMenu();
            FormObject.Show();
        }

        private void btnCodeComplexities_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("A2 Code Complexities.docx");
        }

        #region Add
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new BookingSelectChildForm(db);
            FormObject.Show();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AddParent(db);
            FormObject.Show();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AddChild(db);
            FormObject.Show();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality has not been added due to the fact that the same skills were shown elsewhere");
        }
        #endregion

        #region Edit
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteBooking(db);
            FormObject.Show();
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteParent(db);
            FormObject.Show();
        }

        private void btnEditChild_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new EditDeleteChild(db);
            FormObject.Show();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality has not been added due to the fact that the same skills were shown elsewhere");
        }
        #endregion

        #region Other
        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new AssignStaffForm(db);
            FormObject.Show();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new ViewDataForm(db);
            FormObject.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new ReportForm(db);
            FormObject.Show();
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
        #endregion
    }
}