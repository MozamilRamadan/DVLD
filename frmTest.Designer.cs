namespace DVLD
{
    partial class frmTest
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
            this.ctrlAddNew1 = new DVLD.ctrlAddNew();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrlAddNew1
            // 
            this.ctrlAddNew1.Location = new System.Drawing.Point(26, 12);
            this.ctrlAddNew1.Name = "ctrlAddNew1";
            this.ctrlAddNew1.Size = new System.Drawing.Size(853, 467);
            this.ctrlAddNew1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1091, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 60);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.AllowDrop = true;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(34, 20);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(953, 317);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 577);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlAddNew1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddNew ctrlAddNew1;
        private System.Windows.Forms.Button btnSave;
        private ctrlPersonCard ctrlPersonCard1;
    }
}