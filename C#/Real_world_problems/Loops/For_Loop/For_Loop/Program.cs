using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j=0; j<arr.Length; j++)
            {
                Console.WriteLine($"{j}:{arr[j]}");
            }
            Console.ReadLine();
        }
    }
}
