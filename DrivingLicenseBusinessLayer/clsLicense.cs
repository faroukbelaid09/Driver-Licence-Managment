using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsLicense
    {
        public int LicenseId { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass {  get; set; }
        public string IssueDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID {  get; set; }


        public clsLicense(int licenseID,int appID,int driverID,int licenseClass, string issueDate,string expirationDate,
            string notes,int paidFeed,bool isActive, int issueReason, int  createdByUserID)
        {
            this.LicenseId = licenseID;
            this.ApplicationID = appID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes; 
            this.PaidFees = paidFeed;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
        }

        public static clsLicense Create(int appID, int driverID, int licenseClass, string issueDate, string expirationDate,
            string notes, int paidFeed, bool isActive, int issueReason, int createdByUserID)
        {
            int licenseID = -1;

            licenseID = clsLicenseDataAccess.CreateLicense(appID, driverID, licenseClass, issueDate, expirationDate,
            notes, paidFeed, isActive, issueReason, createdByUserID);

            if (licenseID != -1)
            {
                return new clsLicense(licenseID, appID, driverID, licenseClass, issueDate, expirationDate,
                            notes, paidFeed, isActive, issueReason, createdByUserID);
            }

            return null;
        }
    
        public static clsFullLicenseDetails GetFullLicenseDetails(int licenseid)
        {
            bool isactive = false;

            string issuedate = "", expirationdate="", notes="", classname="", fullname="",nationalno="",
                isdetained="",dateofbirth = "",gender="";
            int issuereason=-1, driverid=-1,appid = -1,personid = -1;

            if(clsLicenseDataAccess.GetFullLicenseInfo(licenseid,ref appid,ref personid, ref isactive,ref issuedate,ref expirationdate,
                ref notes,ref classname,ref fullname,ref issuereason,ref driverid,ref isdetained,ref nationalno,
                ref dateofbirth,ref gender))
            {
                return new clsFullLicenseDetails(licenseid,appid,personid,isactive,issuedate,expirationdate,issuereason,
                    notes,driverid,classname,isdetained,fullname,nationalno,dateofbirth,gender);
            }

            return null;
        }
    
        public static int GetLicenseID(int appID)
        {
            return clsLicenseDataAccess.GetLicenseID(appID);
        }
    
        public static List<clsFullLicenseDetails> GetAllLocalLicenses(int personID)
        {
            List<clsFullLicenseDetails> _allPersonLocalLicesnse = new List<clsFullLicenseDetails>();
            DataTable dataTable  = new DataTable();

            dataTable = clsLicenseDataAccess.GetAllLocalLicenses(personID);

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int LicenseID = Convert.ToInt32(row["LicenseID"]);
                    int ApplicationID = Convert.ToInt32(row["ApplicationID"]);
                    int PersonID = Convert.ToInt32(row["PersonID"]);
                    bool IsActive = (bool)row["IsActive"];
                    string IssueDate = row["IssueDate"].ToString();
                    string ExpirationDate = row["IssueDate"].ToString();
                    int IssueReason = Convert.ToInt32(row["IssueReason"]);
                    string Notes = row["Notes"].ToString();
                    int DiverID = Convert.ToInt32(row["DriverID"]);
                    string ClassName = row["ClassName"].ToString();
                    string IsDetained = row["IsDetained"].ToString();
                    string FullName = row["FullName"].ToString();
                    string NationalNo = row["NationalNo"].ToString();
                    string DateOfBirth = row["DateOfBirth"].ToString();
                    string Gender = row["Gendor"].ToString();
 
                    // Create a new clsPerson object and add it to the list
                   clsFullLicenseDetails localLicense = new clsFullLicenseDetails(
                        LicenseID,ApplicationID, PersonID,IsActive,IssueDate,ExpirationDate,IssueReason, Notes,
                        DiverID, ClassName,IsDetained, FullName, NationalNo, DateOfBirth,Gender
                    );

                    _allPersonLocalLicesnse.Add(localLicense);
                }

                return _allPersonLocalLicesnse;
            }

            return null;
        }

        public static List<clsInternationalLicense> GetAllInternationalLicenses(int driverID)
        {
            List<clsInternationalLicense> _allPersonInternationalLicesnse = new List<clsInternationalLicense>();
            DataTable dataTable = new DataTable();

            dataTable = clsLicenseDataAccess.GetAllInternationalLicenses(driverID);

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int InternationalLicenseID = Convert.ToInt32(row["InternationalLicenseID"]);
                    int ApplicationID = Convert.ToInt32(row["ApplicationID"]);
                    int DriverID = Convert.ToInt32(row["DriverID"]);
                    int IssuedUsingLocalLicenseID = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]);
                    int IsActive = (int)row["IsActive"];
                    string IssueDate = row["IssueDate"].ToString();
                    string ExpirationDate = row["ExpirationDate"].ToString();
                    

                    // Create a new clsPerson object and add it to the list
                    clsInternationalLicense internationalLicense = new clsInternationalLicense(
                         InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                         IssueDate, ExpirationDate, IsActive, ApplicationState.CurrentUser.UserID);

                    _allPersonInternationalLicesnse.Add(internationalLicense);
                }

                return _allPersonInternationalLicesnse;
            }

            return null;
        }
        
        public static bool DeactivateLicense(int licensID)
        {
            return clsLicenseDataAccess.Deactivate(licensID);
        }
    }
}