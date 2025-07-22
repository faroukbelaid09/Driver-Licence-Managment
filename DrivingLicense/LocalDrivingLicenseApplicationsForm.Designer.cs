namespace DrivingLicense
{
    partial class LocalDrivingLicenseApplicationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CloseFormBTN = new System.Windows.Forms.Button();
            this.RecordValue = new System.Windows.Forms.Label();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.FillterTB = new System.Windows.Forms.TextBox();
            this.AddPersonPB = new System.Windows.Forms.PictureBox();
            this.LocalAppDataGridView = new System.Windows.Forms.DataGridView();
            this.LocalDrivingLicenseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillterCB = new System.Windows.Forms.ComboBox();
            this.FillterByLabel = new System.Windows.Forms.Label();
            this.PageTitle = new System.Windows.Forms.Label();
            this.PagePB = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalAppDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePB)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormBTN
            // 
            this.CloseFormBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormBTN.Location = new System.Drawing.Point(917, 532);
            this.CloseFormBTN.Name = "CloseFormBTN";
            this.CloseFormBTN.Size = new System.Drawing.Size(75, 30);
            this.CloseFormBTN.TabIndex = 21;
            this.CloseFormBTN.Text = "Close";
            this.CloseFormBTN.UseVisualStyleBackColor = true;
            this.CloseFormBTN.Click += new System.EventHandler(this.CloseFormBTN_Click);
            // 
            // RecordValue
            // 
            this.RecordValue.AutoSize = true;
            this.RecordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordValue.Location = new System.Drawing.Point(133, 539);
            this.RecordValue.Name = "RecordValue";
            this.RecordValue.Size = new System.Drawing.Size(35, 17);
            this.RecordValue.TabIndex = 20;
            this.RecordValue.Text = "???";
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLabel.Location = new System.Drawing.Point(53, 539);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(74, 17);
            this.RecordLabel.TabIndex = 19;
            this.RecordLabel.Text = "#Record:";
            // 
            // FillterTB
            // 
            this.FillterTB.Location = new System.Drawing.Point(274, 311);
            this.FillterTB.MinimumSize = new System.Drawing.Size(136, 24);
            this.FillterTB.Multiline = true;
            this.FillterTB.Name = "FillterTB";
            this.FillterTB.Size = new System.Drawing.Size(162, 24);
            this.FillterTB.TabIndex = 18;
            // 
            // AddPersonPB
            // 
            this.AddPersonPB.Image = ((System.Drawing.Image)(resources.GetObject("AddPersonPB.Image")));
            this.AddPersonPB.Location = new System.Drawing.Point(962, 298);
            this.AddPersonPB.Name = "AddPersonPB";
            this.AddPersonPB.Size = new System.Drawing.Size(30, 30);
            this.AddPersonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPersonPB.TabIndex = 17;
            this.AddPersonPB.TabStop = false;
            this.AddPersonPB.Click += new System.EventHandler(this.AddPersonPB_Click);
            // 
            // LocalAppDataGridView
            // 
            this.LocalAppDataGridView.AllowUserToAddRows = false;
            this.LocalAppDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalAppDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocalAppDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LocalAppDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalAppDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalDrivingLicenseApplicationID,
            this.DrivingClass,
            this.NationalNo,
            this.FullName,
            this.ApplicationDate,
            this.PassedTests,
            this.ApplicationStatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalAppDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.LocalAppDataGridView.Location = new System.Drawing.Point(38, 344);
            this.LocalAppDataGridView.Name = "LocalAppDataGridView";
            this.LocalAppDataGridView.ReadOnly = true;
            this.LocalAppDataGridView.RowHeadersWidth = 51;
            this.LocalAppDataGridView.Size = new System.Drawing.Size(954, 171);
            this.LocalAppDataGridView.TabIndex = 16;
            // 
            // LocalDrivingLicenseApplicationID
            // 
            this.LocalDrivingLicenseApplicationID.DataPropertyName = "LocalDrivingLicenseApplicationID";
            this.LocalDrivingLicenseApplicationID.HeaderText = "L.D.L AppID";
            this.LocalDrivingLicenseApplicationID.MinimumWidth = 6;
            this.LocalDrivingLicenseApplicationID.Name = "LocalDrivingLicenseApplicationID";
            this.LocalDrivingLicenseApplicationID.ReadOnly = true;
            // 
            // DrivingClass
            // 
            this.DrivingClass.DataPropertyName = "DrivingClass";
            this.DrivingClass.HeaderText = "Driving Class";
            this.DrivingClass.MinimumWidth = 6;
            this.DrivingClass.Name = "DrivingClass";
            this.DrivingClass.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.MinimumWidth = 6;
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            // 
            // PassedTests
            // 
            this.PassedTests.DataPropertyName = "PassedTests";
            this.PassedTests.HeaderText = "Passed Tests";
            this.PassedTests.MinimumWidth = 6;
            this.PassedTests.Name = "PassedTests";
            this.PassedTests.ReadOnly = true;
            // 
            // ApplicationStatus
            // 
            this.ApplicationStatus.DataPropertyName = "ApplicationStatus";
            this.ApplicationStatus.HeaderText = "Application Status";
            this.ApplicationStatus.MinimumWidth = 6;
            this.ApplicationStatus.Name = "ApplicationStatus";
            this.ApplicationStatus.ReadOnly = true;
            // 
            // FillterCB
            // 
            this.FillterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FillterCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterCB.FormattingEnabled = true;
            this.FillterCB.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No",
            "Full Name",
            "Status"});
            this.FillterCB.Location = new System.Drawing.Point(136, 311);
            this.FillterCB.Name = "FillterCB";
            this.FillterCB.Size = new System.Drawing.Size(121, 24);
            this.FillterCB.TabIndex = 15;
            this.FillterCB.SelectedIndexChanged += new System.EventHandler(this.FillterCB_SelectedIndexChanged);
            // 
            // FillterByLabel
            // 
            this.FillterByLabel.AutoSize = true;
            this.FillterByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillterByLabel.Location = new System.Drawing.Point(44, 311);
            this.FillterByLabel.Name = "FillterByLabel";
            this.FillterByLabel.Size = new System.Drawing.Size(73, 17);
            this.FillterByLabel.TabIndex = 14;
            this.FillterByLabel.Text = "Filter By:";
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.PageTitle.Location = new System.Drawing.Point(349, 251);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(342, 24);
            this.PageTitle.TabIndex = 13;
            this.PageTitle.Text = "Local Driving Lincense Applications";
            // 
            // PagePB
            // 
            this.PagePB.Image = ((System.Drawing.Image)(resources.GetObject("PagePB.Image")));
            this.PagePB.Location = new System.Drawing.Point(434, 36);
            this.PagePB.Name = "PagePB";
            this.PagePB.Size = new System.Drawing.Size(195, 190);
            this.PagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PagePB.TabIndex = 12;
            this.PagePB.TabStop = false;
            this.PagePB.Click += new System.EventHandler(this.PagePB_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // LocalDrivingLicenseApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.CloseFormBTN);
            this.Controls.Add(this.RecordValue);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.FillterTB);
            this.Controls.Add(this.AddPersonPB);
            this.Controls.Add(this.LocalAppDataGridView);
            this.Controls.Add(this.FillterCB);
            this.Controls.Add(this.FillterByLabel);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.PagePB);
            this.Name = "LocalDrivingLicenseApplicationsForm";
            this.Text = "LocalDrivingLicenseApplicationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.AddPersonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalAppDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagePB)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormBTN;
        private System.Windows.Forms.Label RecordValue;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.TextBox FillterTB;
        private System.Windows.Forms.PictureBox AddPersonPB;
        private System.Windows.Forms.DataGridView LocalAppDataGridView;
        private System.Windows.Forms.ComboBox FillterCB;
        private System.Windows.Forms.Label FillterByLabel;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.PictureBox PagePB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalDrivingLicenseApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}