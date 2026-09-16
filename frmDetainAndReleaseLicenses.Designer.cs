namespace DVLD
{
    partial class frmDetainAndReleaseLicenses
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLicenseInfo1 = new DVLD.ctrlLicenseInfo();
            this.btnDtain = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 67);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(437, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 40);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licenses ID :";
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(21, 143);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(869, 305);
            this.ctrlLicenseInfo1.TabIndex = 28;
            // 
            // btnDtain
            // 
            this.btnDtain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtain.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnDtain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDtain.Location = new System.Drawing.Point(776, 673);
            this.btnDtain.Name = "btnDtain";
            this.btnDtain.Size = new System.Drawing.Size(110, 39);
            this.btnDtain.TabIndex = 37;
            this.btnDtain.Text = "Detain";
            this.btnDtain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDtain.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(653, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(241, 680);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(181, 24);
            this.lblShowLicenseInfo.TabIndex = 38;
            this.lblShowLicenseInfo.TabStop = true;
            this.lblShowLicenseInfo.Text = "Show License Info";
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(12, 680);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(211, 24);
            this.lblShowLicenseHistory.TabIndex = 39;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTestTitle.Location = new System.Drawing.Point(314, 23);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(155, 25);
            this.lblTestTitle.TabIndex = 40;
            this.lblTestTitle.Text = "Detain License";
            // 
            // frmDetainAndReleaseLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 735);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.btnDtain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDetainAndReleaseLicenses";
            this.Text = "frmDetainAndReleaseLicenses";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private ctrlLicenseInfo ctrlLicenseInfo1;
        private System.Windows.Forms.Button btnDtain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.Label lblTestTitle;
    }
}