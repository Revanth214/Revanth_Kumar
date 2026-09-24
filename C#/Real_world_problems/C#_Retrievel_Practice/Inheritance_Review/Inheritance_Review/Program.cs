using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Review
{
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
