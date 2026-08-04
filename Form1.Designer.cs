namespace DVLD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tsbAccountSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
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
            this.tsbAccountSetting,
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
            // tsbAccountSetting
            // 
            this.tsbAccountSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAccountSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccountSetting.Image")));
            this.tsbAccountSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccountSetting.Name = "tsbAccountSetting";
            this.tsbAccountSetting.Size = new System.Drawing.Size(29, 24);
            this.tsbAccountSetting.Text = "toolStripButton1";
            this.tsbAccountSetting.ToolTipText = "Account Setting";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(114, 24);
            this.toolStripLabel2.Text = "Account Setting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 539);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripButton tsbAccountSetting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

