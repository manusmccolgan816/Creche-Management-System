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
    public partial class MainMenu : Form
    {
        Database db = new Database();

        public MainMenu()
        {
            InitializeComponent();
            this.CenterToScreen();

            if (!db.ConnectionOpen())
            {
                MessageBox.Show("Connection unsuccessful");
            }
            else
            {

            }
        }

        #region Control interaction
        #region User feedback
        private void btnCreche_MouseEnter(object sender, EventArgs e)
        {
            btnCreche.ForeColor = System.Drawing.Color.HotPink;

        }
        private void btnCreche_MouseLeave(object sender, EventArgs e)
        {
            btnCreche.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnTransport_MouseEnter(object sender, EventArgs e)
        {
            btnTransport.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnTransport_MouseLeave(object sender, EventArgs e)
        {
            btnTransport.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnClasses_MouseEnter(object sender, EventArgs e)
        {
            btnClasses.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnClasses_MouseLeave(object sender, EventArgs e)
        {
            btnClasses.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnAfterSchoolClub_MouseEnter(object sender, EventArgs e)
        {
            btnAfterSchoolClub.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnAfterSchoolClub_MouseLeave(object sender, EventArgs e)
        {
            btnAfterSchoolClub.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnAdvice_MouseEnter(object sender, EventArgs e)
        {
            btnAdvice.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnAdvice_MouseLeave(object sender, EventArgs e)
        {
            btnAdvice.ForeColor = System.Drawing.Color.Turquoise;
        }

        private void btnGroups_MouseEnter(object sender, EventArgs e)
        {
            btnGroups.ForeColor = System.Drawing.Color.HotPink;
        }

        private void btnGroups_MouseLeave(object sender, EventArgs e)
        {
            btnGroups.ForeColor = System.Drawing.Color.Turquoise;
        }
        #endregion

        #region Button clicks
        private void btnCreche_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormObject = new CrecheMenuScreen(db);
            FormObject.Show();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void btnAfterSchoolClub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void btnAdvice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not covered this aspect of the case study as I only had time to implement the crèche subsystem");
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
        #endregion
    }
}
