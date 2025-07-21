namespace DrivingLicense
{
    partial class NewLocalDrivingLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLocalDrivingLicenseForm));
            this.AddEditUserLabel = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.TabControlWindow = new System.Windows.Forms.TabControl();
            this.PersonalInfoTab = new System.Windows.Forms.TabPage();
            this.NextBTN = new System.Windows.Forms.Button();
            this.FillterGB = new System.Windows.Forms.GroupBox();
            this.AddPersonPB = new System.Windows.Forms.PictureBox();
            this.SearchPersonPB = new System.Windows.Forms.PictureBox();
            this.FillterTB = new System.Windows.Forms.TextBox();
            this.FillterCB = new System.Windows.Forms.ComboBox();
            this.FillterByLabel = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new DrivingLicense.ctrlPersonInfo();
            this.LoginInfoTab = new System.Windows.Forms.TabPage();
            this.LicenseClassCB = new System.Windows.Forms.ComboBox();
            this.CreatedbyValue = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ApplicationFeeValue = new System.Windows.Forms.Label();
            this.ApplicationDateValue = new System.Windows.Forms.Label();
            this.LicenseClassLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ApplicationFeeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ApplicationDateLabel = new System.Windows.Forms.Label();
            this.ApplicationIDValue = new System.Windows.Forms.Label();
            this.PersonIDPB = new System.Windows.Forms.PictureBox();
            this.ApplicationIDLabel = new System.Windows.Forms.Label();
            this.TabControlWindow.SuspendLayout();
            this.PersonalInfoTab.SuspendLayout();
            this.FillterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPersonPB)).BeginInit();
            this.LoginInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonIDPB)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEditUserLabel
            // 
            this.AddEditUserLabel.AutoSize = true;
            this.AddEditUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditUserLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.AddEditUserLabel.Location = new System.Drawing.Point(335, 9);
            this.AddEditUserLabel.Name = "AddEditUserLabel";
            this.AddEditUserLabel.Size = new System.Drawing.Size(258, 24);
            this.AddEditUserLabel.TabIndex = 13;
            this.AddEditUserLabel.Text = "New Local Driving License";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Enabled = false;
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Location = new System.Drawing.Point(750, 568);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 30);
            this.SaveBTN.TabIndex = 12;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(669, 568);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 30);
            this.CloseBTN.TabIndex = 11;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Controls.Add(this.PersonalInfoTab);
            this.TabControlWindow.Controls.Add(this.LoginInfoTab);
            this.TabControlWindow.Location = new System.Drawing.Point(62, 35);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(767, 519);
            this.TabControlWindow.TabIndex = 10;
            this.TabControlWindow.SelectedIndexChanged += new System.EventHandler(this.TabControlWindow_SelectedIndexChanged);
            // 
            // PersonalInfoTab
            // 
            this.PersonalInfoTab.Controls.Add(this.NextBTN);
            this.PersonalInfoTab.Controls.Add(this.FillterGB);
            this.PersonalInfoTab.Controls.Add(this.ctrlPersonInfo1);
            this.PersonalInfoTab.Location = new System.Drawing.Point(4, 22);
            this.PersonalInfoTab.Name = "PersonalInfoTab";
            this.PersonalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfoTab.Size = new System.Drawing.Size(759, 493);
            this.PersonalInfoTab.TabIndex = 0;
            this.PersonalInfoTab.Text = "Personal Info";
            this.PersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // NextBTN
            // 
            this.NextBTN.Enabled = false;
            this.NextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.Location = new System.Drawing.Point(676, 457);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(75, 30);
            this.NextBTN.TabIndex = 5;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // FillterGB
            // 
            this.FillterGB.Controls.Add(this.AddPersonPB);
            this.FillterGB.Controls.Add(this.SearchPersonPB);
            this.FillterGB.Controls.Add(this.FillterTB);
            this.FillterGB.Controls.Add(this.FillterCB);
            this.FillterGB.Controls.Add(this.FillterByLabel);
            this.FillterGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterGB.Location = new System.Drawing.Point(22, 23);
            this.FillterGB.Name = "FillterGB";
            this.FillterGB.Size = new System.Drawing.Size(729, 87);
            this.FillterGB.TabIndex = 1;
            this.FillterGB.TabStop = false;
            this.FillterGB.Text = "Fillter";
            // 
            // AddPersonPB
            // 
            this.AddPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("AddPersonPB.Image")));
            this.AddPersonPB.Location = new System.Drawing.Point(693, 28);
            this.AddPersonPB.Name = "AddPersonPB";
            this.AddPersonPB.Size = new System.Drawing.Size(30, 30);
            this.AddPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPersonPB.TabIndex = 12;
            this.AddPersonPB.TabStop = false;
            this.AddPersonPB.Click += new System.EventHandler(this.AddPersonPB_Click);
            // 
            // SearchPersonPB
            // 
            this.SearchPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("SearchPersonPB.Image")));
            this.SearchPersonPB.Location = new System.Drawing.Point(638, 28);
            this.SearchPersonPB.Name = "SearchPersonPB";
            this.SearchPersonPB.Size = new System.Drawing.Size(30, 30);
            this.SearchPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPersonPB.TabIndex = 11;
            this.SearchPersonPB.TabStop = false;
            this.SearchPersonPB.Click += new System.EventHandler(this.SearchPersonPB_Click);
            // 
            // FillterTB
            // 
            this.FillterTB.Location = new System.Drawing.Point(236, 27);
            this.FillterTB.MinimumSize = new System.Drawing.Size(136, 24);
            this.FillterTB.Multiline = true;
            this.FillterTB.Name = "FillterTB";
            this.FillterTB.Size = new System.Drawing.Size(162, 24);
            this.FillterTB.TabIndex = 10;
            // 
            // FillterCB
            // 
            this.FillterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FillterCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterCB.FormattingEnabled = true;
            this.FillterCB.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No"});
            this.FillterCB.Location = new System.Drawing.Point(98, 27);
            this.FillterCB.Name = "FillterCB";
            this.FillterCB.Size = new System.Drawing.Size(121, 24);
            this.FillterCB.TabIndex = 9;
            this.FillterCB.SelectedIndexChanged += new System.EventHandler(this.FillterCB_SelectedIndexChanged);
            // 
            // FillterByLabel
            // 
            this.FillterByLabel.AutoSize = true;
            this.FillterByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterByLabel.Location = new System.Drawing.Point(6, 27);
            this.FillterByLabel.Name = "FillterByLabel";
            this.FillterByLabel.Size = new System.Drawing.Size(73, 17);
            this.FillterByLabel.TabIndex = 8;
            this.FillterByLabel.Text = "Filter By:";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 116);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(760, 342);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // LoginInfoTab
            // 
            this.LoginInfoTab.Controls.Add(this.LicenseClassCB);
            this.LoginInfoTab.Controls.Add(this.CreatedbyValue);
            this.LoginInfoTab.Controls.Add(this.pictureBox4);
            this.LoginInfoTab.Controls.Add(this.ApplicationFeeValue);
            this.LoginInfoTab.Controls.Add(this.ApplicationDateValue);
            this.LoginInfoTab.Controls.Add(this.LicenseClassLabel);
            this.LoginInfoTab.Controls.Add(this.pictureBox3);
            this.LoginInfoTab.Controls.Add(this.CreatedByLabel);
            this.LoginInfoTab.Controls.Add(this.pictureBox2);
            this.LoginInfoTab.Controls.Add(this.ApplicationFeeLabel);
            this.LoginInfoTab.Controls.Add(this.pictureBox1);
            this.LoginInfoTab.Controls.Add(this.ApplicationDateLabel);
            this.LoginInfoTab.Controls.Add(this.ApplicationIDValue);
            this.LoginInfoTab.Controls.Add(this.PersonIDPB);
            this.LoginInfoTab.Controls.Add(this.ApplicationIDLabel);
            this.LoginInfoTab.Location = new System.Drawing.Point(4, 22);
            this.LoginInfoTab.Name = "LoginInfoTab";
            this.LoginInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfoTab.Size = new System.Drawing.Size(759, 493);
            this.LoginInfoTab.TabIndex = 1;
            this.LoginInfoTab.Text = "Application Info";
            this.LoginInfoTab.UseVisualStyleBackColor = true;
            // 
            // LicenseClassCB
            // 
            this.LicenseClassCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LicenseClassCB.FormattingEnabled = true;
            this.LicenseClassCB.Location = new System.Drawing.Point(230, 159);
            this.LicenseClassCB.Name = "LicenseClassCB";
            this.LicenseClassCB.Size = new System.Drawing.Size(174, 21);
            this.LicenseClassCB.TabIndex = 32;
            // 
            // CreatedbyValue
            // 
            this.CreatedbyValue.AutoSize = true;
            this.CreatedbyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedbyValue.Location = new System.Drawing.Point(227, 245);
            this.CreatedbyValue.Name = "CreatedbyValue";
            this.CreatedbyValue.Size = new System.Drawing.Size(34, 17);
            this.CreatedbyValue.TabIndex = 31;
            this.CreatedbyValue.Text = "N/A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 243);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // ApplicationFeeValue
            // 
            this.ApplicationFeeValue.AutoSize = true;
            this.ApplicationFeeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFeeValue.Location = new System.Drawing.Point(227, 205);
            this.ApplicationFeeValue.Name = "ApplicationFeeValue";
            this.ApplicationFeeValue.Size = new System.Drawing.Size(34, 17);
            this.ApplicationFeeValue.TabIndex = 29;
            this.ApplicationFeeValue.Text = "N/A";
            // 
            // ApplicationDateValue
            // 
            this.ApplicationDateValue.AutoSize = true;
            this.ApplicationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDateValue.Location = new System.Drawing.Point(227, 115);
            this.ApplicationDateValue.Name = "ApplicationDateValue";
            this.ApplicationDateValue.Size = new System.Drawing.Size(26, 17);
            this.ApplicationDateValue.TabIndex = 28;
            this.ApplicationDateValue.Text = "33";
            // 
            // LicenseClassLabel
            // 
            this.LicenseClassLabel.AutoSize = true;
            this.LicenseClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseClassLabel.Location = new System.Drawing.Point(64, 161);
            this.LicenseClassLabel.Name = "LicenseClassLabel";
            this.LicenseClassLabel.Size = new System.Drawing.Size(113, 17);
            this.LicenseClassLabel.TabIndex = 27;
            this.LicenseClassLabel.Text = "License Class:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(183, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByLabel.Location = new System.Drawing.Point(84, 245);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(93, 17);
            this.CreatedByLabel.TabIndex = 23;
            this.CreatedByLabel.Text = "Created By:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ApplicationFeeLabel
            // 
            this.ApplicationFeeLabel.AutoSize = true;
            this.ApplicationFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFeeLabel.Location = new System.Drawing.Point(52, 205);
            this.ApplicationFeeLabel.Name = "ApplicationFeeLabel";
            this.ApplicationFeeLabel.Size = new System.Drawing.Size(125, 17);
            this.ApplicationFeeLabel.TabIndex = 20;
            this.ApplicationFeeLabel.Text = "Application Fee:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ApplicationDateLabel
            // 
            this.ApplicationDateLabel.AutoSize = true;
            this.ApplicationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDateLabel.Location = new System.Drawing.Point(45, 115);
            this.ApplicationDateLabel.Name = "ApplicationDateLabel";
            this.ApplicationDateLabel.Size = new System.Drawing.Size(132, 17);
            this.ApplicationDateLabel.TabIndex = 17;
            this.ApplicationDateLabel.Text = "Application Date:";
            // 
            // ApplicationIDValue
            // 
            this.ApplicationIDValue.AutoSize = true;
            this.ApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDValue.Location = new System.Drawing.Point(227, 74);
            this.ApplicationIDValue.Name = "ApplicationIDValue";
            this.ApplicationIDValue.Size = new System.Drawing.Size(34, 17);
            this.ApplicationIDValue.TabIndex = 16;
            this.ApplicationIDValue.Text = "N/A";
            // 
            // PersonIDPB
            // 
            this.PersonIDPB.Image = ((System.Drawing.Image)(resources.GetObject("PersonIDPB.Image")));
            this.PersonIDPB.Location = new System.Drawing.Point(183, 72);
            this.PersonIDPB.Name = "PersonIDPB";
            this.PersonIDPB.Size = new System.Drawing.Size(25, 21);
            this.PersonIDPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonIDPB.TabIndex = 15;
            this.PersonIDPB.TabStop = false;
            // 
            // ApplicationIDLabel
            // 
            this.ApplicationIDLabel.AutoSize = true;
            this.ApplicationIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDLabel.Location = new System.Drawing.Point(34, 74);
            this.ApplicationIDLabel.Name = "ApplicationIDLabel";
            this.ApplicationIDLabel.Size = new System.Drawing.Size(143, 17);
            this.ApplicationIDLabel.TabIndex = 14;
            this.ApplicationIDLabel.Text = "D.L Application ID:";
            // 
            // NewLocalDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(890, 607);
            this.Controls.Add(this.AddEditUserLabel);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.TabControlWindow);
            this.Name = "NewLocalDrivingLicenseForm";
            this.Text = "NewLocalDrivingLicenseForm";
            this.TabControlWindow.ResumeLayout(false);
            this.PersonalInfoTab.ResumeLayout(false);
            this.FillterGB.ResumeLayout(false);
            this.FillterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPersonPB)).EndInit();
            this.LoginInfoTab.ResumeLayout(false);
            this.LoginInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonIDPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEditUserLabel;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.TabControl TabControlWindow;
        private System.Windows.Forms.TabPage PersonalInfoTab;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.GroupBox FillterGB;
        private System.Windows.Forms.PictureBox AddPersonPB;
        private System.Windows.Forms.PictureBox SearchPersonPB;
        private System.Windows.Forms.TextBox FillterTB;
        private System.Windows.Forms.ComboBox FillterCB;
        private System.Windows.Forms.Label FillterByLabel;
        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.TabPage LoginInfoTab;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ApplicationFeeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ApplicationDateLabel;
        private System.Windows.Forms.Label ApplicationIDValue;
        private System.Windows.Forms.PictureBox PersonIDPB;
        private System.Windows.Forms.Label ApplicationIDLabel;
        private System.Windows.Forms.Label ApplicationFeeValue;
        private System.Windows.Forms.Label ApplicationDateValue;
        private System.Windows.Forms.Label LicenseClassLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox LicenseClassCB;
        private System.Windows.Forms.Label CreatedbyValue;
    }
}