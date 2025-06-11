using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DrivingLicenseBusinessLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderID { get; set; }
        public string GenderTitle { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string ImagePath { get; set; }
        public clsPerson(int PersonID, string NationalNo, string FirstName, string LastName, int GenderID, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath, string Email)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.GenderID = GenderID;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
        }

        public clsPerson(int PersonID, string NationalNo, string FirstName, string LastName, string GenderTitle, string Phone,
            string Address, DateTime DateOfBirth, int CountryID,string CountryName, string ImagePath, string Email)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.GenderTitle = GenderTitle;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.ImagePath = ImagePath;
        }

        public static clsPerson FindPersonByID(int ID)
        {
            int CountryID = -1, GenderID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "", Address = "", ImagePath = "", NationalNo="",CountryName="";
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersonDataAccess.GetPersonByID(ID, ref FirstName, ref LastName, ref Email,
                ref Phone, ref NationalNo, ref Address, ref DateOfBirth, ref GenderID, ref CountryID, ref CountryName, ref ImagePath))
            {
                return new clsPerson(ID, NationalNo, FirstName, LastName, GenderID == 1 ? "Male" : "Female", Phone,
                    Address, DateOfBirth, CountryID, CountryName, ImagePath, Email);
            }
            return null;
        }
        public static List<clsPerson> GetAllPeople() {

            List<clsPerson> people = new List<clsPerson>();

            DataTable dataTable = clsPersonDataAccess.GetPeople();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int personID = Convert.ToInt32(row["PersonID"]);
                    string nationalNo = row["NationalNo"].ToString();
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();
                    string gender = Convert.ToInt32(row["Gendor"]) == 1 ? "Male" : "Female";
                    string phone = row["Phone"].ToString();
                    string email = row["Email"].ToString();
                    string address = row["Address"].ToString();
                    DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]).Date;
                    int countryID = Convert.ToInt32(row["NationalityCountryID"]);
                    string countryName = row["CountryName"].ToString();
                    string imagePath = row["ImagePath"].ToString();

                    // Create a new clsPerson object and add it to the list
                    clsPerson person = new clsPerson(
                        personID,
                        nationalNo,
                        firstName,
                        lastName,
                        gender,
                        phone,
                        address,
                        dateOfBirth,
                        countryID,
                        countryName,
                        imagePath,
                        email
                    );

                    people.Add(person);
                }

                return people;
            }

            return null;
        }
        public bool Add()
        {
            int ID = clsPersonDataAccess.AddPerson(this.NationalNo, this.FirstName, this.LastName, this.DateOfBirth
                ,this.GenderID, this.Address, this.Email, this.Phone, this.CountryID, this.ImagePath);

            if (ID != -1)
            {
                this.PersonID = ID;
                return true;
            }
            return false;
        }
        public bool Update()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID,this.NationalNo,this.FirstName,
                this.LastName,this.DateOfBirth, this.GenderID, this.Address,this.Email,
                this.Phone,this.CountryID,this.ImagePath);
        }
        public bool Delete()
        {
            return clsPersonDataAccess.DeletePerson(this.PersonID);
        }
        public static string GetPersonCountryName(int personID)
        {
            return clsPersonDataAccess.GetPersonCountryName(personID);
        }
    }
}