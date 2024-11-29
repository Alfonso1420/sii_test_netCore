namespace EmployeesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]    
        public void TestMethodAnualSalary()
        {
            EmployeesAdmin.Controllers.ApiController apiController=new EmployeesAdmin.Controllers.ApiController();
            double anualSalary = apiController.getAnualSalary(10);
            Assert.AreEqual(120, anualSalary);
        }

        [TestMethod]
        public void TestMethodSearchBy()
        {
            EmployeesAdmin.Controllers.ApiController apiController = new EmployeesAdmin.Controllers.ApiController();
            List<EmployeesAdmin.Models.Employee> employees = new List<EmployeesAdmin.Models.Employee>();
            
            EmployeesAdmin.Models.Employee employee= new EmployeesAdmin.Models.Employee();
            employee.Id = 1;
            employees.Add(employee);

            employee = new EmployeesAdmin.Models.Employee();
            employee.Id = 2;
            employees.Add(employee);

            employee = new EmployeesAdmin.Models.Employee();
            employee.Id = 3;
            employees.Add(employee);

            //It searh the employee with id 2  and return the list with just one register (employee with id: 2)
            employees = apiController.searchBy("2", employees); 


            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual(2, employees[0].Id);
        }


    }
}