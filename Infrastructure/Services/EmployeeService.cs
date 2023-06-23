using Domian.Model;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> employees;
    public EmployeeService()
    {
        employees = new List<Employee>();
    }
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void AddEmployees(Employee employee)
    {
        employee.ID = employees.Count + 1;
        employees.Add(employee);
    }
    public int CountEmploees()
    {
        return employees.Count;
    }
}
