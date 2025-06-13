using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace DrivingLicense
{
    public partial class PeopleForm : Form
    {
        List<clsPerson> _people;
        List<clsPerson> _filteredPeople;

        public enum FillterOptions { PersonID=1, NationalNo=2,FirstName=3,LastName=4, Nationality=5,
        Gender=6,Phone=7,Email=8};

        // RESETING SETTINGS
        private void _ResetComboBoxSettings() {
            FillterCB.SelectedIndex = 0;
            FillterCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void _ResetDataGridViewSettings() {
            // Add ContextMenuStrip to PeopleDataGridView (Right click menu)
            PeopleDataGridView.ContextMenuStrip = ContextMenuStrip;

            // Disable auto-generated columns
            PeopleDataGridView.AutoGenerateColumns = false;
        }

        // DISPLAY RECORD (NUMBER OF PEOPLE)
        private void _DisplayRecord(int number)
        {
            RecordValue.Text = number.ToString();
        }

        // GET ALL PEOPLE
        private void _DisplayPeople(clsPerson person = null)
        {
            // Get All people
            _people = clsPerson.GetAllPeople();
            
            if (_people != null && _people.Count > 0)
            {
                PeopleDataGridView.DataSource = _people;
            }

            _DisplayRecord(_people.Count);
        }
        
        // DISPLAY FILLTRED PEOPLE
        private void _DisplayFilltredPeople() {
            if (_filteredPeople != null && _filteredPeople.Count > 0)
            {
                PeopleDataGridView.DataSource = null;
                PeopleDataGridView.DataSource = _filteredPeople;
            }
            else { 
                PeopleDataGridView.DataSource = null;
            }
        }
        
        // RETURN THE SELECTED PERSON FROM THE MENU
        private clsPerson GetTheSelectedPerson() {
            // Get the selected row index from the ContextMenuStrip's Tag
            int rowIndex = (int)ContextMenuStrip.Tag;

            // Access the data of the selected row
            var selectedRow = PeopleDataGridView.Rows[rowIndex];
            clsPerson person = selectedRow.DataBoundItem as clsPerson;

            return person;
        }
        
        public PeopleForm()
        {
            InitializeComponent();

            _ResetComboBoxSettings();

            _ResetDataGridViewSettings();

            _DisplayPeople();
        }
        
        private void _Fillter(string FiltterText, FillterOptions fillterOption)
        {
            switch (fillterOption)
            {
                case FillterOptions.PersonID:
                    _filteredPeople = _people.Where(person => person.PersonID.ToString().ToLower().Equals(FiltterText)).ToList();
                    break;
                case FillterOptions.NationalNo:
                    _filteredPeople = _people.Where(person => person.NationalNo.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.FirstName:
                    _filteredPeople = _people.Where(person => person.FirstName.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.LastName:
                    _filteredPeople = _people.Where(person => person.LastName.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.Nationality:
                    _filteredPeople = _people.Where(person => person.CountryID.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                case FillterOptions.Gender:
                    _filteredPeople = _people.Where(person => person.GenderTitle.ToString().ToLower().Equals(FiltterText)).ToList();
                    break;
                case FillterOptions.Phone:
                    _filteredPeople = _people.Where(person => person.Phone.ToString().ToLower().Contains(FiltterText)).ToList();
                    break ;
                case FillterOptions.Email:
                    _filteredPeople = _people.Where(person => person.Email.ToString().ToLower().Contains(FiltterText)).ToList();
                    break;
                default:
                    break;
            }
        }
        private void ApplyFillter(string filterText, FillterOptions FillterOption) {
            // Apply the filter
            if (string.IsNullOrEmpty(filterText))
            {
                // If the filter text is empty, show all data
                PeopleDataGridView.DataSource = _people;
                _DisplayRecord(_people.Count);
            }
            else
            {
                _Fillter(filterText, FillterOption);
                _DisplayFilltredPeople();
                _DisplayRecord(_filteredPeople.Count);
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
        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddEditForm AddFrm = new AddEditForm();
            AddFrm.EventTrigger += _DisplayPeople;
            AddFrm.ShowDialog();
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Get the mouse position relative to the DataGridView
            var hitTest = PeopleDataGridView.HitTest(PeopleDataGridView.PointToClient(Cursor.Position).X,
                PeopleDataGridView.PointToClient(Cursor.Position).Y);

            // Check if the right-click was on a row
            if (hitTest.RowIndex >= 0)
            {
                // Store the selected row index in the ContextMenuStrip's Tag
                ContextMenuStrip.Tag = hitTest.RowIndex;
            }
            else
            {
                // Cancel the context menu if the right-click was not on a row
                e.Cancel = true;
            }
        }
        
        // NAVIGATE TO THE SHOW DETAILS PAGE
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson person = GetTheSelectedPerson();
            if (person != null)
            {
                ShowPersonDetailsForm frm = new ShowPersonDetailsForm(person);
                frm.EventTrigger += _DisplayPeople;
                frm.Show();
            }
        }
        
        // NAVIGATE TO THE ADD NEW PERSON PAGE
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditForm AddFrm = new AddEditForm();
            AddFrm.EventTrigger += _DisplayPeople;
            AddFrm.ShowDialog();
        }
        
        // NAVIGATE TO THE EDIT PERSON PAGE (WITH THE SELECTED PERSON INFO)
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson person = GetTheSelectedPerson();
            if (person != null)
            {
                AddEditForm EditFrm = new AddEditForm(person);
                EditFrm.EventTrigger += _DisplayPeople;
                EditFrm.ShowDialog();
            }
        }
        
        // DELETE THE SELECTED PERSON
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson person = GetTheSelectedPerson();
            bool isDeleted = false;

            if (person != null) 
            {
                if (MessageBox.Show("Are you sure you want to delete this person?", "Delete",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    isDeleted = person.Delete();
                }

                if (isDeleted)
                {
                    ProfilePictureHelper.DeleteOldImage(person.ImagePath);
                    MessageBox.Show("The person deleted Successfully", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _DisplayPeople();
                }

                return;
            }
            MessageBox.Show("An error accured when deleting this person.", "Delete",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        // SEND AN EMAIL TO THE SELECTED PERSON
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("outlookmail:");
        }
        
        // CALL THE SELECTED PERSON
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not availabe yet.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        
        private void AddPersonPB_MouseHover(object sender, EventArgs e)
        {
            AddPersonPB.Cursor = Cursors.Hand;
        }
        
        // CLOSE FORM BUTTON
        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // SAVE FORM BUTTON
        private void FillterTB_TextChanged(object sender, EventArgs e)
        {
            string filterText = FillterTB.Text.Trim().ToLower();

            switch (FillterCB.SelectedIndex)
            {
                case 1:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.PersonID);
                    break;
                case 2:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.NationalNo);
                    break;
                case 3:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.FirstName);
                    break;
                case 4:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.LastName);
                    break;
                case 5:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.Nationality);
                    break;
                case 6:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.Gender);
                    break;
                case 7:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.Phone);
                    break;
                case 8:
                    // Apply the filter
                    ApplyFillter(filterText, FillterOptions.Email);
                    break;
                default:
                    break;
            }
        }
    }
}