using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employees age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee experience in years: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Underage");
            }
            else if(age>=18 && experience >= 2)
            {
                Console.WriteLine("Eligibel");
            }
            else
            {
                Console.WriteLine("Not Eligibel");
            }

            Console.ReadLine();
        }
    }
}
