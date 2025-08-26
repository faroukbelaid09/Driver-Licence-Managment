using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public string IssueDate { get; set; }
        public string ExpirationDate { get; set; }
        public int IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsInternationalLicense(int internationalLicenseID, int appID, int driverID, 
            int localLicenseID, string issueDate, string expirationDate, int isActive, int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID = appID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = localLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
        }

        public static clsInternationalLicense Create(int appID, int driverID,
            int localLicenseID, string issueDate, string expirationDate, int isActive, int createdByUserID)
        {
            int internationalLicenseID = -1;

            internationalLicenseID = clsLicenseDataAccess.CreateInternationalLicense(appID,driverID,localLicenseID,issueDate,expirationDate,
                isActive,createdByUserID);

            if (internationalLicenseID != -1) 
            {
                return new clsInternationalLicense(internationalLicenseID,appID,driverID,localLicenseID,issueDate,
                    expirationDate,isActive,createdByUserID);
            }
            return null;
        }
    
        public static bool CheckIfDriverHasInternationalLicens(int driverID, int localLicenseID)
        {
            return clsLicenseDataAccess.CheckIfLicenseExist(driverID,localLicenseID);
        }
    }
}