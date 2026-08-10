using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You can't vote");
            }
            Console.ReadLine();
        }
    }
}
