using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dpr = new Developer();
            dpr.ProgrammingLanguage = "C Sharp";
            dpr.Name = "Revanth";
            dpr.EmployeeID = 5;
            dpr.salary = 10000000;
            Console.WriteLine("===========Developer class=============");
            dpr.DisplayDetails();
            dpr.WriteCode();
            Manager mg = new Manager();
            mg.TeamSize = 5;
            mg.Name = "Bharath";
            mg.EmployeeID = 17;
            mg.salary = 20000000;
            Console.WriteLine("=======Manager class===========");
            mg.DisplayDetails();
            mg.ConductMeeting();

            Console.ReadLine();
        }
    }
}
