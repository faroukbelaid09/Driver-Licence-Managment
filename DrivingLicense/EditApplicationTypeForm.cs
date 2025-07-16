using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class EditApplitionTypeForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;
        clsApplicationType _clsApplicationType;

        private void LoadInitialData(clsApplicationType app)
        {
            IDValue.Text = app.ApplicationTypeID.ToString();
            TitleTB.Text = app.ApplicationTypeTitle;
            FeesTB.Text = app.ApplicationFees.ToString();
        }
        
        private bool UpdateApplication()
        {
            return _clsApplicationType.Update();
            
        }
        public EditApplitionTypeForm(clsApplicationType application)
        {
            InitializeComponent();

            LoadInitialData(application);
            _clsApplicationType = application;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string AppTitle = TitleTB.Text.Trim();
            int AppFees = Convert.ToInt32(FeesTB.Text.Trim());

            if (!string.IsNullOrEmpty(AppTitle) && !string.IsNullOrEmpty(AppFees.ToString()))
            {
                _clsApplicationType.ApplicationTypeTitle = AppTitle;
                _clsApplicationType.ApplicationFees = AppFees;

                if (UpdateApplication())
                {
                    MessageBox.Show("Application Updated Successfully!","Update!");
                    EventTrigger?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred when updating the Application!", "Error");
                }
            }
            else
            {
                MessageBox.Show("All field must be filled!", "Error!");
            }
            
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
