using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class UserForm : Form
    {
        List<clsUser> _users;
        List<clsUser> _filteredUsers;

        public enum FillterOptions
        {
            UserID = 1, PersonID = 2, FullName = 3, UserName = 4, ISActive = 5
        };

        private void _ResetComboBoxSettings()
        {
            FillterCB.SelectedIndex = 0;
            FillterCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void _DisplayRecord(int number)
        {
            RecordValue.Text = number.ToString();
        }

        private void _DisplayUsers()
        {
            // Get All people
            _users = clsUser.GetAllUsers();
            
            if (_users != null && _users.Count > 0)
            {
                UserGridView.AutoGenerateColumns = true;
                UserGridView.DataSource = _users;

                // Find and replace the boolean column
                foreach (DataGridViewColumn column in UserGridView.Columns)
                {
                    if (column.DataPropertyName == "IsActive" && column is DataGridViewTextBoxColumn)
                    {
                        int columnIndex = column.Index;
                        UserGridView.Columns.Remove(column);

                        DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn()
                        {
                            DataPropertyName = "IsActive",
                            HeaderText = "Active",
                            Name = "colIsActive",
                            ReadOnly = true
                        };

                        UserGridView.Columns.Insert(columnIndex, checkColumn);
                        break;
                    }
                }

            }

            _DisplayRecord(_users.Count);
        }

        // DISPLAY FILLTRED PEOPLE
        private void _DisplayFilltredUsers()
        {
            if (_filteredUsers != null && _filteredUsers.Count > 0)
            {
                UserGridView.DataSource = null;
                UserGridView.DataSource = _filteredUsers;
            }
            else
            {
                UserGridView.DataSource = null;
            }
        }

        public UserForm()
        {
            InitializeComponent();
            _ResetComboBoxSettings();


            _DisplayUsers();
            
        }

        private void _Fillter(string FiltterText, FillterOptions fillterOption)
        {
            switch (fillterOption)
            {
                case FillterOptions.UserID:
                    _filteredUsers = _users.Where(user => user.UserID.ToString().ToLower().Equals(FiltterText)).ToList();
                    break;
                case FillterOptions.PersonID:
                    _filteredUsers = _users.Where(user => user.PersonID.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.FullName:
                    _filteredUsers = _users.Where(user => user.FullName.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.UserName:
                    _filteredUsers = _users.Where(user => user.UserName.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                default:
                    break;
            }
        }
        private void ApplyFillter(string filterText, FillterOptions FillterOption)
        {
            // Apply the filter
            if (string.IsNullOrEmpty(filterText))
            {
                // If the filter text is empty, show all data
                UserGridView.DataSource = _users;
                _DisplayRecord(_users.Count);
            }
            else
            {
                _Fillter(filterText, FillterOption);
                _DisplayFilltredUsers();
                _DisplayRecord(_filteredUsers.Count);
            }
        }
        
        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.EventTrigger += _DisplayUsers;
            frm.ShowDialog();
        }

        private void FillterCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FillterCB.SelectedIndex == 0 || FillterCB.SelectedIndex == 5)
            {
                FillterTB.Visible = false;
                
            }
            else
            {
                FillterTB.Visible = true;
            }

            if (FillterCB.SelectedIndex == 0)
            {
                _DisplayUsers();
                _DisplayRecord(_users.Count);
            }
            if(FillterCB.SelectedIndex == 5)
            {
                _filteredUsers = _users.Where(user => user.IsActive == true).ToList();
                _DisplayFilltredUsers();
                _DisplayRecord(_filteredUsers.Count);
            }
        }

        private void FillterTB_TextChanged_1(object sender, EventArgs e)
        {
            string filterText = FillterTB.Text.Trim().ToLower();

            switch (FillterCB.SelectedIndex)
            {
                case 1:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.UserID);
                    break;
                case 2:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.PersonID);
                    break;
                case 3:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.FullName);
                    break;
                case 4:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.UserName);
                    break;
                default:
                    break;
            }
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}