using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ShowPersonDetailsForm : Form
    {
        public delegate void TriggerEventHandler(clsPerson person = null);
        public event TriggerEventHandler EventTrigger;

        private clsPerson _Person;

        public ShowPersonDetailsForm(clsPerson person)
        {
            InitializeComponent();
            _Person = person;
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.HandleDataReceived(_Person);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            EventTrigger?.Invoke();
            this.Close();
        }

        private void ShowPersonDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
