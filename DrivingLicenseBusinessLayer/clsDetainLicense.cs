using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsDetainLicense
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public string DetainDate { get; set; }
        public int FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int IsReleased { get; set; }
        public string ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }


        public clsDetainLicense(int detainID, int licenseID,string detainDate, int fineFees,int createdByUserID, int isReleased,
            string releasedDate,int releasedUserID, int releasedAppID)
        {
            this.DetainID = detainID;
            this.LicenseID = licenseID;
            this.DetainDate = detainDate;
            this.FineFees = fineFees;
            this.CreatedByUserID = createdByUserID;
            this.IsReleased = isReleased;
            this.ReleaseDate = releasedDate;
            this.ReleasedByUserID = releasedUserID;
            this.ReleaseApplicationID = releasedAppID;
        }
    
    
        public static clsDetainLicense DetainLicense(int licenseID, string detainDate, int fineFees, int createdByUserID, int isReleased,
            string releasedDate, int releasedUserID, int releasedAppID)
        {
            int detainID = -1;

            detainID = clsDetainLicenseDataAccess.DetainLicense(licenseID,detainDate,fineFees, createdByUserID,isReleased,
                releasedDate,releasedUserID,releasedAppID);

            if (detainID != -1) 
            {
                return new clsDetainLicense(detainID, licenseID, detainDate, fineFees, createdByUserID, isReleased,
                releasedDate, releasedUserID, releasedAppID);
            }
            return null;
        }
    }
}
