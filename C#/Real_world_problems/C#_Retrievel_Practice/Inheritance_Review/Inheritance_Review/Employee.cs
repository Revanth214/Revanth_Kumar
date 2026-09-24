using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Review
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, string email, decimal salary)
        {
            this.EmployeeID = id;
            Name = name;
            Email = email;
            Salary = salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employe ID: " + EmployeeID);
            Console.WriteLine("Employe Name: " + Name);
            Console.WriteLine("Employe Email: " + Email);
            Console.WriteLine("Employe Salary: " + Salary);
        }
        public void work()
        {
            Console.WriteLine("Employee is working");
        }
    }
}
