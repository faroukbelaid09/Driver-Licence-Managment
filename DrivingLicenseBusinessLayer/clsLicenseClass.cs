using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public int ClassFees { get; set; }


        public clsLicenseClass(int classID, string className, string classDescription, 
            int minAllowedAge, int validityLength, int classFee) 
        {
         
            this.LicenseClassID = classID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minAllowedAge;
            this.DefaultValidityLength = validityLength;
            this.ClassFees = classFee;
        }

        public static List<clsLicenseClass> GetAllLicenseClasses()
        {
            List<clsLicenseClass> LicenseClasses = new List<clsLicenseClass>();

            DataTable dataTable =  clsLicenseClassDataAccess.GetLicenseClasses();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int classID = Convert.ToInt32(row["LicenseClassID"]);
                    string className = row["ClassName"].ToString();
                    string classDescription = row["ClassDescription"].ToString();
                    int minAllowedAge = Convert.ToInt32(row["MinimumAllowedAge"]);
                    int classLength = Convert.ToInt32(row["DefaultValidityLength"]);
                    int classFee = Convert.ToInt32(row["ClassFees"]);

                    // Create a new clsLicenseClass object and add it to the list
                    clsLicenseClass licenseClass = new clsLicenseClass(
                        classID, className, classDescription, minAllowedAge,classLength, classFee
                    );

                    LicenseClasses.Add(licenseClass);
                }

                return LicenseClasses;
            }
            return null;
        }

        public static List<string> GetClassesNames()
        {
            List<string> classesNames = new List<string>();

            DataTable dataTable = clsLicenseClassDataAccess.GetLicenseClassNames();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    string className = row["ClassName"].ToString();

                    classesNames.Add(className);
                }

                return classesNames;
            }
            return null;
        }

    }
}
