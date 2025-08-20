using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DrivingLicenseBusinessLayer
{
    public class clsTestType
    {

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeFees { get; set; }

        public clsTestType(int id,string name,string description,int fees) 
        {
            this.TestTypeID = id;
            this.TestTypeTitle = name;
            this.TestTypeDescription = description;
            this.TestTypeFees = fees;
        }

        public static List<clsTestType> GetTestTypes()
        {
            List<clsTestType> clsTestTypes = new List<clsTestType>();

            DataTable dataTable = clsTestTypesDataAccess.GetAllTestTypes();


            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int testID = Convert.ToInt32(row["TestTypeID"]);
                    string testTitle = row["TestTypeTitle"].ToString();
                    string testdesc = row["TestTypeDescription"].ToString();
                    int testFee = Convert.ToInt32(row["TestTypeFees"]);

                    // Create a new clsApplicationType object and add it to the list
                    clsTestType testType = new clsTestType(
                        testID, testTitle,testdesc, testFee
                    );

                    clsTestTypes.Add(testType);
                }

                return clsTestTypes;
            }
            return null;

        }

        public bool Update()
        {
            return clsTestTypesDataAccess.UpdateTestType(this.TestTypeID, this.TestTypeTitle,this.TestTypeDescription,
                this.TestTypeFees);
        }

        public static int GetTestFees(int testID)
        {
            return clsTestTypesDataAccess.GetTestFees(testID);
        }
    }
}
