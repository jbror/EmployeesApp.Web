using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class EmployeeService
{

    private readonly List<Employee> employee = new()
    {
        new Employee {Id = 1, Name = "Sauron", Email = "sauron_evil@hotmail.com"},
        new Employee {Id = 2, Name = "Yoda", Email = "yodaboy@yahoo.com"},
        new Employee {Id = 3, Name = "Neo", Email = "neo_03@matrix.com"}

    };


    public void Employee(Employee employee)
    {
        employee.Add(employee);
    }

    public Employee[] GetAllEmployees()
    {
        return employee.ToArray();
    }


    public Employee? GetEmployeeById(int id)
    {
        return employees.FirstOrDefault(e => e.Id == id);
    }







}
