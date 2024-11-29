using EmployeesAdmin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace EmployeesAdmin.Controllers
{
    public class ApiController
    {

      
        Uri baseAddress = new Uri("https://localhost:7072/api/Employees");
        private readonly HttpClient _client;


        public ApiController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }

        //This method list the employees form de api 
        public List<Employee> listEmployees(string searchString)
        {
            List<Employee> employees = new List<Employee>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<Employee>>(data);
            }

            //Search by ID, when it is not null, add filter and add Anual Salary calculation 
            employees = searchBy(searchString, employees);
            return employees;
        }

        //This method filter the list of employees when the ID is not null, and add the format to the money amounts. 
        public List<Employee> searchBy(String search, List<Employee> employees ) {
            double salary = 0;
            List<Employee> employees2 = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Salary != null) {
                    //Giving format to the salary amount. 
                    salary = Double.Parse(employees[i].Salary);
                    employees[i].Salary = String.Format("{0:C2}", Convert.ToDouble(salary));

                    //Getting the anual salary
                    salary = getAnualSalary( salary);                    
                    employees[i].AnualSalary= String.Format("{0:C2}", Convert.ToDouble(salary)) ;
                }
                if (employees[i].Id == Convert.ToInt32(search))
                {
                    employees2.Add(employees[i]);
                }
            }

            //When the search is not empty return the new list
            if (!string.IsNullOrEmpty(search))
            {  return employees2; 

            }

            return employees;
        }


        public double getAnualSalary(double salary)
        {
            return salary * 12; 
        }

    }
        
    }
