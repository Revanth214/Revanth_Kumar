using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine(name);
            Console.Write("Enter a integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a float number: ");
            float nm = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a double value: ");
            double db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num}, {nm}, {ch}, {db}");
            Console.ReadLine();
        }
    }
}
