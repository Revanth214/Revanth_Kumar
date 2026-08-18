using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 500000;
            double n = (double)num;
            double ab = 45789.75;
            int cd = (int)(ab);         //feat: demonstrate implicit and explicit type casting

            Console.WriteLine("Int " + num);
            Console.WriteLine("Int to Double: " + n);
            Console.WriteLine("Double: " + ab);
            Console.WriteLine("Double to into: " + cd);

            Console.ReadLine();
        }
    }
}
