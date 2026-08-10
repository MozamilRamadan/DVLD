namespace DVLD
{
    partial class frmMain
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.driverLincesServeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAppllicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detinInLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAppllicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.peopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.singOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivinLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivenLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivenLicensesApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // driverLincesServeToolStripMenuItem
            // 
            this.driverLincesServeToolStripMenuItem.Name = "driverLincesServeToolStripMenuItem";
            this.driverLincesServeToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.driverLincesServeToolStripMenuItem.Text = "Driver Licenses Services";
            this.driverLincesServeToolStripMenuItem.Click += new System.EventHandler(this.driverLincesServeToolStripMenuItem_Click);
            // 
            // manageAppllicationToolStripMenuItem
            // 
            this.manageAppllicationToolStripMenuItem.Name = "manageAppllicationToolStripMenuItem";
            this.manageAppllicationToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.manageAppllicationToolStripMenuItem.Text = "Manage Appllication";
            // 
            // detinInLicensesToolStripMenuItem
            // 
            this.detinInLicensesToolStripMenuItem.Name = "detinInLicensesToolStripMenuItem";
            this.detinInLicensesToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.detinInLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypeToolStripMenuItem
            // 
            this.manageApplicationTypeToolStripMenuItem.Name = "manageApplicationTypeToolStripMenuItem";
            this.manageApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.manageApplicationTypeToolStripMenuItem.Text = "Manage Application Type";
            this.manageApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypeToolStripMenuItem_Click);
            // 
            // manageTestTypeToolStripMenuItem
            // 
            this.manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            this.manageTestTypeToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLincesServeToolStripMenuItem,
            this.manageAppllicationToolStripMenuItem,
            this.detinInLicensesToolStripMenuItem,
            this.manageApplicationTypeToolStripMenuItem,
            this.manageTestTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 124);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLicensesServicesToolStripMenuItem,
            this.manageAppllicationToolStripMenuItem1,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypeToolStripMenuItem1,
            this.manageTestTypeToolStripMenuItem1});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // driverLicensesServicesToolStripMenuItem
            // 
            this.driverLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivinLicencesToolStripMenuItem,
            this.renewDrivenLicensesToolStripMenuItem,
            this.replacementForLostOrDamagedLicensesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.releaseDetainedLicensesToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.driverLicensesServicesToolStripMenuItem.Name = "driverLicensesServicesToolStripMenuItem";
            this.driverLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.driverLicensesServicesToolStripMenuItem.Text = "Driver Licenses Services";
            // 
            // manageAppllicationToolStripMenuItem1
            // 
            this.manageAppllicationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivenLicensesApplicationToolStripMenuItem,
            this.internationalLicensesToolStripMenuItem});
            this.manageAppllicationToolStripMenuItem1.Name = "manageAppllicationToolStripMenuItem1";
            this.manageAppllicationToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.manageAppllicationToolStripMenuItem1.Text = "Manage Appllication";
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypeToolStripMenuItem1
            // 
            this.manageApplicationTypeToolStripMenuItem1.Name = "manageApplicationTypeToolStripMenuItem1";
            this.manageApplicationTypeToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.manageApplicationTypeToolStripMenuItem1.Text = "Manage Application Type";
            this.manageApplicationTypeToolStripMenuItem1.Click += new System.EventHandler(this.manageApplicationTypeToolStripMenuItem1_Click);
            // 
            // manageTestTypeToolStripMenuItem1
            // 
            this.manageTestTypeToolStripMenuItem1.Name = "manageTestTypeToolStripMenuItem1";
            this.manageTestTypeToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.manageTestTypeToolStripMenuItem1.Text = "Manage Test Type";
            this.manageTestTypeToolStripMenuItem1.Click += new System.EventHandler(this.manageTestTypeToolStripMenuItem1_Click);
            // 
            // peopToolStripMenuItem
            // 
            this.peopToolStripMenuItem.Name = "peopToolStripMenuItem";
            this.peopToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.peopToolStripMenuItem.Text = "People";
            this.peopToolStripMenuItem.Click += new System.EventHandler(this.peopToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.singOutToolStripMenuItem1});
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.accountSettingToolStripMenuItem.Text = "Account Setting";
            // 
            // showUserInfoToolStripMenuItem
            // 
            this.showUserInfoToolStripMenuItem.Name = "showUserInfoToolStripMenuItem";
            this.showUserInfoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.showUserInfoToolStripMenuItem.Text = "Show User Info";
            this.showUserInfoToolStripMenuItem.Click += new System.EventHandler(this.showUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // singOutToolStripMenuItem1
            // 
            this.singOutToolStripMenuItem1.Name = "singOutToolStripMenuItem1";
            this.singOutToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.singOutToolStripMenuItem1.Text = "Sing Out";
            this.singOutToolStripMenuItem1.Click += new System.EventHandler(this.singOutToolStripMenuItem1_Click);
            // 
            // newDrivinLicencesToolStripMenuItem
            // 
            this.newDrivinLicencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensesToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivinLicencesToolStripMenuItem.Name = "newDrivinLicencesToolStripMenuItem";
            this.newDrivinLicencesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.newDrivinLicencesToolStripMenuItem.Text = "New Drivin Licenses";
            // 
            // localLicensesToolStripMenuItem
            // 
            this.localLicensesToolStripMenuItem.Name = "localLicensesToolStripMenuItem";
            this.localLicensesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.localLicensesToolStripMenuItem.Text = "Local Licenses";
            // 
            // renewDrivenLicensesToolStripMenuItem
            // 
            this.renewDrivenLicensesToolStripMenuItem.Name = "renewDrivenLicensesToolStripMenuItem";
            this.renewDrivenLicensesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.renewDrivenLicensesToolStripMenuItem.Text = "Renew Driven Licenses";
            // 
            // replacementForLostOrDamagedLicensesToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicensesToolStripMenuItem.Name = "replacementForLostOrDamagedLicensesToolStripMenuItem";
            this.replacementForLostOrDamagedLicensesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.replacementForLostOrDamagedLicensesToolStripMenuItem.Text = "Replacement For Lost Or Damaged Licenses";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(380, 6);
            // 
            // releaseDetainedLicensesToolStripMenuItem
            // 
            this.releaseDetainedLicensesToolStripMenuItem.Name = "releaseDetainedLicensesToolStripMenuItem";
            this.releaseDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.releaseDetainedLicensesToolStripMenuItem.Text = "Release Detained Licenses";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // localDrivenLicensesApplicationToolStripMenuItem
            // 
            this.localDrivenLicensesApplicationToolStripMenuItem.Name = "localDrivenLicensesApplicationToolStripMenuItem";
            this.localDrivenLicensesApplicationToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.localDrivenLicensesApplicationToolStripMenuItem.Text = "Local Driven Licenses Application";
            // 
            // internationalLicensesToolStripMenuItem
            // 
            this.internationalLicensesToolStripMenuItem.Name = "internationalLicensesToolStripMenuItem";
            this.internationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.internationalLicensesToolStripMenuItem.Text = "international Licenses";
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 539);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverLincesServeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAppllicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detinInLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAppllicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newDrivinLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivenLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivenLicensesApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicensesToolStripMenuItem;
    }
}

