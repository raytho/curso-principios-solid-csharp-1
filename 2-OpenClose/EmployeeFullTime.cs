namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }
        
        public EmployeeFullTime(string fullName, int hoursWorked) 
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            return hourValue * HoursWorked;
        }
    }
}