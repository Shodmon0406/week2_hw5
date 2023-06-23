using Domian.Model;
using Infrastructure.Services;

EmployeeService employeeService = new EmployeeService();

for (int i = 1; i <= 2; i++)
{
    System.Console.WriteLine($"Employee {i}");
    Employee employee = new Employee();
    System.Console.Write("Enter your name: ");
    employee.FirstName = Console.ReadLine();
    System.Console.Write("Enter your surname: ");
    employee.LastName = Console.ReadLine();
    employee.BirthDate = new DateTime(2023, 06, 23);
    System.Console.Write("Enter your salary: ");
    employee.Salary = Convert.ToDecimal(Console.ReadLine());
    employee.Department = new Department();
    System.Console.WriteLine("Enter department name: ");
    employee.Department.Name = Console.ReadLine();
    System.Console.WriteLine("Enter description: ");
    employee.Department.Description = Console.ReadLine();
    employeeService.AddEmployees(employee);
}
System.Console.WriteLine("-----------------------------------------------------------------");
foreach (var employee in employeeService.GetEmployees())
{
    System.Console.Write("ID: ");
    System.Console.WriteLine(employee.ID);
    System.Console.Write("Fulname: ");
    System.Console.WriteLine(employee.FirstName + " " + employee.LastName);
    System.Console.Write("Birthdate: ");
    System.Console.WriteLine(employee.BirthDate.ToShortDateString());
    System.Console.Write("Salary: $");
    System.Console.WriteLine(employee.Salary);
    System.Console.Write("Departmet: ");
    System.Console.WriteLine(employee.Department.Name + " " + employee.Department.Description);
    System.Console.WriteLine();
}