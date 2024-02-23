using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public interface IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateSalaryMonthly();
    }
}