using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsApplicationType
    {

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public int ApplicationFees { get; set; }

        public clsApplicationType(int applicationID,string applicationTitle,int applicationFee) 
        { 
            this.ApplicationTypeID = applicationID;
            this.ApplicationTypeTitle = applicationTitle;
            this.ApplicationFees = applicationFee;
        }

        public static List<clsApplicationType> GetApplicationTypes()
        {
            List<clsApplicationType> clsApplicationTypes = new List<clsApplicationType>();

            DataTable dataTable = clsApplicationTypesDataAccess.GetAllApplicationTypes();


            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int appID = Convert.ToInt32(row["ApplicationTypeID"]);
                    string appTitle = row["ApplicationTypeTitle"].ToString();
                    int appFee = Convert.ToInt32(row["ApplicationFees"]);

                    // Create a new clsApplicationType object and add it to the list
                    clsApplicationType applicationType = new clsApplicationType(
                        appID,appTitle,appFee
                    );

                    clsApplicationTypes.Add(applicationType);
                }

                return clsApplicationTypes;
            }
            return null;

        }
    }
}
