namespace apiEmployees.Models
{
    public class Employee
    {
        public Employee(int id, string imageUrl, string firstName, string lastName, string email, string contactNumber, int age, string dob, double salary, string address)
        {
            Id = id;
            ImageUrl = imageUrl;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ContactNumber = contactNumber;
            Age = age;
            Dob = dob;
            Salary = salary;
            Address = address;
        }

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }
        public string Dob { get; set; }
        public double Salary { get; set; }
        public String Address { get; set; }
        



       
    }
}
