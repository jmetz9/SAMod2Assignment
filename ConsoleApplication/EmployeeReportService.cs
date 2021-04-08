using System;

namespace SAMod2Assignment
{
    public class EmployeeReportService
    {
        private string report = "";

        public void AddData(string data) 
        {
            report += data;
        }

        public void OutputReport()
        {
            Console.WriteLine(report);
        }

        public void ClearReport()
        {
            report = "";
        }
    }
}