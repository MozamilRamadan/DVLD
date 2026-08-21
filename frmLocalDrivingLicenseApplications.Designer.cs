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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVissionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWriteTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStrretTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicensessHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ContextMenuFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.ContextMenuFormat;
            this.dataGridView1.Location = new System.Drawing.Point(43, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 254);
            this.dataGridView1.TabIndex = 18;
            // 
            // ContextMenuFormat
            // 
            this.ContextMenuFormat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cancelAppToolStripMenuItem,
            this.toolStripMenuItem2,
            this.scheduleTestToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issuesDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showPersonLicensessHistoryToolStripMenuItem});
            this.ContextMenuFormat.Name = "ContextMenuFormat";
            this.ContextMenuFormat.Size = new System.Drawing.Size(291, 254);
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
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVissionTestToolStripMenuItem,
            this.sechduleWriteTestToolStripMenuItem,
            this.sechduleStrretTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.scheduleTestToolStripMenuItem.Text = "Sechdule Test";
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
            // 
            // sechduleStrretTestToolStripMenuItem
            // 
            this.sechduleStrretTestToolStripMenuItem.Name = "sechduleStrretTestToolStripMenuItem";
            this.sechduleStrretTestToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sechduleStrretTestToolStripMenuItem.Text = "sechdule Street Test";
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
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1002, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(124, 494);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(14, 16);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "# Records";
            // 
            // cmbFillter
            // 
            this.cmbFillter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(147, 187);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(121, 24);
            this.cmbFillter.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Local Driving License Applications";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.btnAdd.Location = new System.Drawing.Point(1044, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 45);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(524, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFillter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLocalDrivingLicenseApplications";
            this.Text = "frmLocalDrivingLicenseApplications";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ContextMenuFormat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issuesDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensessHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVissionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWriteTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStrretTestToolStripMenuItem;
    }
}