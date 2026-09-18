namespace DVLD
{
    partial class frmLocalDrivingLicenseApplications
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
            this.dgvLicence = new System.Windows.Forms.DataGridView();
            this.cmFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVissionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWriteTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStrretTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicensessHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence)).BeginInit();
            this.cmFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLicence
            // 
            this.dgvLicence.AllowUserToAddRows = false;
            this.dgvLicence.AllowUserToResizeColumns = false;
            this.dgvLicence.BackgroundColor = System.Drawing.Color.White;
            this.dgvLicence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicence.ContextMenuStrip = this.cmFormat;
            this.dgvLicence.Location = new System.Drawing.Point(12, 262);
            this.dgvLicence.Name = "dgvLicence";
            this.dgvLicence.RowHeadersWidth = 51;
            this.dgvLicence.RowTemplate.Height = 24;
            this.dgvLicence.Size = new System.Drawing.Size(1421, 333);
            this.dgvLicence.TabIndex = 18;
            // 
            // cmFormat
            // 
            this.cmFormat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cancelAppToolStripMenuItem,
            this.toolStripMenuItem2,
            this.scheduleTestTSMI,
            this.toolStripMenuItem3,
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showPersonLicensessHistoryToolStripMenuItem});
            this.cmFormat.Name = "ContextMenuFormat";
            this.cmFormat.Size = new System.Drawing.Size(291, 254);
            this.cmFormat.Opening += new System.ComponentModel.CancelEventHandler(this.cmFormat_Opening);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(290, 24);
            this.tsmShowDetails.Text = "Show Applications Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(287, 6);
            // 
            // cancelAppToolStripMenuItem
            // 
            this.cancelAppToolStripMenuItem.Name = "cancelAppToolStripMenuItem";
            this.cancelAppToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.cancelAppToolStripMenuItem.Text = "Cancel Application";
            this.cancelAppToolStripMenuItem.Click += new System.EventHandler(this.cancelAppToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 6);
            // 
            // scheduleTestTSMI
            // 
            this.scheduleTestTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVissionTestToolStripMenuItem,
            this.sechduleWriteTestToolStripMenuItem,
            this.sechduleStrretTestToolStripMenuItem});
            this.scheduleTestTSMI.Name = "scheduleTestTSMI";
            this.scheduleTestTSMI.Size = new System.Drawing.Size(290, 24);
            this.scheduleTestTSMI.Text = "Sechdule Test";
            // 
            // sechduleVissionTestToolStripMenuItem
            // 
            this.sechduleVissionTestToolStripMenuItem.Name = "sechduleVissionTestToolStripMenuItem";
            this.sechduleVissionTestToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sechduleVissionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            this.sechduleVissionTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleVissionTestToolStripMenuItem_Click);
            // 
            // sechduleWriteTestToolStripMenuItem
            // 
            this.sechduleWriteTestToolStripMenuItem.Name = "sechduleWriteTestToolStripMenuItem";
            this.sechduleWriteTestToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sechduleWriteTestToolStripMenuItem.Text = "sechdule Write Test";
            this.sechduleWriteTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWriteTestToolStripMenuItem_Click);
            // 
            // sechduleStrretTestToolStripMenuItem
            // 
            this.sechduleStrretTestToolStripMenuItem.Name = "sechduleStrretTestToolStripMenuItem";
            this.sechduleStrretTestToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sechduleStrretTestToolStripMenuItem.Text = "sechdule Street Test";
            this.sechduleStrretTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStrretTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(287, 6);
            // 
            // issuesDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem.Name = "issuesDrivingLicenseFirstTimeToolStripMenuItem";
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issues Driving License(FirstTime)";
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issuesDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(287, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(287, 6);
            // 
            // showPersonLicensessHistoryToolStripMenuItem
            // 
            this.showPersonLicensessHistoryToolStripMenuItem.Name = "showPersonLicensessHistoryToolStripMenuItem";
            this.showPersonLicensessHistoryToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.showPersonLicensessHistoryToolStripMenuItem.Text = "Show Person Licensess History";
            this.showPersonLicensessHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensessHistoryToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1306, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(143, 623);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(74, 25);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "# Records:";
            // 
            // cmFilter
            // 
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Location = new System.Drawing.Point(148, 218);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(236, 24);
            this.cmFilter.TabIndex = 13;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(400, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Local Driving License Applications";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.btnAdd.Location = new System.Drawing.Point(1350, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 59);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(622, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(406, 218);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 22);
            this.txtFilterValue.TabIndex = 127;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Local_32;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(779, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 665);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.dgvLicence);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLocalDrivingLicenseApplications";
            this.Text = "frmLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence)).EndInit();
            this.cmFormat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLicence;
        private System.Windows.Forms.ContextMenuStrip cmFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issuesDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensessHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVissionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWriteTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStrretTestToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}