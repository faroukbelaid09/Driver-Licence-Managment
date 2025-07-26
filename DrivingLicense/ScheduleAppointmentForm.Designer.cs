namespace DrivingLicense
{
    partial class ScheduleAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleAppointmentForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.ctrlDrivingLicenseApplicationInfo1 = new DrivingLicense.ctrlDrivingLicenseApplicationInfo();
            this.AppoitmentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TestAppointmentsGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.RecordValue = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestAppointmentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(119, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(130, 56);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(255, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(274, 26);
            this.Title.TabIndex = 1;
            this.Title.Text = "Desired Test Appoitment";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 63);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(737, 384);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 2;
            this.ctrlDrivingLicenseApplicationInfo1.Load += new System.EventHandler(this.ctrlDrivingLicenseApplicationInfo1_Load);
            // 
            // AppoitmentLabel
            // 
            this.AppoitmentLabel.AutoSize = true;
            this.AppoitmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppoitmentLabel.Location = new System.Drawing.Point(23, 453);
            this.AppoitmentLabel.Name = "AppoitmentLabel";
            this.AppoitmentLabel.Size = new System.Drawing.Size(102, 17);
            this.AppoitmentLabel.TabIndex = 3;
            this.AppoitmentLabel.Text = "Appoitments:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TestAppointmentsGridView
            // 
            this.TestAppointmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestAppointmentsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TestAppointmentsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TestAppointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestAppointmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLooked});
            this.TestAppointmentsGridView.Location = new System.Drawing.Point(16, 473);
            this.TestAppointmentsGridView.Name = "TestAppointmentsGridView";
            this.TestAppointmentsGridView.Size = new System.Drawing.Size(733, 119);
            this.TestAppointmentsGridView.TabIndex = 5;
            // 
            // AppointmentID
            // 
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            // 
            // PaidFees
            // 
            this.PaidFees.HeaderText = "Paid Fees";
            this.PaidFees.Name = "PaidFees";
            this.PaidFees.ReadOnly = true;
            // 
            // IsLooked
            // 
            this.IsLooked.HeaderText = "Is Looked";
            this.IsLooked.Name = "IsLooked";
            this.IsLooked.ReadOnly = true;
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLabel.Location = new System.Drawing.Point(23, 604);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(74, 17);
            this.RecordLabel.TabIndex = 6;
            this.RecordLabel.Text = "#Record:";
            // 
            // RecordValue
            // 
            this.RecordValue.AutoSize = true;
            this.RecordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordValue.Location = new System.Drawing.Point(103, 604);
            this.RecordValue.Name = "RecordValue";
            this.RecordValue.Size = new System.Drawing.Size(34, 17);
            this.RecordValue.TabIndex = 7;
            this.RecordValue.Text = "N/A";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.Location = new System.Drawing.Point(674, 598);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 28);
            this.CloseBTN.TabIndex = 8;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 635);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.RecordValue);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.TestAppointmentsGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppoitmentLabel);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox);
            this.Name = "ScheduleAppointmentForm";
            this.Text = "ScheduleAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestAppointmentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Title;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label AppoitmentLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TestAppointmentsGridView;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.Label RecordValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLooked;
        private System.Windows.Forms.Button CloseBTN;
    }
}