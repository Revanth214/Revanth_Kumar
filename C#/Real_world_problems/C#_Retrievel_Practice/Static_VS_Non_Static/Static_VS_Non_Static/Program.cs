using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_VS_Non_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ey = new Employee();
            ey.EmployeeName = "Revanth";
            ey.Salary = 1000000;
            ey.DisplayDetails();
            decimal tax=Employee.CalculateTax(200000);
            Console.WriteLine("Tax: " + tax);

            Console.ReadLine();
        }
    }
}
