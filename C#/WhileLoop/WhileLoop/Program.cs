using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num<5)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadLine();
        }
    }
}
