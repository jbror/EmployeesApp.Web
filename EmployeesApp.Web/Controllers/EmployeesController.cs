using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    private readonly EmployeeService _employeeService;

    public EmployeesController(EmployeeService employeeService)
    {
        _employeeService = employeeService; // Här är jag nu
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        var employees = _employeeService.GetAll();
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
            _employeeService.Add(employee);
            return RedirectToAction("Index");
        }
        
        return View();

    }









}
