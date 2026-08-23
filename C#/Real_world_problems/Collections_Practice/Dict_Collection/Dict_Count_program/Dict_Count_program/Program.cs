using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Count_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 10, 30, 20 };
            Dictionary<int, int> elements = new Dictionary<int, int>();

            foreach(int number in arr)
            {
                if (elements.ContainsKey(number))
                {
                    elements[number]++;
                }
                else
                {
                    elements[number] = 1;
                }
            }

            foreach(KeyValuePair<int, int> variable in elements)
            {
                Console.WriteLine($"{variable.Key} : {variable.Value}");
            }
            Console.ReadLine();
        }
    }
}
