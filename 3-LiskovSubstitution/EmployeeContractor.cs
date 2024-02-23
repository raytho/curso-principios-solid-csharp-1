namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary()
        {
            var hourValue = 40;
            return hourValue * HoursWorked;
        }
    }
}