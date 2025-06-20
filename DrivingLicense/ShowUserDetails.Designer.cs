namespace DrivingLicense
{
    partial class ShowUserDetails
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
            this.ctrlPersonInfo1 = new DrivingLicense.ctrlPersonInfo();
            this.LoginInfoGB = new System.Windows.Forms.GroupBox();
            this.IsActiveValue = new System.Windows.Forms.Label();
            this.IsActiveLabel = new System.Windows.Forms.Label();
            this.UserNameValue = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserIDValue = new System.Windows.Forms.Label();
            this.UserIDLable = new System.Windows.Forms.Label();
            this.LoginInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(3, 12);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(756, 339);
            this.ctrlPersonInfo1.TabIndex = 0;
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // LoginInfoGB
            // 
            this.LoginInfoGB.Controls.Add(this.IsActiveValue);
            this.LoginInfoGB.Controls.Add(this.IsActiveLabel);
            this.LoginInfoGB.Controls.Add(this.UserNameValue);
            this.LoginInfoGB.Controls.Add(this.UserNameLabel);
            this.LoginInfoGB.Controls.Add(this.UserIDValue);
            this.LoginInfoGB.Controls.Add(this.UserIDLable);
            this.LoginInfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfoGB.Location = new System.Drawing.Point(25, 357);
            this.LoginInfoGB.Name = "LoginInfoGB";
            this.LoginInfoGB.Size = new System.Drawing.Size(734, 100);
            this.LoginInfoGB.TabIndex = 1;
            this.LoginInfoGB.TabStop = false;
            this.LoginInfoGB.Text = "Login Info";
            // 
            // IsActiveValue
            // 
            this.IsActiveValue.AutoSize = true;
            this.IsActiveValue.Location = new System.Drawing.Point(551, 45);
            this.IsActiveValue.Name = "IsActiveValue";
            this.IsActiveValue.Size = new System.Drawing.Size(34, 17);
            this.IsActiveValue.TabIndex = 5;
            this.IsActiveValue.Text = "N/A";
            // 
            // IsActiveLabel
            // 
            this.IsActiveLabel.AutoSize = true;
            this.IsActiveLabel.Location = new System.Drawing.Point(461, 45);
            this.IsActiveLabel.Name = "IsActiveLabel";
            this.IsActiveLabel.Size = new System.Drawing.Size(84, 17);
            this.IsActiveLabel.TabIndex = 4;
            this.IsActiveLabel.Text = "Is Active : ";
            // 
            // UserNameValue
            // 
            this.UserNameValue.AutoSize = true;
            this.UserNameValue.Location = new System.Drawing.Point(371, 45);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Size = new System.Drawing.Size(34, 17);
            this.UserNameValue.TabIndex = 3;
            this.UserNameValue.Text = "N/A";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(267, 45);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(98, 17);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "User Name: ";
            // 
            // UserIDValue
            // 
            this.UserIDValue.AutoSize = true;
            this.UserIDValue.Location = new System.Drawing.Point(177, 45);
            this.UserIDValue.Name = "UserIDValue";
            this.UserIDValue.Size = new System.Drawing.Size(34, 17);
            this.UserIDValue.TabIndex = 1;
            this.UserIDValue.Text = "N/A";
            // 
            // UserIDLable
            // 
            this.UserIDLable.AutoSize = true;
            this.UserIDLable.Location = new System.Drawing.Point(99, 45);
            this.UserIDLable.Name = "UserIDLable";
            this.UserIDLable.Size = new System.Drawing.Size(72, 17);
            this.UserIDLable.TabIndex = 0;
            this.UserIDLable.Text = "User ID: ";
            // 
            // ShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.LoginInfoGB);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "ShowUserDetails";
            this.Text = "ShowUserDetails";
            this.Load += new System.EventHandler(this.ShowUserDetails_Load);
            this.LoginInfoGB.ResumeLayout(false);
            this.LoginInfoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox LoginInfoGB;
        private System.Windows.Forms.Label IsActiveValue;
        private System.Windows.Forms.Label IsActiveLabel;
        private System.Windows.Forms.Label UserNameValue;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserIDValue;
        private System.Windows.Forms.Label UserIDLable;
    }
}