namespace DrivingLicense
{
    partial class RenewLostReplacmentLicenseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LostRB = new System.Windows.Forms.RadioButton();
            this.DamagedRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowLicense = new System.Windows.Forms.LinkLabel();
            this.RenewBTN = new System.Windows.Forms.Button();
            this.ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ctrlLicenseReplacmentAppInfo1 = new DrivingLicense.ctrlLicenseReplacmentAppInfo();
            this.ctrlDriverLicenseInfo1 = new DrivingLicense.ctrlDriverLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Replacment For Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LostRB);
            this.groupBox1.Controls.Add(this.DamagedRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(799, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacment For :";
            // 
            // LostRB
            // 
            this.LostRB.AutoSize = true;
            this.LostRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostRB.Location = new System.Drawing.Point(26, 59);
            this.LostRB.Name = "LostRB";
            this.LostRB.Size = new System.Drawing.Size(106, 21);
            this.LostRB.TabIndex = 1;
            this.LostRB.Text = "Lost License";
            this.LostRB.UseVisualStyleBackColor = true;
            this.LostRB.CheckedChanged += new System.EventHandler(this.LostRB_CheckedChanged);
            // 
            // DamagedRB
            // 
            this.DamagedRB.AutoSize = true;
            this.DamagedRB.Checked = true;
            this.DamagedRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamagedRB.Location = new System.Drawing.Point(26, 32);
            this.DamagedRB.Name = "DamagedRB";
            this.DamagedRB.Size = new System.Drawing.Size(140, 21);
            this.DamagedRB.TabIndex = 0;
            this.DamagedRB.TabStop = true;
            this.DamagedRB.Text = "Damaged License";
            this.DamagedRB.UseVisualStyleBackColor = true;
            this.DamagedRB.CheckedChanged += new System.EventHandler(this.DamagedRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBTN);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(799, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 152);
            this.groupBox2.TabIndex = 9;
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
            // ShowLicense
            // 
            this.ShowLicense.AutoSize = true;
            this.ShowLicense.Enabled = false;
            this.ShowLicense.Location = new System.Drawing.Point(147, 542);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(74, 13);
            this.ShowLicense.TabIndex = 14;
            this.ShowLicense.TabStop = true;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicense_LinkClicked);
            // 
            // RenewBTN
            // 
            this.RenewBTN.Enabled = false;
            this.RenewBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewBTN.Location = new System.Drawing.Point(718, 537);
            this.RenewBTN.Name = "RenewBTN";
            this.RenewBTN.Size = new System.Drawing.Size(75, 28);
            this.RenewBTN.TabIndex = 13;
            this.RenewBTN.Text = "Renew";
            this.RenewBTN.UseVisualStyleBackColor = true;
            this.RenewBTN.Click += new System.EventHandler(this.RenewBTN_Click);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.AutoSize = true;
            this.ShowLicenseHistory.Enabled = false;
            this.ShowLicenseHistory.Location = new System.Drawing.Point(12, 542);
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.ShowLicenseHistory.TabIndex = 12;
            this.ShowLicenseHistory.TabStop = true;
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseHistory_LinkClicked);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(637, 537);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 28);
            this.CloseBTN.TabIndex = 11;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // ctrlLicenseReplacmentAppInfo1
            // 
            this.ctrlLicenseReplacmentAppInfo1.Location = new System.Drawing.Point(6, 359);
            this.ctrlLicenseReplacmentAppInfo1.Name = "ctrlLicenseReplacmentAppInfo1";
            this.ctrlLicenseReplacmentAppInfo1.Size = new System.Drawing.Size(787, 161);
            this.ctrlLicenseReplacmentAppInfo1.TabIndex = 15;
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(11, 36);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(782, 317);
            this.ctrlDriverLicenseInfo1.TabIndex = 7;
            // 
            // RenewLostReplacmentLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 590);
            this.Controls.Add(this.ctrlLicenseReplacmentAppInfo1);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.RenewBTN);
            this.Controls.Add(this.ShowLicenseHistory);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Name = "RenewLostReplacmentLicenseForm";
            this.Text = "RenewLostReplacmentLicenseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LostRB;
        private System.Windows.Forms.RadioButton DamagedRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ShowLicense;
        private System.Windows.Forms.Button RenewBTN;
        private System.Windows.Forms.LinkLabel ShowLicenseHistory;
        private System.Windows.Forms.Button CloseBTN;
        private ctrlLicenseReplacmentAppInfo ctrlLicenseReplacmentAppInfo1;
    }
}