using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Skills = new ArrayList();

            Skills.Add("C#");
            Skills.Add("SQL");
            Skills.Add("ASP.NET");

            foreach (object mem in Skills)
            {
                Console.WriteLine(mem);
            }
            Skills.Add("Azure");
            Skills.Remove("SQL");
            if (Skills.Contains("C#"))
            {
                Console.WriteLine("C# Exists in this Array List");
            }
            Console.WriteLine("Size of the ArrayList: " + Skills.Count);

            foreach (object arr in Skills)
            {
                Console.WriteLine($"{arr}");
            }
            Console.WriteLine("First skill: " + Skills[0]);

            Console.ReadLine();
        }
    }
}
