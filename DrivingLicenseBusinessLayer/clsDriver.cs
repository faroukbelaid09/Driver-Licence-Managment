using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public string DriverName { get; set; } = null;
        public int PersonID { get; set; }
        public int CreatedByUserId { get; set; }
        public string CreatedBy { get; set; } = null;
        public string CreatedDate { get; set; }

        public clsDriver(int driverID,int personID, int createdByUserID, string createdDate,
            string driverName = null,string createdByName = null)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.CreatedByUserId = createdByUserID;
            this.CreatedDate = createdDate;
            this.DriverName = driverName;
            this.CreatedBy = createdByName;
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
    
        public static List<clsDriver> GetAllDrivers()
        {

            List<clsDriver> drivers = new List<clsDriver>();

            DataTable dataTable = clsDriverDataAccess.GetAllDrivers();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int DriverID = Convert.ToInt32(row["DriverID"]);
                    int PersonID = Convert.ToInt32(row["PersonID"]);
                    int CreatedByUserId = Convert.ToInt32(row["CreatedByUserId"]);
                    string DriverName = row["DriverName"].ToString();
                    string CreatedBy = row["CreatedBy"].ToString();
                    string CreatedDate = row["CreatedDate"].ToString();

                    // Create a new clsDriver object and add it to the list
                    clsDriver driver = new clsDriver(DriverID,PersonID,CreatedByUserId,CreatedDate,
                        DriverName, CreatedBy);

                    drivers.Add(driver);
                }

                return drivers;
            }

            return null;
        }
    }
}
