using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many records do you want: ");
            int records = Convert.ToInt32(Console.ReadLine());

            int[] sales = new int[records];

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write($"Enter sale {i + 1}: ");
                sales[i] = Convert.ToInt32(Console.ReadLine());
            }

            int totalSales = 0;
            int highestSale = sales[0];
            int lowestSale = sales[0];

            for (int i = 0; i < sales.Length; i++)
            {
                totalSales += sales[i];

                if (sales[i] > highestSale)
                {
                    highestSale = sales[i];
                }

                if (sales[i] < lowestSale)
                {
                    lowestSale = sales[i];
                }

                Console.WriteLine($"Sale {i + 1}: {sales[i]}");
            }

            double averageSale = (double)totalSales / sales.Length;

            Console.WriteLine("Total Sales: " + totalSales);
            Console.WriteLine("Highest Sale: " + highestSale);
            Console.WriteLine("Lowest Sale: " + lowestSale);
            Console.WriteLine("Average Sale: " + averageSale);

            Console.ReadLine();
        }
    }
}
