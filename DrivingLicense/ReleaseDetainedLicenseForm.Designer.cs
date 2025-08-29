namespace DrivingLicense
{
    partial class ReleaseDetainedLicenseForm
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
            this.ShowLicense = new System.Windows.Forms.LinkLabel();
            this.ReleaseBTN = new System.Windows.Forms.Button();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfo1 = new DrivingLicense.ctrlDriverLicenseInfo();
            this.ctrlReleaseLicenseInfo1 = new DrivingLicense.ctrlReleaseLicenseInfo();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowLicense
            // 
            this.ShowLicense.AutoSize = true;
            this.ShowLicense.Enabled = false;
            this.ShowLicense.Location = new System.Drawing.Point(147, 532);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(74, 13);
            this.ShowLicense.TabIndex = 26;
            this.ShowLicense.TabStop = true;
            this.ShowLicense.Text = "Show License";
            // 
            // ReleaseBTN
            // 
            this.ReleaseBTN.Enabled = false;
            this.ReleaseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseBTN.Location = new System.Drawing.Point(718, 527);
            this.ReleaseBTN.Name = "ReleaseBTN";
            this.ReleaseBTN.Size = new System.Drawing.Size(75, 28);
            this.ReleaseBTN.TabIndex = 25;
            this.ReleaseBTN.Text = "Release";
            this.ReleaseBTN.UseVisualStyleBackColor = true;
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Location = new System.Drawing.Point(12, 532);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.ShowLicenseHistory.TabIndex = 24;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(637, 527);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 28);
            this.CloseBTN.TabIndex = 23;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBTN);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(800, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 152);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(18, 100);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 28);
            this.searchBTN.TabIndex = 2;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(18, 61);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(175, 23);
            this.searchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Release Detained License";
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(12, 53);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(782, 317);
            this.ctrlDriverLicenseInfo1.TabIndex = 21;
            // 
            // ctrlReleaseLicenseInfo1
            // 
            this.ctrlReleaseLicenseInfo1.Location = new System.Drawing.Point(6, 376);
            this.ctrlReleaseLicenseInfo1.Name = "ctrlReleaseLicenseInfo1";
            this.ctrlReleaseLicenseInfo1.Size = new System.Drawing.Size(788, 151);
            this.ctrlReleaseLicenseInfo1.TabIndex = 27;
            // 
            // ReleaseDetainedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 569);
            this.Controls.Add(this.ctrlReleaseLicenseInfo1);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.ReleaseBTN);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Name = "ReleaseDetainedLicenseForm";
            this.Text = "ReleaseDetainedLicenseForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel ShowLicense;
        private System.Windows.Forms.Button ReleaseBTN;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label label1;
        private ctrlReleaseLicenseInfo ctrlReleaseLicenseInfo1;
    }
}