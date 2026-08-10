using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Operators
{
    class Arthmetic
    {
        public void Fun()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Additio of " + num1 + " and " + num2 + " is: " + (num1 + num2));
            Console.WriteLine("Subtraction of " + num1 + " and " + num2 + " is: " + (num1 - num2));
            Console.WriteLine("Multiplication of " + num1 + " and " + num2 + " is: " + (num1 * num2));
            Console.WriteLine("Division of " + num1 + " and " + num2 + " is: " + (num1 / num2));
            Console.WriteLine("Modulus of " + num1 + " and " + num2 + " is: " + (num1 % num2));
        }
    }
    class Assignment
    {
        public void Greet()
        {
            int num = 100;
            Console.WriteLine("Equal to: " + num);
            num+= 120;
            Console.WriteLine("Plus equal to: "+ num);
            num -= 120;
            Console.WriteLine("Minus equal to: "+ num);
            num *= 5;
            Console.WriteLine("Multiplication equal to: "+ num);
            num /= 50;
            Console.WriteLine("Division equal to: "+ num);
        }
    }

    class Comparision
    {
        public void Cam()
        {
            int a = 25;
            if (a==25)
            {
                Console.WriteLine("A is equal to 25");
            }
            else if (a>=25)
            {
                Console.WriteLine("A is greater than or equal to 25");
            }
            else if (a<=25)
            {
                Console.WriteLine("A si less than or equal to 25");
            }
            
        }
    }

    class Logical
    {
        public void Let()
        {
            int num = 100;
            if (num>99 && num <101)
            {
                Console.WriteLine("num is 100");
            }
        }
    }

    class IncreDecree
    {
        public void Incre()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Increment of " + num + " is: " + (++num));
            Console.WriteLine("Decrement of " + num + " is: " + (--num));
        }
    }

    class Ternary
    {
        public void Thor()
        {
            int age = 16;
            string result = age > 18 ? "Adult" : "Minor";
            Console.WriteLine(result);

        }
    }
}
