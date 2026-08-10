using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the signal color: ");
            string color = Console.ReadLine();
            if (color is "red")
            {
                Console.WriteLine("Stop!");
            }
            else if (color is "yellow")
            {
                Console.WriteLine("Slow down");
            }
            else if (color is "green")
            {
                Console.WriteLine("Go!");
            }
            else
            {
                Console.WriteLine("Invalid traffic color");
            }
            Console.ReadLine();
        }
    }
}
