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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbApplication = new System.Windows.Forms.ToolStripButton();
            this.tslApplication = new System.Windows.Forms.ToolStripLabel();
            this.tsbPeople = new System.Windows.Forms.ToolStripButton();
            this.tslPeople = new System.Windows.Forms.ToolStripLabel();
            this.tsbDriver = new System.Windows.Forms.ToolStripButton();
            this.tslDriver = new System.Windows.Forms.ToolStripLabel();
            this.tsbUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbApplication,
            this.tslApplication,
            this.tsbPeople,
            this.tslPeople,
            this.tsbDriver,
            this.tslDriver,
            this.tsbUsers,
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbApplication
            // 
            this.tsbApplication.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplication.Image")));
            this.tsbApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplication.Name = "tsbApplication";
            this.tsbApplication.Size = new System.Drawing.Size(29, 24);
            this.tsbApplication.Text = "Applications";
            // 
            // tslApplication
            // 
            this.tslApplication.Name = "tslApplication";
            this.tslApplication.Size = new System.Drawing.Size(92, 24);
            this.tslApplication.Text = "Applications";
            // 
            // tsbPeople
            // 
            this.tsbPeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPeople.Image = ((System.Drawing.Image)(resources.GetObject("tsbPeople.Image")));
            this.tsbPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPeople.Name = "tsbPeople";
            this.tsbPeople.Size = new System.Drawing.Size(29, 24);
            this.tsbPeople.Text = "Poeple";
            // 
            // tslPeople
            // 
            this.tslPeople.Name = "tslPeople";
            this.tslPeople.Size = new System.Drawing.Size(54, 24);
            this.tslPeople.Text = "People";
            this.tslPeople.Click += new System.EventHandler(this.tslPeople_Click);
            // 
            // tsbDriver
            // 
            this.tsbDriver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDriver.Image = ((System.Drawing.Image)(resources.GetObject("tsbDriver.Image")));
            this.tsbDriver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDriver.Name = "tsbDriver";
            this.tsbDriver.Size = new System.Drawing.Size(29, 24);
            this.tsbDriver.Text = "Drivers";
            // 
            // tslDriver
            // 
            this.tslDriver.Name = "tslDriver";
            this.tslDriver.Size = new System.Drawing.Size(49, 24);
            this.tslDriver.Text = "Driver";
            // 
            // tsbUsers
            // 
            this.tsbUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsers.Image")));
            this.tsbUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsers.Name = "tsbUsers";
            this.tsbUsers.Size = new System.Drawing.Size(29, 24);
            this.tsbUsers.Text = "Users";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 24);
            this.toolStripLabel1.Text = "Users";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.singOutToolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(128, 24);
            this.toolStripLabel2.Text = "Account Setting";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signOutToolStripMenuItem.Text = "Show User Info";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.singOutToolStripMenuItem.Text = "Sing Out";
            this.singOutToolStripMenuItem.Click += new System.EventHandler(this.singOutToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 539);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslApplication;
        private System.Windows.Forms.ToolStripButton tsbApplication;
        private System.Windows.Forms.ToolStripButton tsbPeople;
        private System.Windows.Forms.ToolStripLabel tslPeople;
        private System.Windows.Forms.ToolStripButton tsbDriver;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslDriver;
        private System.Windows.Forms.ToolStripButton tsbUsers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem;
    }
}

