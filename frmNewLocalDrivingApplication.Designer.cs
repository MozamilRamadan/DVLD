namespace DVLD
{
    partial class frmNewLocalDrivingApplication
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cmClass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpApplicationInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Applications Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Licenses Class:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(223, 72);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(44, 18);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Applications Date:";
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.cmClass);
            this.tpApplicationInfo.Controls.Add(this.label9);
            this.tpApplicationInfo.Controls.Add(this.label8);
            this.tpApplicationInfo.Controls.Add(this.lblFees);
            this.tpApplicationInfo.Controls.Add(this.lblDate);
            this.tpApplicationInfo.Controls.Add(this.label6);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.lblUserID);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 25);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(773, 409);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cmClass
            // 
            this.cmClass.FormattingEnabled = true;
            this.cmClass.Location = new System.Drawing.Point(216, 182);
            this.cmClass.Name = "cmClass";
            this.cmClass.Size = new System.Drawing.Size(197, 26);
            this.cmClass.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Orderd By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(213, 235);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(45, 18);
            this.lblFees.TabIndex = 10;
            this.lblFees.Text = "[???]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(213, 131);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "D.L Application ID:";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(656, 372);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 31);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonInfo1);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(773, 409);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Persoinal Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(773, 366);
            this.ctrlPersonInfo1.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 438);
            this.tabControl1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(684, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(577, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(206, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Local Driving Application";
            // 
            // frmNewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 549);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "frmNewLocalDrivingApplication";
            this.Text = "frmNewLocalDrivingApplication";
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            this.tpPersonInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmClass;
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}