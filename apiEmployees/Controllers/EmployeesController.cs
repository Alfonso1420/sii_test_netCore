using apiEmployees.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace apiEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {


        [HttpGet]
        public string listEmployees() {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee(1001, "https://hub.dummyapis.com/Image?text=UB&height=120&width=120", "Ulises", "Bode", "Ulises.Bode@dummyapis.com", "4670998898",73, "06/01/1951", 1.0, "Address1");
            employees.Add(employee);         


            employee = new Employee( 1002,"https://hub.dummyapis.com/Image?text=HB&height=120&width=120",
            "Henrietta","Bosco","Henrietta.Bosco@dummyapis.com",
           "4785097247", 56, "12/02/1968", 2.0,"Address2"); 
            employees.Add(employee);

            employee = new Employee( 1003, "https://hub.dummyapis.com/Image?text=LH&height=120&width=120",
             "Luciano", "Hermann", "Luciano.Hermann@dummyapis.com","4179696815",
             72, "06/06/1952", 3.0, "Address3"         );
            employees.Add(employee);

            employee = new Employee(1004, "https://hub.dummyapis.com/Image?text=SD&height=120&width=120",
             "Sophia", "DuBuque", "Sophia.DuBuque@dummyapis.com","4885390628", 74,
             "17/10/1950", 4.0, "Address4"          ); 
             employees.Add(employee);

            employee = new Employee( 1005, "https://hub.dummyapis.com/Image?text=CK&height=120&width=120",
            "Candida", "Koepp", "Candida.Koepp@dummyapis.com","4249699107", 38,
            "12/09/1986", 5.0, "Address5"          );
             employees.Add(employee);

            employee = new Employee( 1006, "https://hub.dummyapis.com/Image?text=GK&height=120&width=120",
            "Garth", "Kuhic", "Garth.Kuhic@dummyapis.com","4910590211",
             56, "29/02/1968", 6.0, "Address6"          ); 
            employees.Add(employee);

            employee = new Employee( 1007, "https://hub.dummyapis.com/Image?text=PG&height=120&width=120",
             "Paula", "Greenfelder", "Paula.Greenfelder@dummyapis.com","4159298718",
             84, "21/04/1940", 7.0, "Address7"          ); 
            employees.Add(employee);

            employee = new Employee( 1008, "https://hub.dummyapis.com/Image?text=RD&height=120&width=120",
             "Ruthie", "Dietrich", "Ruthie.Dietrich@dummyapis.com",
            "4650390163", 81, "17/04/1943", 8.0, "Address8"
                      );            
            employees.Add(employee);            
            
            employee = new Employee(
             1009,
             "https://hub.dummyapis.com/Image?text=IB&height=120&width=120",
             "Isai", "Bruen", "Isai.Bruen@dummyapis.com","4222193495",
             30, "15/07/1994", 9.0, "Address9" ); 
             employees.Add(employee);


            employee = new Employee( 1010, "https://hub.dummyapis.com/Image?text=EF&height=120&width=120",
            "Ellie", "Fadel", "Ellie.Fadel@dummyapis.com","4834095638",
            35, "05/02/1989", 10.0, "Address10");
            employees.Add(employee);


            var json = JsonConvert.SerializeObject(employees);

            return json; 

           
        }

      
    }
}
