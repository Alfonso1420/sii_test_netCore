using EmployeesAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace EmployeesAdmin.Controllers
{
    public class EmployeesController : Controller
    {
        ApiController applicationApiContext;
        public EmployeesController() { 
             applicationApiContext = new ApiController();
        }

       
        public IActionResult Index(string searchString)
        {
            List<Employee> employees = applicationApiContext.listEmployees(searchString); 
            return View(employees);
        }
    }
}
