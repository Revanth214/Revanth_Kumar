using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_constructor_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Developer data===========");
            Developer developer =
                new Developer("Revanth", 5, 1000000, "C#");

            Console.WriteLine("Developer Name: "+developer.Name);
            Console.WriteLine("Developer ID: " + developer.EmployeeID);
            Console.WriteLine("Developer Salary: " + developer.Salary);
            Console.WriteLine("Developer Programming Langauge: " + developer.ProgrammingLanguage);

            Console.WriteLine("=============Manager data============");
            Manager mg = new Manager("Bharath", 10, 5000000, 12);            
            Console.WriteLine("Manager Name: " + mg.Name);
            Console.WriteLine("Manager ID: " + mg.EmployeeID);
            Console.WriteLine("Manager salary: " + mg.Salary);
            Console.WriteLine("Manager Team Size: " + mg.TeamSize);

            Console.ReadLine();
        }
    }
}
