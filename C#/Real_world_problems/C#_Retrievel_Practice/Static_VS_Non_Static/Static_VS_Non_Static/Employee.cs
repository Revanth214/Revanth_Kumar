using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_VS_Non_Static
{
    class Employee
    {
        public string EmployeeName;
        public decimal Salary;

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Salary: " + Salary);
        }

        public static decimal CalculateTax(decimal salary)
        {
            return salary * 10 / 100;
        }
    }
}
