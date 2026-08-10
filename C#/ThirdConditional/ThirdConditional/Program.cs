using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you have License: ");
            bool license =Convert.ToBoolean(Console.ReadLine()); 
            if (age>18)
            {
                if (license)
                {
                    Console.WriteLine("You can drive");
                }
                else
                {
                    Console.WriteLine("You need License to drive a vehicle");
                }
            }
            else
            {
                Console.WriteLine("You are too young to drive");
            }
            Console.ReadLine();
        }
    }
}
