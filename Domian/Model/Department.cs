namespace Domian.Model;

public class Department
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Employee Manager { get; set; }
}
