using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Constructor c = new Constructor();

            Console.WriteLine("Name=" + c.name);
            Console.WriteLine("Number=" + c.num);
            Console.ReadLine();
        }
    }
}
