using System;

namespace SAMod2Assignment
{
    public class Employee
    {

        private readonly string REQUIRED_MSG = " is mandatory ";
        private readonly string NEWLINE = "\r";

        private string firstName;
        private string lastName;
        private string ssn;
        private bool metWithHr;
        private bool metDeptStaff;
        private bool reviewedDeptPolicies;
        private bool movedIn;
        private string cubeId;
        private DateTime orientationDate;
        private EmployeeReportService reportService = new EmployeeReportService();

        public Employee(String firstname, String lastname, String ssn)
        {
            FirstName = firstname;
            LastName = lastname;
            Ssn = ssn;
        }

        private string getFormattedDate()
        {
            return orientationDate.ToString("MM/dd/yyyy");
        }

        public void doFirstTimeOrientation(String cubeId)
        {
            orientationDate = DateTime.Now;
            meetWithHrForBenefitAndSalaryInfo();
            meetDepartmentStaff();
            reviewDeptPolicies();
            moveIntoCubicle(cubeId);
        }

        private void meetWithHrForBenefitAndSalaryInfo()
        {
            metWithHr = true;
            reportService.AddData(firstName + " " + lastName + " met with HR on " 
                                  + getFormattedDate() + NEWLINE);
        }
        
        private void meetDepartmentStaff()
        {
            metDeptStaff = true;
            reportService.AddData(firstName + " " + lastName + " met with dept staff on " 
                                  + getFormattedDate() + NEWLINE);
        }

        public void reviewDeptPolicies()
        {
            reviewedDeptPolicies = true;
            reportService.AddData(firstName + " " + lastName + " reviewed dept policies on "
                                  + getFormattedDate() + NEWLINE);
        }

        public void moveIntoCubicle(String cubeId)
        {

            CubeId = cubeId;
            this.movedIn = true;
            reportService.AddData(firstName + " " + lastName + " moved into cubicle "
                                  + cubeId + " on " + getFormattedDate() + NEWLINE);
            
        }

        public void PrintReport()
        {
            reportService.OutputReport();
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Ssn
        {
            get => ssn;
            set => ssn = value;
        }

        public bool MetWithHr
        {
            get => metWithHr;
            set => metWithHr = value;
        }

        public bool MetDeptStaff
        {
            get => metDeptStaff;
            set => metDeptStaff = value;
        }

        public bool ReviewedDeptPolicies
        {
            get => reviewedDeptPolicies;
            set => reviewedDeptPolicies = value;
        }

        public bool MovedIn
        {
            get => movedIn;
            set => movedIn = value;
        }

        public string CubeId
        {
            get => cubeId;
            set => cubeId = value;
        }

        public override string ToString()
        {
            return "Employee{" + "firstName=" + firstName + ", lastName=" + lastName + ", ssn=" + ssn + '}';
        }

    }
}