using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class AddEditUserForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;
        enum Mode {enAdd, enEdit}
        
        Mode _mode;
        clsPerson _person;
        clsUser _user;

        private void ResetTabControl()
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
        private void ResetFilterGB()
        {
            FillterGB.Enabled = false;
        }
        private bool checkIfUserExist(int personID)
        {
            return clsUser.CheckIfUserExist(personID);
        }
        private void loadPersonData(clsPerson person)
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
        private void _UpdateFormTitle()
        {
            if (_mode == Mode.enEdit) {
                AddEditUserLabel.Text = "Edit User";
            }
            else
            {
                AddEditUserLabel.Text = "Add New User";
            }
        }
        
        
        // IN edit mode load old user login data to the textboxes
        private void loadOldLoginData(clsUser oldUser)
        {
            UserNameTB.Text = oldUser.UserName;
            PasswordTB.Text = oldUser.Password;
            ConfirmPasswordTB.Text = oldUser.Password;
            IsActiveCB.Checked = oldUser.IsActive;
        }


        // ADDING A NEW USER
        private void AddNewUser()
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
                        _user.PersonID = _person.PersonID;
                        _user.Password = password;
                        _user.UserName = username;
                        _user.IsActive = isActive;

                        int userID = _user.Add();
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

        // UPDATING OLD USER
        private void UpdateUser()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = UserNameTB.Text.Trim();
                string password = PasswordTB.Text.Trim();
                string confirmedPassword = ConfirmPasswordTB.Text.Trim();
                bool isActive = IsActiveCB.Checked ? true : false;

                if (password == confirmedPassword)
                {
                    _user.UserName = username;
                    _user.IsActive = isActive;
                    _user.Password = password;

                    if (_user.Update())
                    {
                        DialogResult res = MessageBox.Show("User updated successfully!", "Update User!", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            EventTrigger?.Invoke();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("An error occured when updating user.", "Update User!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your password correctly!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("An error occured when updating user.", "Update User!", MessageBoxButtons.OK);

            }
        }


        public AddEditUserForm()
        {
            InitializeComponent();
            ResetTabControl();
            ResetComboBox();
            ResetButtonState();

            _user = new clsUser();
            _mode = Mode.enAdd;
        }
        public AddEditUserForm(clsUser user)
        {
            InitializeComponent();
            ResetFilterGB();
            ResetTabControl();
            ResetComboBox();
            ResetButtonState();
            _mode = Mode.enEdit;

            _user = user;
            _person = clsPerson.FindPersonByID(_user.PersonID);
            
            _UpdateFormTitle();
            loadPersonData(_person);
            loadOldLoginData(_user);
        }

        private void AddPersonPB_Click_1(object sender, EventArgs e)
        {
            AddEditForm frm = new AddEditForm();
            frm.EventTrigger += loadPersonData;
            frm.Show();
        }

        private void SearchPersonPB_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Invalid Person ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillterCB_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void TabControlWindow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TabControlWindow.SelectedIndex == 0)
            {
                SaveBTN.Enabled = false;
            }
            else
            {
                SaveBTN.Enabled = true;
            }
        }

        // BUTTONS
        private void NextBTN_Click_1(object sender, EventArgs e)
        {
            if(_mode == Mode.enEdit)
            {
                TabControlWindow.SelectedIndex = 1;
            }
            else
            {
                if (!checkIfUserExist(_person.PersonID))
                {
                    TabControlWindow.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("This person is already a user. please choose another one!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBTN_Click_1(object sender, EventArgs e)
        {
            if (_mode == Mode.enEdit)
            {
                UpdateUser();
            }
            else
            {
                AddNewUser();
            }
        }

        private void CloseBTN_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNameTB_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(UserNameTB);
        }

        private void PasswordTB_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(PasswordTB);
        }

        private void ConfirmPasswordTB_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(ConfirmPasswordTB);
        }
    }
}
