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
            Console.WriteLine("Employe ID: "+ EmployeeID);
            Console.WriteLine("Employe Name: " + Name);
            Console.WriteLine("Employe Email: " + Email);
            Console.WriteLine("Employe Salary: " + Salary);
        }
        public void work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Developer : Employee
    {
        public Developer(int id, string name, string email, decimal salary):base(id, name, email, salary)
        {
            Console.WriteLine("========Developer Details=========");
        }
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is a developer and he only writes code");
        }
    }
    class Manager : Employee
    {
        public Manager(int id, string name, string email, decimal salary) : base(id, name, email, salary)
        {
            Console.WriteLine("========Manager Details=========");
        }
        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is a manager and he manages the teams");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager(05, "Revanth", "revanth2487@gmail.com", 500000);
            mg.DisplayDetails();
            mg.ManageTeam();

            Developer dp = new Developer(17, "Bharath", "bharath2357@gmail.com", 900000);
            dp.DisplayDetails();
            dp.WriteCode();

            Console.ReadLine();
        }
    }
}
