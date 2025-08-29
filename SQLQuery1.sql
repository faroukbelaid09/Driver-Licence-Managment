select * from LocalDrivingLicenseFullApplications


select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass = LicenseClasses.ClassName,
People.NationalNo, FullName = People.FirstName + People.LastName,Applications.ApplicationDate,
PassedTests = (select count(1) from Tests inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
where LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID and TestResult = 1), 
Applications.ApplicationStatus from Applications inner join LocalDrivingLicenseApplications on 
LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID inner join LicenseClasses on 
LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID inner join People on 
People.PersonID = Applications.ApplicantPersonID


select 1 from LocalDrivingLicenseFullApplications
where NationalNo = '0123' and DrivingClass LIKE '%Class 4%'


select * from LocalDrivingLicenseFullApplications
                             where NationalNo = '0123' and DrivingClass LIKE '%Class 1%' 
                             and (ApplicationStatus = 1 or ApplicationStatus = 3)


select Applications.*,FullName = People.FirstName + People.LastName,
                            ApplicationTypes.ApplicationTypeTitle,Users.UserName
                            from Applications inner join People on People.PersonID = Applications.ApplicantPersonID
                            inner join ApplicationTypes on ApplicationTypes.ApplicationTypeID = Applications.ApplicationTypeID
                            inner join Users on Users.UserID = Applications.CreatedByUserID
                            where ApplicationID = 110

select top 1 * from TestAppointments where 
TestAppointments.LocalDrivingLicenseApplicationID = 36
order by TestAppointmentID desc

select * from TestAppointments where 
TestAppointments.LocalDrivingLicenseApplicationID = 36 and TestTypeID = 1


select TestResult from Tests where TestAppointmentID = 108;


select Licenses.LicenseID,Licenses.IsActive,Licenses.IssueDate,Licenses.ExpirationDate,Licenses.IssueReason,Licenses.Notes,
Licenses.DriverID,LicenseClasses.ClassName,isDetained = (select DetainedLicenses.IsReleased from DetainedLicenses where Licenses.LicenseID = DetainedLicenses.LicenseID and DetainedLicenses.IsReleased = 'False'),
FullName = People.FirstName+People.LastName from Licenses
inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID
inner join Applications on Licenses.ApplicationID = Applications.ApplicationID
inner join People on Applications.ApplicantPersonID = People.PersonID


CREATE VIEW LicenseDetailsView AS 
SELECT 
    Licenses.LicenseID,
    Licenses.ApplicationID,
    Licenses.IsActive,
    Licenses.IssueDate,
    Licenses.ExpirationDate,
    Licenses.IssueReason,
    Licenses.Notes,
    Licenses.DriverID,
    LicenseClasses.ClassName,
    isDetained = CASE 
                    WHEN EXISTS (
                        SELECT 1 
                        FROM DetainedLicenses 
                        WHERE DetainedLicenses.LicenseID = Licenses.LicenseID 
                        AND DetainedLicenses.IsReleased = 0
                    ) THEN 1 
                    ELSE 0 
                 END,
    FullName = People.FirstName + ' ' + People.LastName,
    People.NationalNo,People.DateOfBirth,People.Gendor,People.PersonID
FROM Licenses
INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID
INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID;


select Drivers.*, DriverName = People.FirstName+People.LastName, CreatedBy = Users.UserName from Drivers
inner join People on Drivers.PersonID = People.PersonID
inner join users on Drivers.CreatedByUserID = Users.UserID