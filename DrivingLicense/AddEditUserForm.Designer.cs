namespace DrivingLicense
{
    partial class AddEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEditUserLabel
            // 
            this.AddEditUserLabel.AutoSize = true;
            this.AddEditUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditUserLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.AddEditUserLabel.Location = new System.Drawing.Point(405, 11);
            this.AddEditUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddEditUserLabel.Name = "AddEditUserLabel";
            this.AddEditUserLabel.Size = new System.Drawing.Size(181, 29);
            this.AddEditUserLabel.TabIndex = 9;
            this.AddEditUserLabel.Text = "Add New User";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Location = new System.Drawing.Point(951, 700);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(100, 37);
            this.SaveBTN.TabIndex = 8;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click_1);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(843, 700);
            this.CloseBTN.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(100, 37);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click_1);
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Controls.Add(this.PersonalInfoTab);
            this.TabControlWindow.Controls.Add(this.LoginInfoTab);
            this.TabControlWindow.Location = new System.Drawing.Point(33, 44);
            this.TabControlWindow.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(1023, 639);
            this.TabControlWindow.TabIndex = 6;
            this.TabControlWindow.SelectedIndexChanged += new System.EventHandler(this.TabControlWindow_SelectedIndexChanged_1);
            // 
            // PersonalInfoTab
            // 
            this.PersonalInfoTab.Controls.Add(this.NextBTN);
            this.PersonalInfoTab.Controls.Add(this.FillterGB);
            this.PersonalInfoTab.Controls.Add(this.ctrlPersonInfo1);
            this.PersonalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.PersonalInfoTab.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalInfoTab.Name = "PersonalInfoTab";
            this.PersonalInfoTab.Padding = new System.Windows.Forms.Padding(4);
            this.PersonalInfoTab.Size = new System.Drawing.Size(1015, 610);
            this.PersonalInfoTab.TabIndex = 0;
            this.PersonalInfoTab.Text = "Personal Info";
            this.PersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // NextBTN
            // 
            this.NextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.Location = new System.Drawing.Point(901, 562);
            this.NextBTN.Margin = new System.Windows.Forms.Padding(4);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(100, 37);
            this.NextBTN.TabIndex = 5;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click_1);
            // 
            // FillterGB
            // 
            this.FillterGB.Controls.Add(this.AddPersonPB);
            this.FillterGB.Controls.Add(this.SearchPersonPB);
            this.FillterGB.Controls.Add(this.FillterTB);
            this.FillterGB.Controls.Add(this.FillterCB);
            this.FillterGB.Controls.Add(this.FillterByLabel);
            this.FillterGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterGB.Location = new System.Drawing.Point(29, 28);
            this.FillterGB.Margin = new System.Windows.Forms.Padding(4);
            this.FillterGB.Name = "FillterGB";
            this.FillterGB.Padding = new System.Windows.Forms.Padding(4);
            this.FillterGB.Size = new System.Drawing.Size(972, 107);
            this.FillterGB.TabIndex = 1;
            this.FillterGB.TabStop = false;
            this.FillterGB.Text = "Fillter";
            // 
            // AddPersonPB
            // 
            this.AddPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("AddPersonPB.Image")));
            this.AddPersonPB.Location = new System.Drawing.Point(924, 34);
            this.AddPersonPB.Margin = new System.Windows.Forms.Padding(4);
            this.AddPersonPB.Name = "AddPersonPB";
            this.AddPersonPB.Size = new System.Drawing.Size(40, 37);
            this.AddPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPersonPB.TabIndex = 12;
            this.AddPersonPB.TabStop = false;
            this.AddPersonPB.Click += new System.EventHandler(this.AddPersonPB_Click_1);
            // 
            // SearchPersonPB
            // 
            this.SearchPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("SearchPersonPB.Image")));
            this.SearchPersonPB.Location = new System.Drawing.Point(851, 34);
            this.SearchPersonPB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPersonPB.Name = "SearchPersonPB";
            this.SearchPersonPB.Size = new System.Drawing.Size(40, 37);
            this.SearchPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPersonPB.TabIndex = 11;
            this.SearchPersonPB.TabStop = false;
            this.SearchPersonPB.Click += new System.EventHandler(this.SearchPersonPB_Click_1);
            // 
            // FillterTB
            // 
            this.FillterTB.Location = new System.Drawing.Point(315, 33);
            this.FillterTB.Margin = new System.Windows.Forms.Padding(4);
            this.FillterTB.MinimumSize = new System.Drawing.Size(180, 29);
            this.FillterTB.Multiline = true;
            this.FillterTB.Name = "FillterTB";
            this.FillterTB.Size = new System.Drawing.Size(215, 29);
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
            this.FillterCB.Location = new System.Drawing.Point(131, 33);
            this.FillterCB.Margin = new System.Windows.Forms.Padding(4);
            this.FillterCB.Name = "FillterCB";
            this.FillterCB.Size = new System.Drawing.Size(160, 28);
            this.FillterCB.TabIndex = 9;
            this.FillterCB.SelectedIndexChanged += new System.EventHandler(this.FillterCB_SelectedIndexChanged_1);
            // 
            // FillterByLabel
            // 
            this.FillterByLabel.AutoSize = true;
            this.FillterByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterByLabel.Location = new System.Drawing.Point(8, 33);
            this.FillterByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FillterByLabel.Name = "FillterByLabel";
            this.FillterByLabel.Size = new System.Drawing.Size(87, 20);
            this.FillterByLabel.TabIndex = 8;
            this.FillterByLabel.Text = "Filter By:";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 143);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(1013, 421);
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
            this.LoginInfoTab.Location = new System.Drawing.Point(4, 25);
            this.LoginInfoTab.Margin = new System.Windows.Forms.Padding(4);
            this.LoginInfoTab.Name = "LoginInfoTab";
            this.LoginInfoTab.Padding = new System.Windows.Forms.Padding(4);
            this.LoginInfoTab.Size = new System.Drawing.Size(1015, 610);
            this.LoginInfoTab.TabIndex = 1;
            this.LoginInfoTab.Text = "Login Info";
            this.LoginInfoTab.UseVisualStyleBackColor = true;
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveCB.Location = new System.Drawing.Point(272, 300);
            this.IsActiveCB.Margin = new System.Windows.Forms.Padding(4);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(104, 24);
            this.IsActiveCB.TabIndex = 26;
            this.IsActiveCB.Text = "Is Active";
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(272, 246);
            this.ConfirmPasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(184, 22);
            this.ConfirmPasswordTB.TabIndex = 25;
            this.ConfirmPasswordTB.Validating += new System.ComponentModel.CancelEventHandler(this.ConfirmPasswordTB_Validating_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(217, 244);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(20, 249);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(169, 20);
            this.ConfirmPasswordLabel.TabIndex = 23;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(272, 194);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(184, 22);
            this.PasswordTB.TabIndex = 22;
            this.PasswordTB.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTB_Validating_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 192);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(100, 197);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 20);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(272, 142);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(184, 22);
            this.UserNameTB.TabIndex = 19;
            this.UserNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTB_Validating_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(85, 144);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(109, 20);
            this.UserNameLabel.TabIndex = 17;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserIDValue
            // 
            this.UserIDValue.AutoSize = true;
            this.UserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDValue.Location = new System.Drawing.Point(272, 90);
            this.UserIDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIDValue.Name = "UserIDValue";
            this.UserIDValue.Size = new System.Drawing.Size(40, 20);
            this.UserIDValue.TabIndex = 16;
            this.UserIDValue.Text = "N/A";
            // 
            // PersonIDPB
            // 
            this.PersonIDPB.Image = ((System.Drawing.Image)(resources.GetObject("PersonIDPB.Image")));
            this.PersonIDPB.Location = new System.Drawing.Point(217, 85);
            this.PersonIDPB.Margin = new System.Windows.Forms.Padding(4);
            this.PersonIDPB.Name = "PersonIDPB";
            this.PersonIDPB.Size = new System.Drawing.Size(33, 26);
            this.PersonIDPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonIDPB.TabIndex = 15;
            this.PersonIDPB.TabStop = false;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.Location = new System.Drawing.Point(120, 90);
            this.UserIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(80, 20);
            this.UserIDLabel.TabIndex = 14;
            this.UserIDLabel.Text = "User ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 752);
            this.Controls.Add(this.AddEditUserLabel);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.TabControlWindow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditUserForm";
            this.Text = "AddEditUserForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserIDValue;
        private System.Windows.Forms.PictureBox PersonIDPB;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}