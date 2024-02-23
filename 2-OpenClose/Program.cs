using OpenClose;

ShowSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Ray", 240)
});


void ShowSalaryMonthly(List<IEmployee> employees) 
{
    foreach (var employee in employees)
    {
        
            Console.WriteLine($"Empleado: {employee.FullName}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }
}