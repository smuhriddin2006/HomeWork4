using Domain.Models;
using Infrastructure.Services;

Employee employee1 = new Employee()
{
    FirstName = "Umed",
    LastName = "Safarov",
    BirhDate = DateTime.Now,
    Salary = 5000
};
Employee employee2 = new Employee()
{
    FirstName = "Muhammad",
    LastName = "Evazov",
    BirhDate = DateTime.Now,
    Salary = 4000
};
Employee employee3 = new Employee()
{
    FirstName = "Rofe",
    LastName = "Nozimov",
    BirhDate = DateTime.Now,
    Salary = 2000
};

Department department1 = new Department()
{
    Name = "SoftClub",
    Description = "Programming",

};
Department department2 = new Department()
{
    Name = "AmericanSchool",
    Description = "English",

};

EmployeeService employeeService = new();
employeeService.AddEmployee(employee1);
employeeService.AddEmployee(employee2);
employeeService.AddEmployee(employee3);
List<Employee> s = employeeService.GetEmployees();
int s2 = employeeService.CountEmployees();
System.Console.WriteLine(s2);
foreach(Employee employee in s)
{
    System.Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.BirhDate} {employee.Salary}");
}

System.Console.WriteLine("---------------------------------------------------------");

DeparmentServices deparmentServices = new();
deparmentServices.AddDepartment(department1);
deparmentServices.AddDepartment(department2);
List<Department> d1 = deparmentServices.GetDepartments();
int d2 = deparmentServices.CountDepartmnets();
System.Console.WriteLine(d2);
foreach(Department department in d1)
{
    System.Console.WriteLine($"{department.Name} {department.Description}");
}
