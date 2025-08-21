using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;

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

        public static clsLicenseClass GetLicenseClassByName(string className)
        {
            int classID =-1,minAge=-1,classLength=-1,classFee = -1;
            string classDescription = "";

            if(clsLicenseClassDataAccess.GetByName(ref classID,className,ref classDescription,ref minAge,
                ref classLength,ref classFee))
            {
                return new clsLicenseClass(classID,className,classDescription,minAge,classLength,classFee);
            }
            return null;
        }
    }
}