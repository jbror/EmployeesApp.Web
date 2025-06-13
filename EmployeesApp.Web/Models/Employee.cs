using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class Employee
{

    public int Id { get; set; }

    [Required(ErrorMessage = "You must have a name! Enter name!")]
    public string Name { get; set; } = string.Empty;

   
    
    [Required(ErrorMessage ="Email is required")]
    [EmailAddress(ErrorMessage ="Enter valid email please!")]
    public string Email { get; set; } = string.Empty;




    

}
