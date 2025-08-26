using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserId { get; set; }
        public string CreatedDate { get; set; }

        public clsDriver(int driverID, int personID, int createdByUserID, string createdDate)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.CreatedByUserId = createdByUserID;
            this.CreatedDate = createdDate;
        }
    
        public static clsDriver Create(int personID, int createdByUserID, string createdDate)
        {
            int driverID = -1;

            driverID = clsDriverDataAccess.CreateDriver(personID,createdByUserID,createdDate);

            if(driverID != -1)
            {
                return new clsDriver(driverID,personID,createdByUserID,createdDate);
            }

            return null;
        }
    
        public static bool CheckIfDriverExist(int personid)
        {
            return clsDriverDataAccess.Find(personid);
        }

        public static int GetDriverID(int personID) 
        {
            return clsDriverDataAccess.GetDriverID(personID);
        }
    }
}
