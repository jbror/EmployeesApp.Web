using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); 

            // builder.Services.AddTransient<EmployeeService>();

            builder.Services.AddSingleton<EmployeeService>(); 


            var app = builder.Build();
            app.MapControllers();


            app.Run();
        }
    }
}

// Registrera service-klassen som en transient service i Program Lägg nu till en ny anställd – varför syns den inte på index-sidan?:

// builder.Services.AddTransient<EmployeeService>(); När jag registrerar min klass som transient så skapas en ny "version" av
// EmployeeService varje gång den används. När jag sparar en Employee i min lista så sparas den i just den versionen. Laddar jag om sidan
// får jag en ny "version" och ser inte det jag lagt til tidigare i den andra "versionen"


// Registrera service-klassen som en singleton service i Program Lägg nu till en ny anställd - varför syns den nu på index-sidan?:

// För att tillskillnad i från en transient klass så skickas "samma version" av min EmployeeService-klass när jag registrerat den som singleton.
// Alltså sparas min ändringar i min "version" och samma version skickas med nästa gång jag använder klassen. 



