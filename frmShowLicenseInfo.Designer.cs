namespace DVLD
{
    partial class frmShowLicenseInfo
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
            this.pbType = new System.Windows.Forms.PictureBox();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLicenseInfo1 = new DVLD.ctrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            this.SuspendLayout();
            // 
            // pbType
            // 
            this.pbType.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbType.Location = new System.Drawing.Point(354, 25);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(191, 126);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 13;
            this.pbType.TabStop = false;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTestTitle.Location = new System.Drawing.Point(339, 170);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(231, 29);
            this.lblTestTitle.TabIndex = 12;
            this.lblTestTitle.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(754, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 202);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(869, 305);
            this.ctrlLicenseInfo1.TabIndex = 14;
            // 
            // frmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 567);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.btnClose);
            this.Name = "frmShowLicenseInfo";
            this.Text = "frmShowLicenseInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Button btnClose;
        private ctrlLicenseInfo ctrlLicenseInfo1;
    }
}