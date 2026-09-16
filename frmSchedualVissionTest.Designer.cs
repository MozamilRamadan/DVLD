namespace DVLD
{
    partial class frmSchedualVissionTest
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
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsAppoinments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlApplicationDetails1 = new DVLD.ctrlDriverLicenseApplicationInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.pbType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsAppoinments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTestTitle.Location = new System.Drawing.Point(287, 122);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(248, 25);
            this.lblTestTitle.TabIndex = 0;
            this.lblTestTitle.Text = "Vision Test Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsAppoinments;
            this.dataGridView1.Location = new System.Drawing.Point(12, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 153);
            this.dataGridView1.TabIndex = 8;
            // 
            // cmsAppoinments
            // 
            this.cmsAppoinments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAppoinments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppoinments.Name = "contextMenuStrip1";
            this.cmsAppoinments.Size = new System.Drawing.Size(142, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ctrlApplicationDetails1
            // 
            this.ctrlApplicationDetails1.Location = new System.Drawing.Point(12, 150);
            this.ctrlApplicationDetails1.Name = "ctrlApplicationDetails1";
            this.ctrlApplicationDetails1.Size = new System.Drawing.Size(774, 292);
            this.ctrlApplicationDetails1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(657, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Image = global::DVLD.Properties.Resources.Local_32;
            this.btnLocal.Location = new System.Drawing.Point(706, 450);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(53, 28);
            this.btnLocal.TabIndex = 5;
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // pbType
            // 
            this.pbType.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pbType.Location = new System.Drawing.Point(279, 2);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(255, 117);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 2;
            this.pbType.TabStop = false;
            // 
            // frmSchedualVissionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.ctrlApplicationDetails1);
            this.Controls.Add(this.lblTestTitle);
            this.Name = "frmSchedualVissionTest";
            this.Text = "frmSchedualVissionTest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsAppoinments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTitle;
        private ctrlDriverLicenseApplicationInfo ctrlApplicationDetails1;
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsAppoinments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}