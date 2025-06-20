using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                UserGridView.AutoGenerateColumns = false;
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

        // RETURN THE SELECTED USER FROM THE MENU
        private clsUser GetTheSelectedUser()
        {
            // Get the selected row index from the ContextMenuStrip's Tag
            int rowIndex = (int)contextMenuStrip1.Tag;

            // Access the data of the selected row
            var selectedRow = UserGridView.Rows[rowIndex];
            clsUser user = selectedRow.DataBoundItem as clsUser;

            return user;
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
            AddEditUserForm frm = new AddEditUserForm();
            frm.EventTrigger += _DisplayUsers;
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Get the mouse position relative to the DataGridView
            var hitTest = UserGridView.HitTest(UserGridView.PointToClient(Cursor.Position).X,
                UserGridView.PointToClient(Cursor.Position).Y);

            // Check if the right-click was on a row
            if (hitTest.RowIndex >= 0)
            {
                // Store the selected row index in the ContextMenuStrip's Tag
                contextMenuStrip1.Tag = hitTest.RowIndex;
            }
            else
            {
                // Cancel the context menu if the right-click was not on a row
                e.Cancel = true;
            }
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

        // NAVIGATE TO THE SHOW DETAILS PAGE
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser selectedUser = GetTheSelectedUser();

            if (selectedUser != null) 
            { 
                ShowUserDetails frm = new ShowUserDetails(selectedUser);
                
                frm.ShowDialog();
            }
        }

        // NAVIGATE TO THE ADD NEW PERSON PAGE
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUserForm frm = new AddEditUserForm();
            frm.ShowDialog();
        }

        // NAVIGATE TO THE EDIT PERSON PAGE (WITH THE SELECTED PERSON INFO)
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser selectedUser = GetTheSelectedUser();
            if (selectedUser != null)
            {
                AddEditUserForm frm = new AddEditUserForm(selectedUser);
                frm.EventTrigger += _DisplayUsers;
                frm.ShowDialog();
            }
        }

        // DELETE THE SELECTED PERSON
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = GetTheSelectedUser();
            bool isDeleted = false;

            if (user != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    isDeleted = user.Delete();
                }

                if (isDeleted)
                {
                    //ProfilePictureHelper.DeleteOldImage(person.ImagePath);
                    MessageBox.Show("The user was deleted Successfully", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _DisplayUsers();
                }

                return;
            }
            MessageBox.Show("An error occured when deleting this user.", "Delete",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // SEND AN EMAIL TO THE SELECTED PERSON
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("outlookmail:");
        }
        // CALL THE SELECTED PERSON
        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available yet.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}