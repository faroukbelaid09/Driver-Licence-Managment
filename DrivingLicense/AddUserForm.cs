using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class AddUserForm : Form
    {
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
                Console.WriteLine("GENDER:::: " + _person.GenderID.ToString());
                ctrlPersonInfo1.HandleDataReceived(_person);
                NextBTN.Enabled = true;
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
            string username = UserNameTB.Text;
            string password = PasswordTB.Text;
            bool isactive = IsActiveCB.Checked ? true : false;


            if(_person != null && !checkIfUserExist(_person.PersonID))
            {
                int userid = _newUser.Add(_person.PersonID, username, password, isactive);
                if (userid != -1) 
                {
                    MessageBox.Show("User ID: " + userid.ToString(), "Done", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("An error acurred when adding this user. please try again.", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An error accurred when adding this user. please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}