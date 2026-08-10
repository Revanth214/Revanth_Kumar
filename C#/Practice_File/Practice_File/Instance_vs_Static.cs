using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_File
{
    class Instance_vs_Static
    {
        public string Name;
        public int Age;

        public void display()
        {
            Console.WriteLine(Name + ":" + Age);
        }
    }

    class Static_example
    {
        public static string Name;
        public static int Age;

        public static void show()
        {
            Console.WriteLine(Name + " : " + Age);
        }
    }

    class Employee
    {
        public string Name;
        public static int CompanyEmoloyeeCount;

        public void ShowName()
        {
            Console.WriteLine("Employee Name: " + Name);
        }

        public static void ShowCount()
        {
            Console.WriteLine("Employee Count: " + CompanyEmoloyeeCount);
        }
    }

}
