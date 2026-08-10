using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchConsitional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month number: ");
            int month_num = Convert.ToInt32(Console.ReadLine());
            switch (month_num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    goto case 9;  // If you intentionally want to continue to another case, use "goto case".
                case 9:
                    Console.WriteLine("September");
                    goto case 10;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("There is no such a numbered month");
                    break;
            }
            Console.ReadLine();
        }
    }
}
