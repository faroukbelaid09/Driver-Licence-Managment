namespace DrivingLicense
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
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
            this.IsActiveCB = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserIDValue = new System.Windows.Forms.Label();
            this.PersonIDPB = new System.Windows.Forms.PictureBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.TabControlWindow.SuspendLayout();
            this.PersonalInfoTab.SuspendLayout();
            this.FillterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPersonPB)).BeginInit();
            this.LoginInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonIDPB)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Controls.Add(this.PersonalInfoTab);
            this.TabControlWindow.Controls.Add(this.LoginInfoTab);
            this.TabControlWindow.Location = new System.Drawing.Point(12, 45);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(767, 519);
            this.TabControlWindow.TabIndex = 1;
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
            "Person ID"});
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
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(760, 342);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // LoginInfoTab
            // 
            this.LoginInfoTab.Controls.Add(this.IsActiveCB);
            this.LoginInfoTab.Controls.Add(this.ConfirmPasswordTB);
            this.LoginInfoTab.Controls.Add(this.pictureBox3);
            this.LoginInfoTab.Controls.Add(this.ConfirmPasswordLabel);
            this.LoginInfoTab.Controls.Add(this.PasswordTB);
            this.LoginInfoTab.Controls.Add(this.pictureBox2);
            this.LoginInfoTab.Controls.Add(this.PasswordLabel);
            this.LoginInfoTab.Controls.Add(this.UserNameTB);
            this.LoginInfoTab.Controls.Add(this.pictureBox1);
            this.LoginInfoTab.Controls.Add(this.UserNameLabel);
            this.LoginInfoTab.Controls.Add(this.UserIDValue);
            this.LoginInfoTab.Controls.Add(this.PersonIDPB);
            this.LoginInfoTab.Controls.Add(this.UserIDLabel);
            this.LoginInfoTab.Location = new System.Drawing.Point(4, 22);
            this.LoginInfoTab.Name = "LoginInfoTab";
            this.LoginInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfoTab.Size = new System.Drawing.Size(759, 493);
            this.LoginInfoTab.TabIndex = 1;
            this.LoginInfoTab.Text = "Login Info";
            this.LoginInfoTab.UseVisualStyleBackColor = true;
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveCB.Location = new System.Drawing.Point(204, 244);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(88, 21);
            this.IsActiveCB.TabIndex = 26;
            this.IsActiveCB.Text = "Is Active";
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(204, 200);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(139, 20);
            this.ConfirmPasswordTB.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(15, 202);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(142, 17);
            this.ConfirmPasswordLabel.TabIndex = 23;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(204, 158);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(139, 20);
            this.PasswordTB.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(75, 160);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 17);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(204, 115);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(139, 20);
            this.UserNameTB.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(64, 117);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(93, 17);
            this.UserNameLabel.TabIndex = 17;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserIDValue
            // 
            this.UserIDValue.AutoSize = true;
            this.UserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDValue.Location = new System.Drawing.Point(204, 73);
            this.UserIDValue.Name = "UserIDValue";
            this.UserIDValue.Size = new System.Drawing.Size(34, 17);
            this.UserIDValue.TabIndex = 16;
            this.UserIDValue.Text = "N/A";
            // 
            // PersonIDPB
            // 
            this.PersonIDPB.Image = ((System.Drawing.Image)(resources.GetObject("PersonIDPB.Image")));
            this.PersonIDPB.Location = new System.Drawing.Point(163, 69);
            this.PersonIDPB.Name = "PersonIDPB";
            this.PersonIDPB.Size = new System.Drawing.Size(25, 21);
            this.PersonIDPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonIDPB.TabIndex = 15;
            this.PersonIDPB.TabStop = false;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.Location = new System.Drawing.Point(90, 73);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(67, 17);
            this.UserIDLabel.TabIndex = 14;
            this.UserIDLabel.Text = "User ID:";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Location = new System.Drawing.Point(700, 582);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 30);
            this.SaveBTN.TabIndex = 4;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(619, 582);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 30);
            this.CloseBTN.TabIndex = 3;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // AddNewUserLabel
            // 
            this.AddNewUserLabel.AutoSize = true;
            this.AddNewUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUserLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.AddNewUserLabel.Location = new System.Drawing.Point(320, 9);
            this.AddNewUserLabel.Name = "AddNewUserLabel";
            this.AddNewUserLabel.Size = new System.Drawing.Size(145, 24);
            this.AddNewUserLabel.TabIndex = 5;
            this.AddNewUserLabel.Text = "Add New User";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(805, 665);
            this.Controls.Add(this.AddNewUserLabel);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.TabControlWindow);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.TabControlWindow.ResumeLayout(false);
            this.PersonalInfoTab.ResumeLayout(false);
            this.FillterGB.ResumeLayout(false);
            this.FillterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPersonPB)).EndInit();
            this.LoginInfoTab.ResumeLayout(false);
            this.LoginInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonIDPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlWindow;
        private System.Windows.Forms.TabPage PersonalInfoTab;
        private System.Windows.Forms.TabPage LoginInfoTab;
        private System.Windows.Forms.GroupBox FillterGB;
        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.TextBox FillterTB;
        private System.Windows.Forms.ComboBox FillterCB;
        private System.Windows.Forms.Label FillterByLabel;
        private System.Windows.Forms.PictureBox AddPersonPB;
        private System.Windows.Forms.PictureBox SearchPersonPB;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label AddNewUserLabel;
        private System.Windows.Forms.Label UserIDValue;
        private System.Windows.Forms.PictureBox PersonIDPB;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox IsActiveCB;
    }
}