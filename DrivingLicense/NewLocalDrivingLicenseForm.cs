using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class NewLocalDrivingLicenseForm : Form
    {
        private int _APPLICATION_ID = -1;
        private int _APPLICATION_FEE = 15;
        private int _APPLICATION_TYPE_ID = 1;
        private int _APPLICATION_STATUS = 1;

        private clsPerson _person;
        private clsApplication _application;
        private clsLocalDrivingLicenseApplication _localApplication;

        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        private void _ResetFilterComboSettings()
        {
            FillterCB.SelectedIndex = 0;
        }

        private void _ResetFilterTextBoxSettings()
        {
            if (FillterCB.SelectedIndex == 0)
            {
                FillterTB.Visible = false;
            }
            else
            {
                FillterTB.Visible = true;
            }
        }

        private void _LoadPerson(clsPerson person)
        {
            if (person != null)
            {
                _person = person;
                ctrlPersonInfo1.HandleDataReceived(_person);
                NextBTN.Enabled = true;
            }
            else
            {
                MessageBox.Show("This person does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _AddApplicationAuthor()
        {
            CreatedbyValue.Text = ApplicationState.CurrentUser.UserName;
        }

        private void _AddApplicationCurrentDate()
        {
            ApplicationDateValue.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        
        private void _AddApplicationFee()
        {
            ApplicationFeeValue.Text = _APPLICATION_FEE.ToString();
        }

        private void _GetClassesNames()
        {
            List<string> classesNames = clsLicenseClass.GetClassesNames();
            if(classesNames != null)
            {
                LicenseClassCB.DataSource = classesNames;
            }
        }
        
        private bool _CheckIfApplicationExist(string personNationalNo,string drivingClass)
        {
            return clsApplication.CheckIfApplicationExist(personNationalNo, drivingClass);
        }
        private bool _AddNewLocalApplication()
        {
            string appDate = ApplicationDateValue.Text;
            int licenseClassID = LicenseClassCB.SelectedIndex+1;

            if (!_CheckIfApplicationExist(_person.NationalNo, LicenseClassCB.Text))
            {

                _application = clsApplication.Create(_person.PersonID, appDate, _APPLICATION_TYPE_ID, _APPLICATION_STATUS,
                appDate, _APPLICATION_FEE, ApplicationState.CurrentUser.UserID);

                if (_application != null)
                {
                    _localApplication = clsLocalDrivingLicenseApplication.Create(_application.ApplicationID, licenseClassID);
                    if (_localApplication != null)
                    {
                        ApplicationIDValue.Text = _localApplication.LocalDrivingLicenseApplicationID.ToString();

                        MessageBox.Show("Local application was successfully created!", "Local Application",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("An error occured when creating a local application.", "Local Application",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("An error occured when creating the application.", "Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("An application for this user with license class already exist!", "Local Application",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public NewLocalDrivingLicenseForm()
        {
            InitializeComponent();

            _ResetFilterComboSettings();
            _ResetFilterTextBoxSettings();
            _GetClassesNames();
        }

        private void SearchPersonPB_Click(object sender, EventArgs e)
        {
            string searchText = FillterTB.Text.Trim();

            if(!string.IsNullOrEmpty(searchText))
            {
                var isNumeric = int.TryParse(searchText, out int id);
                if (FillterCB.SelectedIndex == 1)
                {
                    if (isNumeric)
                    {
                        _person = clsPerson.FindPersonByID(Convert.ToInt32(id));
                        _LoadPerson(_person);
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (FillterCB.SelectedIndex == 2)
                {
                    _person = clsPerson.FindPersonByNationalNo(searchText);
                    _LoadPerson(_person);
                }
            }
            else
            {
                MessageBox.Show("This field cannot be empty!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FillterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ResetFilterTextBoxSettings();
        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddEditForm frm = new AddEditForm();
            frm.EventTrigger += _LoadPerson;
            frm.ShowDialog();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if(_person != null)
            {
                if(_AddNewLocalApplication())
                {
                    EventTrigger?.Invoke();
                    this.Close();
                }
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            TabControlWindow.SelectedIndex = 1;
        }

        private void TabControlWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlWindow.SelectedIndex == 0)
            {
                SaveBTN.Enabled = false;
            }
            else
            {
                SaveBTN.Enabled = true;
                _AddApplicationAuthor();
                _AddApplicationCurrentDate();
                _AddApplicationFee();
            }
        }
    }
}
