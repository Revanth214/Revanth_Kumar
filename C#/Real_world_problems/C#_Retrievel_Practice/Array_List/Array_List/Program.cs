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
            ArrayList members = new ArrayList();

            members.Add("C#");
            members.Add("SQL");
            members.Add("ASP.NET");

            foreach (object mem in members)
            {
                Console.WriteLine(mem);
            }
            members.Add("Azure");
            members.Remove("SQL");
            if (members.Contains("C#"))
            {
                Console.WriteLine("C# Exists in this Array List");
            }
            Console.WriteLine("Size of the ArrayList: " + members.Count);

            foreach (object arr in members)
            {
                Console.WriteLine($"{arr}");
            }
            Console.WriteLine("First skill in the ArrayList: " + members[0]);

            Console.ReadLine();
        }
    }
}
