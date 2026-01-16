using Domain.Models;

namespace Infrastructure.Services;

public class DeparmentServices
{
    List<Department> _departments = [];
    public List<Department> GetDepartments()
    {
        return _departments;
    }
    public void AddDepartment(Department department)
    {
        _departments.Add(department);
    }
    public int CountDepartmnets()
    {
        return _departments.Count();
    }
}
