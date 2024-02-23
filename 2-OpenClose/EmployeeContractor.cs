using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeContractor(string fullName, int hoursWorked)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 34000M;
            return hourValue * HoursWorked;
        }
    }
}