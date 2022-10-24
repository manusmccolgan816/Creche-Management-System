namespace ManusCrecheCW.Forms
{
    partial class ViewDataForm
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
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panSelectTable = new System.Windows.Forms.Panel();
            this.radBookedOut = new System.Windows.Forms.RadioButton();
            this.radStaff = new System.Windows.Forms.RadioButton();
            this.radStaffGroup = new System.Windows.Forms.RadioButton();
            this.radGroup = new System.Windows.Forms.RadioButton();
            this.radBooking = new System.Windows.Forms.RadioButton();
            this.radKid = new System.Windows.Forms.RadioButton();
            this.radParent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.men1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reoprtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afterSchoolClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.panSelectTable.SuspendLayout();
            this.men1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            this.dgvTables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTables.Location = new System.Drawing.Point(22, 132);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(765, 282);
            this.dgvTables.TabIndex = 5;
            this.dgvTables.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Turquoise;
            this.btnBack.Location = new System.Drawing.Point(12, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // panSelectTable
            // 
            this.panSelectTable.Controls.Add(this.radBookedOut);
            this.panSelectTable.Controls.Add(this.radStaff);
            this.panSelectTable.Controls.Add(this.radStaffGroup);
            this.panSelectTable.Controls.Add(this.radGroup);
            this.panSelectTable.Controls.Add(this.radBooking);
            this.panSelectTable.Controls.Add(this.radKid);
            this.panSelectTable.Controls.Add(this.radParent);
            this.panSelectTable.Location = new System.Drawing.Point(123, 75);
            this.panSelectTable.Margin = new System.Windows.Forms.Padding(2);
            this.panSelectTable.Name = "panSelectTable";
            this.panSelectTable.Size = new System.Drawing.Size(641, 38);
            this.panSelectTable.TabIndex = 8;
            // 
            // radBookedOut
            // 
            this.radBookedOut.AutoSize = true;
            this.radBookedOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBookedOut.ForeColor = System.Drawing.Color.Yellow;
            this.radBookedOut.Location = new System.Drawing.Point(254, 7);
            this.radBookedOut.Margin = new System.Windows.Forms.Padding(2);
            this.radBookedOut.Name = "radBookedOut";
            this.radBookedOut.Size = new System.Drawing.Size(115, 24);
            this.radBookedOut.TabIndex = 17;
            this.radBookedOut.Text = "Booked Out";
            this.radBookedOut.UseVisualStyleBackColor = true;
            this.radBookedOut.CheckedChanged += new System.EventHandler(this.radBookedOut_CheckedChanged_1);
            this.radBookedOut.MouseEnter += new System.EventHandler(this.radBookedOut_MouseEnter_1);
            this.radBookedOut.MouseLeave += new System.EventHandler(this.radBookedOut_MouseLeave_1);
            // 
            // radStaff
            // 
            this.radStaff.AutoSize = true;
            this.radStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStaff.ForeColor = System.Drawing.Color.Yellow;
            this.radStaff.Location = new System.Drawing.Point(565, 7);
            this.radStaff.Margin = new System.Windows.Forms.Padding(2);
            this.radStaff.Name = "radStaff";
            this.radStaff.Size = new System.Drawing.Size(59, 24);
            this.radStaff.TabIndex = 12;
            this.radStaff.Text = "Staff";
            this.radStaff.UseVisualStyleBackColor = true;
            this.radStaff.CheckedChanged += new System.EventHandler(this.radStaff_CheckedChanged_1);
            this.radStaff.MouseEnter += new System.EventHandler(this.radStaff_MouseEnter_1);
            this.radStaff.MouseLeave += new System.EventHandler(this.radStaff_MouseLeave_1);
            // 
            // radStaffGroup
            // 
            this.radStaffGroup.AutoSize = true;
            this.radStaffGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStaffGroup.ForeColor = System.Drawing.Color.Yellow;
            this.radStaffGroup.Location = new System.Drawing.Point(451, 7);
            this.radStaffGroup.Margin = new System.Windows.Forms.Padding(2);
            this.radStaffGroup.Name = "radStaffGroup";
            this.radStaffGroup.Size = new System.Drawing.Size(110, 24);
            this.radStaffGroup.TabIndex = 13;
            this.radStaffGroup.Text = "Staff Group";
            this.radStaffGroup.UseVisualStyleBackColor = true;
            this.radStaffGroup.CheckedChanged += new System.EventHandler(this.radStaffGroup_CheckedChanged_1);
            this.radStaffGroup.MouseEnter += new System.EventHandler(this.radStaffGroup_MouseEnter_1);
            this.radStaffGroup.MouseLeave += new System.EventHandler(this.radStaffGroup_MouseLeave_1);
            // 
            // radGroup
            // 
            this.radGroup.AutoSize = true;
            this.radGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroup.ForeColor = System.Drawing.Color.Yellow;
            this.radGroup.Location = new System.Drawing.Point(373, 7);
            this.radGroup.Margin = new System.Windows.Forms.Padding(2);
            this.radGroup.Name = "radGroup";
            this.radGroup.Size = new System.Drawing.Size(74, 24);
            this.radGroup.TabIndex = 14;
            this.radGroup.Text = "Group";
            this.radGroup.UseVisualStyleBackColor = true;
            this.radGroup.CheckedChanged += new System.EventHandler(this.radGroup_CheckedChanged_1);
            this.radGroup.MouseEnter += new System.EventHandler(this.radGroup_MouseEnter_1);
            this.radGroup.MouseLeave += new System.EventHandler(this.radGroup_MouseLeave_1);
            // 
            // radBooking
            // 
            this.radBooking.AutoSize = true;
            this.radBooking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBooking.ForeColor = System.Drawing.Color.Yellow;
            this.radBooking.Location = new System.Drawing.Point(164, 7);
            this.radBooking.Margin = new System.Windows.Forms.Padding(2);
            this.radBooking.Name = "radBooking";
            this.radBooking.Size = new System.Drawing.Size(86, 24);
            this.radBooking.TabIndex = 15;
            this.radBooking.Text = "Booking";
            this.radBooking.UseVisualStyleBackColor = true;
            this.radBooking.CheckedChanged += new System.EventHandler(this.radBooking_CheckedChanged_1);
            this.radBooking.MouseEnter += new System.EventHandler(this.radBooking_MouseEnter_1);
            this.radBooking.MouseLeave += new System.EventHandler(this.radBooking_MouseLeave_1);
            // 
            // radKid
            // 
            this.radKid.AutoSize = true;
            this.radKid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKid.ForeColor = System.Drawing.Color.Yellow;
            this.radKid.Location = new System.Drawing.Point(96, 7);
            this.radKid.Margin = new System.Windows.Forms.Padding(2);
            this.radKid.Name = "radKid";
            this.radKid.Size = new System.Drawing.Size(64, 24);
            this.radKid.TabIndex = 16;
            this.radKid.Text = "Child";
            this.radKid.UseVisualStyleBackColor = true;
            this.radKid.CheckedChanged += new System.EventHandler(this.radKid_CheckedChanged_1);
            this.radKid.MouseEnter += new System.EventHandler(this.radKid_MouseEnter_1);
            this.radKid.MouseLeave += new System.EventHandler(this.radKid_MouseLeave_1);
            // 
            // radParent
            // 
            this.radParent.AutoSize = true;
            this.radParent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radParent.ForeColor = System.Drawing.Color.Yellow;
            this.radParent.Location = new System.Drawing.Point(17, 7);
            this.radParent.Margin = new System.Windows.Forms.Padding(2);
            this.radParent.Name = "radParent";
            this.radParent.Size = new System.Drawing.Size(75, 24);
            this.radParent.TabIndex = 11;
            this.radParent.Text = "Parent";
            this.radParent.UseVisualStyleBackColor = true;
            this.radParent.CheckedChanged += new System.EventHandler(this.radParent_CheckedChanged_1);
            this.radParent.MouseEnter += new System.EventHandler(this.radParent_MouseEnter_1);
            this.radParent.MouseLeave += new System.EventHandler(this.radParent_MouseLeave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(321, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "View Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Turquoise;
            this.label8.Location = new System.Drawing.Point(18, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Select table:";
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
            this.men1.TabIndex = 56;
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
            // crecheToolStripMenuItem
            // 
            this.crecheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editAndDeleteToolStripMenuItem,
            this.assignStaffToolStripMenuItem,
            this.viewDataToolStripMenuItem,
            this.reoprtToolStripMenuItem});
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
            // reoprtToolStripMenuItem
            // 
            this.reoprtToolStripMenuItem.Name = "reoprtToolStripMenuItem";
            this.reoprtToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reoprtToolStripMenuItem.Text = "Reoprt";
            this.reoprtToolStripMenuItem.Click += new System.EventHandler(this.reoprtToolStripMenuItem_Click);
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
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.men1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panSelectTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewDataForm";
            this.Text = "WCH ~ Crèche ~ View Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.panSelectTable.ResumeLayout(false);
            this.panSelectTable.PerformLayout();
            this.men1.ResumeLayout(false);
            this.men1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panSelectTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radBookedOut;
        private System.Windows.Forms.RadioButton radStaff;
        private System.Windows.Forms.RadioButton radStaffGroup;
        private System.Windows.Forms.RadioButton radGroup;
        private System.Windows.Forms.RadioButton radBooking;
        private System.Windows.Forms.RadioButton radKid;
        private System.Windows.Forms.RadioButton radParent;
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
        private System.Windows.Forms.ToolStripMenuItem reoprtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}