using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsFullLicenseDetails
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }
        public string IssueDate { get; set; }
        public string ExpirationDate { get; set; }
        public int IssueReason { get; set; }
        public string Notes { get; set; }
        public int DiverID { get; set; }
        public string ClassName { get; set; }
        public string IsDetained { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        public clsFullLicenseDetails(int licenseID,int applicationid, int personid ,bool isActive,string issueDate,string expirationDate,int issueReasin,
            string notes,int driverID,string className,string isDetained,string fullName,string NationalNo,
            string DateOfBirth,string gendor)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationid;
            this.PersonID = personid;
            this.IsActive = isActive;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IssueReason = issueReasin;
            this.Notes = notes;
            this.DiverID = driverID;
            this.ClassName = className;
            this.IsDetained = isDetained;
            this.FullName = fullName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = gendor;
        }
    }
}