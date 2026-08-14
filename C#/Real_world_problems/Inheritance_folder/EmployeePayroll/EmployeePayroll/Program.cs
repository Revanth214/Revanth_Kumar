using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Developer Details=========");
            Developer dv = new Developer("Revanth", "The K2", 100000, "C#");
            dv.DisplayDetails();
            Console.WriteLine($"Programming Langauge: {dv.ProgrammingLangauge}");
            dv.WriteCode();

            Console.WriteLine("=========Manager details==============");
            Manager mn = new Manager("Rama", "The K1", 5000000, 12);
            mn.DisplayDetails();
            Console.WriteLine($"Team size: {mn.TeamSize}");
            mn.ConductMeeting();

            Console.ReadLine();
        }
    }
}
