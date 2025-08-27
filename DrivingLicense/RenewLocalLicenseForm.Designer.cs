namespace DrivingLicense
{
    partial class RenewLocalLicenseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.RenewBTN = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.LinkLabel();
            this.ctrlRenewLicenseApplication1 = new DrivingLicense.ctrlRenewLicenseApplication();
            this.ctrlDriverLicenseInfo1 = new DrivingLicense.ctrlDriverLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBTN);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(791, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(18, 100);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 28);
            this.searchBTN.TabIndex = 2;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
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
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Renew License Application";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(805, 382);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 28);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Location = new System.Drawing.Point(806, 423);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.ShowLicenseHistory.TabIndex = 8;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // RenewBTN
            // 
            this.RenewBTN.Enabled = false;
            this.RenewBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewBTN.Location = new System.Drawing.Point(886, 382);
            this.RenewBTN.Name = "RenewBTN";
            this.RenewBTN.Size = new System.Drawing.Size(75, 28);
            this.RenewBTN.TabIndex = 9;
            this.RenewBTN.Text = "Renew";
            this.RenewBTN.UseVisualStyleBackColor = true;
            this.RenewBTN.Click += new System.EventHandler(this.RenewBTN_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.AutoSize = true;
            this.ShowLicense.Enabled = false;
            this.ShowLicense.Location = new System.Drawing.Point(806, 447);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(74, 13);
            this.ShowLicense.TabIndex = 10;
            this.ShowLicense.TabStop = true;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicense_LinkClicked);
            // 
            // ctrlRenewLicenseApplication1
            // 
            this.ctrlRenewLicenseApplication1.Location = new System.Drawing.Point(3, 369);
            this.ctrlRenewLicenseApplication1.Name = "ctrlRenewLicenseApplication1";
            this.ctrlRenewLicenseApplication1.Size = new System.Drawing.Size(782, 255);
            this.ctrlRenewLicenseApplication1.TabIndex = 11;
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(3, 36);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(782, 317);
            this.ctrlDriverLicenseInfo1.TabIndex = 5;
            // 
            // RenewLocalLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 623);
            this.Controls.Add(this.ctrlRenewLicenseApplication1);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.RenewBTN);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RenewLocalLicenseForm";
            this.Text = "RenewLocalLicenseForm";
            this.Load += new System.EventHandler(this.RenewLocalLicenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private System.Windows.Forms.Button RenewBTN;
        private System.Windows.Forms.LinkLabel ShowLicense;
        private ctrlRenewLicenseApplication ctrlRenewLicenseApplication1;
    }
}