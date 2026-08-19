using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Employee
    {
        string EmployeeName;
        decimal Salary;

        public Employee()
        {
            EmployeeName = "Unknown";
            Salary = 0;
        }
        public Employee(string name, decimal amount)
        {
            EmployeeName = name;
            Salary = amount;
        }

        public void Display()
        {
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Salaary: " + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee ey = new Employee();
            Console.WriteLine("=========Parameterless Constructor==========");
            ey.Display();
            Employee ee = new Employee("Revanth", 200000);
            Console.WriteLine("=========Parameterized Constructor==========");
            ee.Display();

            Console.ReadLine();
        }
    }
}
