using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService employeeService = new EmployeeService();

    public EmployeesController()
    {
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        var employees = employeeService.GetAll();
        return View(employees);
    }












}
