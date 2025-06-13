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

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
        
        
        if (ModelState.IsValid)
        {
            employeeService.Add(employee);
            return RedirectToAction("Index");
        }
        
        return View();

    }









}
