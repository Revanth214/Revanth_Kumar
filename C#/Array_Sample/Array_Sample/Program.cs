using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sample
{
    class Program
    {

        //Declaration of an array
        static void decalration()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Accessing the array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

        static void update_array()
        {
            int[] arr = { 45, 23, 65, 43, 98, 89 };

            arr[2] = 100;
            Console.WriteLine("Updating an array");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            
        }

        void Sorting()
        {
            int[] arr = { 45, 23, 65, 43, 98, 89 };
            Array.Sort(arr);
            foreach(var j in arr)
            {
                Console.WriteLine(j);
            }
        }

        void Reversing()
        {
            int[] arr = { 45, 23, 65, 43, 98, 89 };
            Array.Reverse(arr);
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
        }

        void Resetting()
        {
            int[] arr = { 45, 23, 65, 43, 98, 89 };
            Array.Clear(arr, 0, 3);
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
        }


        void MultiDimensionalArray()
        {
            int[,] multi_array = new int[3,3];
            for (int i=0; i<multi_array.GetLength(0); i++)
            {
                for (int j=0; j<multi_array.GetLength(1); j++)
                {
                    multi_array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix:");

            for (int i = 0; i < multi_array.GetLength(0); i++)
            {
                for (int j = 0; j < multi_array.GetLength(1); j++)
                {
                    Console.Write(multi_array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //decalration();
            //update_array();

            Program obj = new Program();
            Console.WriteLine("--------------Sorting-----------------");

            obj.Sorting();

            Console.WriteLine("--------------Reversing-----------------");
            obj.Reversing();

            Console.WriteLine("--------------Reversing-----------------");
            obj.Resetting();

            Console.WriteLine("--------------MultiDimensional array-----------------");
            obj.MultiDimensionalArray();
            Console.ReadLine();
        }

    }
}
