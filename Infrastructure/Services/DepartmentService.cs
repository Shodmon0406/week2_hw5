using Domian.Model;

namespace Infrastructure.Services;

public class DepartmentService
{
    List<Department> departments;
    public List<Department> GetDepartments() 
    {
        return departments;
    }
    public void AddDepartments(Department department)
    {
        departments.Add(department);
    }
    public int CountDepartment() 
    {
        return departments.Count;
    }
}
