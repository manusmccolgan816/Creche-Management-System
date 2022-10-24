namespace ManusCrecheCW.Forms
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new ManusCrecheCW.DataSet2();
            this.crecheDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnBack = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crecheDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ManusCrecheCW.DataSet2();
            this.crecheDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new ManusCrecheCW.DataSet2TableAdapters.DataTable1TableAdapter();
            this.qryNonDeletedBookingsTodayToolStrip = new System.Windows.Forms.ToolStrip();
            this.qryNonDeletedBookingsTodayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpSecond = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblParentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSet1BindingSource)).BeginInit();
            this.men1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSet2BindingSource)).BeginInit();
            this.qryNonDeletedBookingsTodayToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // men1
            // 
            this.men1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.men1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.men1.Size = new System.Drawing.Size(984, 25);
            this.men1.TabIndex = 58;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Turquoise;
            this.btnBack.Location = new System.Drawing.Point(12, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 60;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // reportViewer1
            // 
            reportDataSource8.Name = "DataSet2";
            reportDataSource8.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ManusCrecheCW.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(68, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(848, 416);
            this.reportViewer1.TabIndex = 61;
            // 
            // ParentBindingSource
            // 
            this.ParentBindingSource.DataMember = "Parent";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // qryNonDeletedBookingsTodayToolStrip
            // 
            this.qryNonDeletedBookingsTodayToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qryNonDeletedBookingsTodayToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qryNonDeletedBookingsTodayToolStripButton});
            this.qryNonDeletedBookingsTodayToolStrip.Location = new System.Drawing.Point(0, 23);
            this.qryNonDeletedBookingsTodayToolStrip.Name = "qryNonDeletedBookingsTodayToolStrip";
            this.qryNonDeletedBookingsTodayToolStrip.Size = new System.Drawing.Size(984, 22);
            this.qryNonDeletedBookingsTodayToolStrip.TabIndex = 62;
            this.qryNonDeletedBookingsTodayToolStrip.Text = "qryNonDeletedBookingsTodayToolStrip";
            this.qryNonDeletedBookingsTodayToolStrip.Visible = false;
            // 
            // qryNonDeletedBookingsTodayToolStripButton
            // 
            this.qryNonDeletedBookingsTodayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryNonDeletedBookingsTodayToolStripButton.Name = "qryNonDeletedBookingsTodayToolStripButton";
            this.qryNonDeletedBookingsTodayToolStripButton.Size = new System.Drawing.Size(172, 19);
            this.qryNonDeletedBookingsTodayToolStripButton.Text = "qryNonDeletedBookingsToday";
            this.qryNonDeletedBookingsTodayToolStripButton.Click += new System.EventHandler(this.qryNonDeletedBookingsTodayToolStripButton_Click);
            // 
            // dtpFirst
            // 
            this.dtpFirst.Location = new System.Drawing.Point(320, 516);
            this.dtpFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(151, 20);
            this.dtpFirst.TabIndex = 63;
            this.dtpFirst.ValueChanged += new System.EventHandler(this.dtpFirst_ValueChanged);
            // 
            // dtpSecond
            // 
            this.dtpSecond.Enabled = false;
            this.dtpSecond.Location = new System.Drawing.Point(516, 516);
            this.dtpSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpSecond.Name = "dtpSecond";
            this.dtpSecond.Size = new System.Drawing.Size(151, 20);
            this.dtpSecond.TabIndex = 64;
            this.dtpSecond.ValueChanged += new System.EventHandler(this.dtpSecond_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Turquoise;
            this.btnConfirm.Location = new System.Drawing.Point(447, 552);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 40);
            this.btnConfirm.TabIndex = 65;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            this.btnConfirm.MouseEnter += new System.EventHandler(this.btnConfirm_MouseEnter);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirm_MouseLeave);
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentName.ForeColor = System.Drawing.Color.Turquoise;
            this.lblParentName.Location = new System.Drawing.Point(317, 496);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(96, 20);
            this.lblParentName.TabIndex = 81;
            this.lblParentName.Text = "Start date 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(513, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Start date 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(64, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(737, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "* The report will only take into account bookings with a start date between the t" +
    "wo selected dates *";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParentName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpSecond);
            this.Controls.Add(this.dtpFirst);
            this.Controls.Add(this.qryNonDeletedBookingsTodayToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.men1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.Text = "WCH ~ Crèche ~ Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSet1BindingSource)).EndInit();
            this.men1.ResumeLayout(false);
            this.men1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crecheDataSet2BindingSource)).EndInit();
            this.qryNonDeletedBookingsTodayToolStrip.ResumeLayout(false);
            this.qryNonDeletedBookingsTodayToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip men1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afterSchoolClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource crecheDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource ParentBindingSource;
        private System.Windows.Forms.BindingSource crecheDataSet1BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource crecheDataSet2BindingSource;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ToolStrip qryNonDeletedBookingsTodayToolStrip;
        private System.Windows.Forms.ToolStripButton qryNonDeletedBookingsTodayToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.DateTimePicker dtpSecond;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}