using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class EditTestTypeForm : Form
    {

        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;
        clsTestType _clsTestType;

        private void LoadInitialData(clsTestType test)
        {
            IDValue.Text = test.TestTypeID.ToString();
            TitleTB.Text = test.TestTypeTitle;
            DescriptionTB.Text = test.TestTypeDescription;
            FeesTB.Text = test.TestTypeFees.ToString();
        }

        private bool UpdateTest()
        {
            return _clsTestType.Update();

        }

        public EditTestTypeForm(clsTestType testType)
        {
            InitializeComponent();

            LoadInitialData(testType);
            _clsTestType = testType;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string TestTitle = TitleTB.Text.Trim();
            string TestDescription = TitleTB.Text.Trim();
            int TestFees = Convert.ToInt32(FeesTB.Text.Trim());

            if (!string.IsNullOrEmpty(TestTitle) && !string.IsNullOrEmpty(TestFees.ToString()) && !string.IsNullOrEmpty(TestDescription))
            {
                _clsTestType.TestTypeTitle = TestTitle;
                _clsTestType.TestTypeDescription = TestDescription;
                _clsTestType.TestTypeFees = TestFees;

                if (UpdateTest())
                {
                    MessageBox.Show("Test Updated Successfully!", "Update!");
                    EventTrigger?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred when updating the Test!", "Error");
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
