using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;
using EmployeesApp.Web.Models.ViewModels;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    private readonly EmployeeService _employeeService;

    public EmployeesController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        var employees = _employeeService.GetAll();
        var viewModels = employees.Select(e => new EmployeeIndexViewModel
        {
            Id = e.Id,
            Name = e.Name,
            Email = e.Email
        }).ToList();


        return View(viewModels);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {

        return View(new EmployeeCreateViewModel());
    }

    [HttpPost("create")]
    public IActionResult Create(EmployeeCreateViewModel vm)
    {

        if (ModelState.IsValid)
        {
            var employee = new Employee
            {
              
                Name = vm.Name,
                Email = vm.Email
            };

            _employeeService.Add(employee);
            return RedirectToAction("Index");
        }
        return View(vm);
    }









}
