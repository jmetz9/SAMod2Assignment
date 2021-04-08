using System.Collections.Generic;

namespace SAMod2Assignment
{
    public class HrPerson
    {

        private List<Employee> employees = new List<Employee>();

        public HrPerson()
        {
            
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            Employee e = new Employee(firstName, lastName, ssn);
            employees.Add(e);
            OrientEmployee(e);
        }

        private void OrientEmployee(Employee emp)
        {
            emp.doFirstTimeOrientation("B101");
        }

        public void OutputReport(string ssn)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Ssn.Equals(ssn))
                {
                    if (emp.MetWithHr && emp.MetDeptStaff & emp.ReviewedDeptPolicies && emp.MovedIn)
                    {
                        emp.PrintReport();
                    }
                    break;
                }
            }
        }
        
    }
}