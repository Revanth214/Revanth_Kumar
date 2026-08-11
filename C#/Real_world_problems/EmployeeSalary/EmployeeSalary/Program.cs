using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee("Revanth", 50000);

            e.GiveRaise(10000);
            e.display();

            Console.ReadLine();
        }
    }
}
