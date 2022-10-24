namespace ManusCrecheCW.Forms
{
    partial class BookingSelectDatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panSelectBookingDates = new System.Windows.Forms.Panel();
            this.lblChildName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblChildGroupID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBookingDuration = new System.Windows.Forms.Label();
            this.lblDaysBooked = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstSelectedBookedOutDates = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.men1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crecheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAndDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afterSchoolClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panSelectBookingDates.SuspendLayout();
            this.men1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select Booking Dates";
            // 
            // calStartDate
            // 
            this.calStartDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calStartDate.Location = new System.Drawing.Point(23, 86);
            this.calStartDate.Margin = new System.Windows.Forms.Padding(7);
            this.calStartDate.MaxSelectionCount = 1;
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.TabIndex = 38;
            this.calStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStartDate_DateChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCheckout.Location = new System.Drawing.Point(687, 449);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(110, 50);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.MouseEnter += new System.EventHandler(this.btnContinue_MouseEnter);
            this.btnCheckout.MouseLeave += new System.EventHandler(this.btnContinue_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Turquoise;
            this.label8.Location = new System.Drawing.Point(19, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(492, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "End date:";
            // 
            // calEndDate
            // 
            this.calEndDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calEndDate.Location = new System.Drawing.Point(496, 86);
            this.calEndDate.Margin = new System.Windows.Forms.Padding(7);
            this.calEndDate.MaxSelectionCount = 1;
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.TabIndex = 41;
            this.calEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEndDate_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(296, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Days booked:";
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonday.ForeColor = System.Drawing.Color.Yellow;
            this.chkMonday.Location = new System.Drawing.Point(317, 86);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(94, 25);
            this.chkMonday.TabIndex = 44;
            this.chkMonday.TabStop = false;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;
            this.chkMonday.CheckedChanged += new System.EventHandler(this.chkMonday_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(39, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Booking duration:";
            // 
            // panSelectBookingDates
            // 
            this.panSelectBookingDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panSelectBookingDates.Controls.Add(this.lblChildName);
            this.panSelectBookingDates.Controls.Add(this.label11);
            this.panSelectBookingDates.Controls.Add(this.lblChildGroupID);
            this.panSelectBookingDates.Controls.Add(this.label9);
            this.panSelectBookingDates.Controls.Add(this.lblErrorMessage);
            this.panSelectBookingDates.Controls.Add(this.label7);
            this.panSelectBookingDates.Controls.Add(this.chkTuesday);
            this.panSelectBookingDates.Controls.Add(this.chkWednesday);
            this.panSelectBookingDates.Controls.Add(this.label1);
            this.panSelectBookingDates.Controls.Add(this.chkThursday);
            this.panSelectBookingDates.Controls.Add(this.calStartDate);
            this.panSelectBookingDates.Controls.Add(this.chkFriday);
            this.panSelectBookingDates.Controls.Add(this.label8);
            this.panSelectBookingDates.Controls.Add(this.calEndDate);
            this.panSelectBookingDates.Controls.Add(this.label2);
            this.panSelectBookingDates.Controls.Add(this.label3);
            this.panSelectBookingDates.Controls.Add(this.chkMonday);
            this.panSelectBookingDates.Location = new System.Drawing.Point(33, 28);
            this.panSelectBookingDates.Name = "panSelectBookingDates";
            this.panSelectBookingDates.Size = new System.Drawing.Size(742, 306);
            this.panSelectBookingDates.TabIndex = 50;
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildName.ForeColor = System.Drawing.Color.Turquoise;
            this.lblChildName.Location = new System.Drawing.Point(383, 15);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(131, 22);
            this.lblChildName.TabIndex = 60;
            this.lblChildName.Text = "Derek Swann";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Turquoise;
            this.label11.Location = new System.Drawing.Point(261, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 59;
            this.label11.Text = "Child name:";
            // 
            // lblChildGroupID
            // 
            this.lblChildGroupID.AutoSize = true;
            this.lblChildGroupID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildGroupID.ForeColor = System.Drawing.Color.Turquoise;
            this.lblChildGroupID.Location = new System.Drawing.Point(713, 15);
            this.lblChildGroupID.Name = "lblChildGroupID";
            this.lblChildGroupID.Size = new System.Drawing.Size(21, 22);
            this.lblChildGroupID.TabIndex = 58;
            this.lblChildGroupID.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Turquoise;
            this.label9.Location = new System.Drawing.Point(612, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 58;
            this.label9.Text = "Group ID:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(20, 255);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(125, 18);
            this.lblErrorMessage.TabIndex = 58;
            this.lblErrorMessage.Text = "lblErrorMessage";
            this.lblErrorMessage.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(19, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(634, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "* All emboldened dates are booked out and will not be counted in the booking *";
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuesday.ForeColor = System.Drawing.Color.Yellow;
            this.chkTuesday.Location = new System.Drawing.Point(317, 119);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(93, 25);
            this.chkTuesday.TabIndex = 54;
            this.chkTuesday.TabStop = false;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;
            this.chkTuesday.CheckedChanged += new System.EventHandler(this.chkTuesday_CheckedChanged);
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWednesday.ForeColor = System.Drawing.Color.Yellow;
            this.chkWednesday.Location = new System.Drawing.Point(317, 152);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(121, 25);
            this.chkWednesday.TabIndex = 53;
            this.chkWednesday.TabStop = false;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;
            this.chkWednesday.CheckedChanged += new System.EventHandler(this.chkWednesday_CheckedChanged);
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThursday.ForeColor = System.Drawing.Color.Yellow;
            this.chkThursday.Location = new System.Drawing.Point(317, 185);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(98, 25);
            this.chkThursday.TabIndex = 52;
            this.chkThursday.TabStop = false;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;
            this.chkThursday.CheckedChanged += new System.EventHandler(this.chkThursday_CheckedChanged);
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriday.ForeColor = System.Drawing.Color.Yellow;
            this.chkFriday.Location = new System.Drawing.Point(317, 218);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(75, 25);
            this.chkFriday.TabIndex = 51;
            this.chkFriday.TabStop = false;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;
            this.chkFriday.CheckedChanged += new System.EventHandler(this.chkFriday_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(39, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(39, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Days booked:";
            // 
            // lblBookingDuration
            // 
            this.lblBookingDuration.AutoSize = true;
            this.lblBookingDuration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDuration.ForeColor = System.Drawing.Color.Turquoise;
            this.lblBookingDuration.Location = new System.Drawing.Point(212, 363);
            this.lblBookingDuration.Name = "lblBookingDuration";
            this.lblBookingDuration.Size = new System.Drawing.Size(181, 22);
            this.lblBookingDuration.TabIndex = 53;
            this.lblBookingDuration.Text = "lblBookingDuration";
            // 
            // lblDaysBooked
            // 
            this.lblDaysBooked.AutoSize = true;
            this.lblDaysBooked.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysBooked.ForeColor = System.Drawing.Color.Turquoise;
            this.lblDaysBooked.Location = new System.Drawing.Point(178, 409);
            this.lblDaysBooked.Name = "lblDaysBooked";
            this.lblDaysBooked.Size = new System.Drawing.Size(144, 22);
            this.lblDaysBooked.TabIndex = 54;
            this.lblDaysBooked.Text = "lblDaysBooked";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Turquoise;
            this.lblTotalCost.Location = new System.Drawing.Point(142, 455);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(113, 22);
            this.lblTotalCost.TabIndex = 55;
            this.lblTotalCost.Text = "lblTotalCost";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Turquoise;
            this.btnReset.Location = new System.Drawing.Point(571, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Turquoise;
            this.btnHome.Location = new System.Drawing.Point(455, 449);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // lstSelectedBookedOutDates
            // 
            this.lstSelectedBookedOutDates.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedBookedOutDates.FormattingEnabled = true;
            this.lstSelectedBookedOutDates.ItemHeight = 16;
            this.lstSelectedBookedOutDates.Location = new System.Drawing.Point(687, 344);
            this.lstSelectedBookedOutDates.Name = "lstSelectedBookedOutDates";
            this.lstSelectedBookedOutDates.Size = new System.Drawing.Size(110, 100);
            this.lstSelectedBookedOutDates.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Turquoise;
            this.label10.Location = new System.Drawing.Point(496, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 44);
            this.label10.TabIndex = 60;
            this.label10.Text = "Unavailable dates\r\nof current booking:";
            // 
            // men1
            // 
            this.men1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.men1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.crecheToolStripMenuItem,
            this.transportToolStripMenuItem,
            this.afterSchoolClubToolStripMenuItem,
            this.adviceToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.classesToolStripMenuItem});
            this.men1.Location = new System.Drawing.Point(0, 0);
            this.men1.Name = "men1";
            this.men1.Size = new System.Drawing.Size(809, 25);
            this.men1.TabIndex = 61;
            this.men1.Text = "men1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // crecheToolStripMenuItem
            // 
            this.crecheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editAndDeleteToolStripMenuItem,
            this.assignStaffToolStripMenuItem,
            this.viewDataToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.crecheToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.crecheToolStripMenuItem.Name = "crecheToolStripMenuItem";
            this.crecheToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.crecheToolStripMenuItem.Text = "Crèche";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.parentToolStripMenuItem,
            this.childToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // parentToolStripMenuItem
            // 
            this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            this.parentToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.parentToolStripMenuItem.Text = "Parent";
            this.parentToolStripMenuItem.Click += new System.EventHandler(this.parentToolStripMenuItem_Click);
            // 
            // childToolStripMenuItem
            // 
            this.childToolStripMenuItem.Name = "childToolStripMenuItem";
            this.childToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.childToolStripMenuItem.Text = "Child";
            this.childToolStripMenuItem.Click += new System.EventHandler(this.childToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // editAndDeleteToolStripMenuItem
            // 
            this.editAndDeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem1,
            this.parentToolStripMenuItem1,
            this.childToolStripMenuItem1,
            this.staffToolStripMenuItem1});
            this.editAndDeleteToolStripMenuItem.Name = "editAndDeleteToolStripMenuItem";
            this.editAndDeleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editAndDeleteToolStripMenuItem.Text = "Edit and Delete";
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.bookingToolStripMenuItem1.Text = "Booking";
            this.bookingToolStripMenuItem1.Click += new System.EventHandler(this.bookingToolStripMenuItem1_Click);
            // 
            // parentToolStripMenuItem1
            // 
            this.parentToolStripMenuItem1.Name = "parentToolStripMenuItem1";
            this.parentToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.parentToolStripMenuItem1.Text = "Parent";
            this.parentToolStripMenuItem1.Click += new System.EventHandler(this.parentToolStripMenuItem1_Click);
            // 
            // childToolStripMenuItem1
            // 
            this.childToolStripMenuItem1.Name = "childToolStripMenuItem1";
            this.childToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.childToolStripMenuItem1.Text = "Child";
            this.childToolStripMenuItem1.Click += new System.EventHandler(this.childToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.staffToolStripMenuItem1.Text = "Staff";
            this.staffToolStripMenuItem1.Click += new System.EventHandler(this.staffToolStripMenuItem1_Click);
            // 
            // assignStaffToolStripMenuItem
            // 
            this.assignStaffToolStripMenuItem.Name = "assignStaffToolStripMenuItem";
            this.assignStaffToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.assignStaffToolStripMenuItem.Text = "Assign Staff";
            this.assignStaffToolStripMenuItem.Click += new System.EventHandler(this.assignStaffToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.transportToolStripMenuItem.Text = "Transport";
            this.transportToolStripMenuItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // afterSchoolClubToolStripMenuItem
            // 
            this.afterSchoolClubToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.afterSchoolClubToolStripMenuItem.Name = "afterSchoolClubToolStripMenuItem";
            this.afterSchoolClubToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.afterSchoolClubToolStripMenuItem.Text = "After School Club";
            this.afterSchoolClubToolStripMenuItem.Click += new System.EventHandler(this.afterSchoolClubToolStripMenuItem_Click);
            // 
            // adviceToolStripMenuItem
            // 
            this.adviceToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.adviceToolStripMenuItem.Name = "adviceToolStripMenuItem";
            this.adviceToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.adviceToolStripMenuItem.Text = "Advice";
            this.adviceToolStripMenuItem.Click += new System.EventHandler(this.adviceToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.ForeColor = System.Drawing.Color.Turquoise;
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // BookingSelectDatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.men1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstSelectedBookedOutDates);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDaysBooked);
            this.Controls.Add(this.lblBookingDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panSelectBookingDates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookingSelectDatesForm";
            this.Text = "WCH ~ Crèche ~ Booking Select Dates";
            this.panSelectBookingDates.ResumeLayout(false);
            this.panSelectBookingDates.PerformLayout();
            this.men1.ResumeLayout(false);
            this.men1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calStartDate;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panSelectBookingDates;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBookingDuration;
        private System.Windows.Forms.Label lblDaysBooked;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblChildGroupID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSelectedBookedOutDates;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.MenuStrip men1;
        private System.Windows.Forms.ToolStripMenuItem crecheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAndDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem childToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assignStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afterSchoolClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}