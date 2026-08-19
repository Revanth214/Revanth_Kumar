using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Employee
    {
        public string EmployeeName;
        public decimal Salary;
        public string Department;

        public Employee(string name, decimal salary, string department)
        {
            EmployeeName = name;
            Salary = salary;
            Department = department;
        }
        public Employee(Employee cpy)
        {
            EmployeeName = cpy.EmployeeName;
            Salary = cpy.Salary;
            Department = cpy.Department;
        }

        public void Display()
        {
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("Employee Department: " + Department);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Employee("Bharath", 5000000, "Entertinement");
            Employee ee2 = new Employee(ee);
            ee2.Salary = 20000;

            Console.WriteLine("Original:");
            ee.Display();

            Console.WriteLine("Copied:");
            ee2.Display();

            Console.ReadLine();
        }
    }
}
