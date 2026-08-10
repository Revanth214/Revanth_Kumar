using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism obj = new FreeLancer();
            obj.Emp_details();
            Console.ReadLine();
        }
    }
}
