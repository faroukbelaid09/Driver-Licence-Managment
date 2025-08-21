using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsLicense
    {
        int LicenseId { get; set; }
        int ApplicationID { get; set; }
        int DriverID { get; set; }
        int LicenseClass {  get; set; }
        string IssueDate { get; set; }
        string ExpirationDate { get; set; }
        string Notes { get; set; }
        int PaidFees { get; set; }
        bool IsActive { get; set; }
        int IssueReason { get; set; }
        int CreatedByUserID {  get; set; }


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
    }
}
