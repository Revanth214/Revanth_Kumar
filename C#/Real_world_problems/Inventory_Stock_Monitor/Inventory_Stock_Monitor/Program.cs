using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Stock_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {

            string ProductName;
            int Price;
            int quantity;

            int TotalNoOfProducts = 0;
            int TotalInventoryValue = 0;
            int OutOfStock = 0;
            int LowStock = 0;
            int InStock = 0;

            int HighestStock = 0;


            string user = "start";
            while (user != "stop")
            {
                Console.WriteLine("Enter Product Name: ");
                ProductName=Console.ReadLine();
                Console.WriteLine("Enter Product Price: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
