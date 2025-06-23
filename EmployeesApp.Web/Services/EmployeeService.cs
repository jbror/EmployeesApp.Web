using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class EmployeeService : IEmployeeService
{

    private readonly List<Employee> employees = new()
    {
        new Employee {Id = 1, Name = "Sauron", Email = "sauron_evil@hotmail.com"},
        new Employee {Id = 2, Name = "Yoda", Email = "yodaboy@yahoo.com"},
        new Employee {Id = 3, Name = "Neo", Email = "neo_03@matrix.com"}

    };
    private int nextId = 4; // Första lediga Id

    public void Add(Employee employee)
    {

        //employees.Add(employee);

        employee.Id = nextId;
        nextId++;
        employees.Add(employee);


    }

    public Employee[] GetAll()
    {
        return employees.ToArray();
    }


    public Employee? GetById(int id)
    {
        return employees.FirstOrDefault(e => e.Id == id);
    }


 

    







}
