using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class AddUserForm : Form
    {

        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        clsPerson _person;
        clsUser _newUser;


        private void ResetTabControll()
        {
            
            TabControlWindow.SelectedIndex = 0;
        }
        private void ResetComboBox()
        {
            FillterCB.SelectedIndex = 0;

            if (FillterCB.SelectedIndex == 0)
            {
                FillterTB.Visible = false;
            }
        }
        private void ResetButtonState()
        {
            // disable save button
            SaveBTN.Enabled = false;

            // disable next button
            NextBTN.Enabled = false;
        }
        private bool checkIfUserExist(int personID)
        {
            return clsUser.CheckIfUserExist(personID);
        }
        private void loadNewPersonData(clsPerson person)
        {
            if (person != null) 
            {
                _person = person;
                ctrlPersonInfo1.HandleDataReceived(_person);
                NextBTN.Enabled = true;
            }
            
        }
        private void _EmptyValidator(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                errorProvider1.SetError(textBox, "Cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }
        public AddUserForm()
        {
            InitializeComponent();
            ResetTabControll();
            ResetComboBox();
            ResetButtonState();

            _newUser = new clsUser();
        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddEditForm frm = new AddEditForm();
            frm.EventTrigger += loadNewPersonData;
            frm.Show();
        }

        private void SearchPersonPB_Click(object sender, EventArgs e)
        {
            string textToSearch = FillterTB.Text;
            if (!string.IsNullOrEmpty(textToSearch) && int.TryParse(textToSearch, out int res)) 
            {  
                _person = clsPerson.FindPersonByID(res);
                if (_person != null)
                {
                    ctrlPersonInfo1.HandleDataReceived(_person);
                    NextBTN.Enabled = true;
                }
                else
                {
                    MessageBox.Show("A person with this ID does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Person ID", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FillterCB_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TabControlWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlWindow.SelectedIndex == 0) { 
                SaveBTN.Enabled = false;
            }
            else
            {
                SaveBTN.Enabled = true;
            }
        }

        // BUTTONS
        private void NextBTN_Click(object sender, EventArgs e)
        {
            if (!checkIfUserExist(_person.PersonID)) 
            {
                TabControlWindow.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("This person is already a user. please choose another one!", "Faild", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = UserNameTB.Text.Trim();
                string password = PasswordTB.Text.Trim();
                string confirmedPassword = ConfirmPasswordTB.Text.Trim();
                bool isActive = IsActiveCB.Checked ? true : false;

                if (password == confirmedPassword)
                {
                    if (_person != null && !checkIfUserExist(_person.PersonID))
                    {
                        int userID = _newUser.Add(_person.PersonID, username, password, isActive);
                        if (userID != -1)
                        {
                            UserIDValue.Text = userID.ToString();
                            DialogResult res = MessageBox.Show("User ID: " + userID.ToString(), "User Was added successfully!", MessageBoxButtons.OK);
                            if (res == DialogResult.OK)
                            {
                                EventTrigger?.Invoke();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("An error occurred when adding this user. please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occurred when adding this user. please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your password correctly!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNameTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(UserNameTB);
        }

        private void PasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(PasswordTB);
        }

        private void ConfirmPasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(ConfirmPasswordTB);
        }
    }
}