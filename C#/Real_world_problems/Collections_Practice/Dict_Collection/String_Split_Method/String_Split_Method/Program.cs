using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Split_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] data = text.Split(' ');
            string Largest_text = "";
            foreach(var txt in data)
            {
                if (Largest_text.Length < txt.Length)
                {
                    Largest_text = txt;
                }
            }
            Console.WriteLine("Largest text in sentence: " + Largest_text);

            Console.ReadLine();
        }
    }
}
