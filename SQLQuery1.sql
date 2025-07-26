select * from LocalDrivingLicenseFullApplications


select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, DrivingClass = LicenseClasses.ClassName,People.NationalNo, FullName = People.FirstName + People.LastName
,Applications.ApplicationDate,PassedTests = (select count(1) from Tests
inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
where LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID and TestResult = 1), Applications.ApplicationStatus from Applications inner join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
inner join LicenseClasses on LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
inner join People on People.PersonID = Applications.ApplicantPersonID


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