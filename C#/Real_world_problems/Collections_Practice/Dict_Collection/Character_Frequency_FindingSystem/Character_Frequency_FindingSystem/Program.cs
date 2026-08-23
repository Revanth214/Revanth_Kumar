using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Frequency_FindingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            string CleanedText = text.ToLower().Replace(" ", "");
            Dictionary<char, int> data = new Dictionary<char, int>();
            foreach(char ch in CleanedText)
            {
                if (data.ContainsKey(ch))
                {
                    data[ch]++;
                }
                else
                {
                    data[ch] = 1;
                }
            }
            foreach(var i in data)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
                
            }
            Console.WriteLine("Total Characters: " + CleanedText.Length);

            Console.ReadLine();
        }
    }
}
