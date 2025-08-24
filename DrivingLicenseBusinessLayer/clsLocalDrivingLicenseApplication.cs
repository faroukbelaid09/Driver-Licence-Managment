using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsLocalDrivingLicenseApplication(int LocalAppID, int AppID, int LicenseClassID) 
        {
            this.ApplicationID = AppID;
            this.LocalDrivingLicenseApplicationID = LocalAppID;
            this.LicenseClassID = LicenseClassID;
        }


        public static clsLocalDrivingLicenseApplication Create(int AppID, int LicenseClassID)
        {
            int LocalAppID = -1;

            LocalAppID = clsLocalApplicationDataAccess.CreateLocalDrivingLicenseApplication(AppID,LicenseClassID);

            if(LocalAppID != -1)
            {
                return new clsLocalDrivingLicenseApplication(LocalAppID,AppID,LicenseClassID);
            }

            return null;
        }

        public static clsLocalDrivingLicenseApplication FindLocalApplication(int localAppID)
        {
            int appID = -1, licenseClassID = -1;

            if (clsLocalApplicationDataAccess.FindLocalApplication(localAppID,ref appID,ref licenseClassID))
            {
                return new clsLocalDrivingLicenseApplication(localAppID,appID,licenseClassID);
            }
            return null;
        }

        public static bool Delete(int appID) 
        {
            return clsLocalApplicationDataAccess.Delete(appID);
        }
    }
}
