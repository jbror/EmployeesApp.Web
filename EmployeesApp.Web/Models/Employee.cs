﻿using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class Employee
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;











}
