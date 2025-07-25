﻿namespace DrivingLicense
{
    partial class PeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PagePB = new System.Windows.Forms.PictureBox();
            this.PageTitle = new System.Windows.Forms.Label();
            this.FillterByLabel = new System.Windows.Forms.Label();
            this.FillterCB = new System.Windows.Forms.ComboBox();
            this.PeopleDataGridView = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPersonPB = new System.Windows.Forms.PictureBox();
            this.FillterTB = new System.Windows.Forms.TextBox();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.RecordValue = new System.Windows.Forms.Label();
            this.CloseFormBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePB
            // 
            this.PagePB.Image = ((System.Drawing.Image)(resources.GetObject("PagePB.Image")));
            this.PagePB.Location = new System.Drawing.Point(221, 12);
            this.PagePB.Name = "PagePB";
            this.PagePB.Size = new System.Drawing.Size(512, 190);
            this.PagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PagePB.TabIndex = 0;
            this.PagePB.TabStop = false;
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.PageTitle.Location = new System.Drawing.Point(397, 214);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(157, 24);
            this.PageTitle.TabIndex = 1;
            this.PageTitle.Text = "Manage People";
            // 
            // FillterByLabel
            // 
            this.FillterByLabel.AutoSize = true;
            this.FillterByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterByLabel.Location = new System.Drawing.Point(24, 268);
            this.FillterByLabel.Name = "FillterByLabel";
            this.FillterByLabel.Size = new System.Drawing.Size(73, 17);
            this.FillterByLabel.TabIndex = 2;
            this.FillterByLabel.Text = "Filter By:";
            // 
            // FillterCB
            // 
            this.FillterCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterCB.FormattingEnabled = true;
            this.FillterCB.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.FillterCB.Location = new System.Drawing.Point(116, 268);
            this.FillterCB.Name = "FillterCB";
            this.FillterCB.Size = new System.Drawing.Size(121, 24);
            this.FillterCB.TabIndex = 3;
            this.FillterCB.SelectedIndexChanged += new System.EventHandler(this.FillterCB_SelectedIndexChanged);
            // 
            // PeopleDataGridView
            // 
            this.PeopleDataGridView.AllowUserToAddRows = false;
            this.PeopleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PeopleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.NationalNo,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.DateOfBirth,
            this.Nationality,
            this.Phone,
            this.Email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PeopleDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.PeopleDataGridView.Location = new System.Drawing.Point(27, 305);
            this.PeopleDataGridView.Name = "PeopleDataGridView";
            this.PeopleDataGridView.ReadOnly = true;
            this.PeopleDataGridView.RowHeadersWidth = 51;
            this.PeopleDataGridView.Size = new System.Drawing.Size(863, 171);
            this.PeopleDataGridView.TabIndex = 5;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.MinimumWidth = 6;
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "GenderTitle";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "CountryName";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.MinimumWidth = 6;
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // AddPersonPB
            // 
            this.AddPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("AddPersonPB.Image")));
            this.AddPersonPB.Location = new System.Drawing.Point(860, 259);
            this.AddPersonPB.Name = "AddPersonPB";
            this.AddPersonPB.Size = new System.Drawing.Size(30, 30);
            this.AddPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPersonPB.TabIndex = 6;
            this.AddPersonPB.TabStop = false;
            this.AddPersonPB.Click += new System.EventHandler(this.AddPersonPB_Click);
            this.AddPersonPB.MouseHover += new System.EventHandler(this.AddPersonPB_MouseHover);
            // 
            // FillterTB
            // 
            this.FillterTB.Location = new System.Drawing.Point(254, 268);
            this.FillterTB.MinimumSize = new System.Drawing.Size(136, 24);
            this.FillterTB.Multiline = true;
            this.FillterTB.Name = "FillterTB";
            this.FillterTB.Size = new System.Drawing.Size(162, 24);
            this.FillterTB.TabIndex = 7;
            this.FillterTB.TextChanged += new System.EventHandler(this.FillterTB_TextChanged);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(167, 160);
            this.ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.showDetailsToolStripMenuItem.Tag = "";
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addNewPersonToolStripMenuItem.Tag = "";
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.editToolStripMenuItem.Tag = "";
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.deleteToolStripMenuItem.Tag = "";
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.sendEmailToolStripMenuItem.Tag = "";
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.phoneCallToolStripMenuItem.Tag = "";
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLabel.Location = new System.Drawing.Point(24, 500);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(74, 17);
            this.RecordLabel.TabIndex = 9;
            this.RecordLabel.Text = "#Record:";
            // 
            // RecordValue
            // 
            this.RecordValue.AutoSize = true;
            this.RecordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordValue.Location = new System.Drawing.Point(104, 500);
            this.RecordValue.Name = "RecordValue";
            this.RecordValue.Size = new System.Drawing.Size(35, 17);
            this.RecordValue.TabIndex = 10;
            this.RecordValue.Text = "???";
            // 
            // CloseFormBTN
            // 
            this.CloseFormBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormBTN.Location = new System.Drawing.Point(814, 493);
            this.CloseFormBTN.Name = "CloseFormBTN";
            this.CloseFormBTN.Size = new System.Drawing.Size(75, 30);
            this.CloseFormBTN.TabIndex = 11;
            this.CloseFormBTN.Text = "Close";
            this.CloseFormBTN.UseVisualStyleBackColor = true;
            this.CloseFormBTN.Click += new System.EventHandler(this.CloseFormBTN_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 565);
            this.Controls.Add(this.CloseFormBTN);
            this.Controls.Add(this.RecordValue);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.FillterTB);
            this.Controls.Add(this.AddPersonPB);
            this.Controls.Add(this.PeopleDataGridView);
            this.Controls.Add(this.FillterCB);
            this.Controls.Add(this.FillterByLabel);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.PagePB);
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PagePB;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Label FillterByLabel;
        private System.Windows.Forms.ComboBox FillterCB;
        private System.Windows.Forms.DataGridView PeopleDataGridView;
        private System.Windows.Forms.PictureBox AddPersonPB;
        private System.Windows.Forms.TextBox FillterTB;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.Label RecordValue;
        private System.Windows.Forms.Button CloseFormBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}