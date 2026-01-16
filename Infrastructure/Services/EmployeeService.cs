using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> _employees = [];

    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
    public int CountEmployees()
    {
        return _employees.Count();
    }
}
