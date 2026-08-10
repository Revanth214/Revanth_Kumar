using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is a even number");
                }
                i++;
            }
            while (i < 21);
            Console.ReadLine();
        }
    }
}
