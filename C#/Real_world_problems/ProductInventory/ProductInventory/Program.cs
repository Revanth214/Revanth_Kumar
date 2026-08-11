using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName;
            int price;
            int quantity;
            string user = "start";
            int ProductsCount=0;
            int InventoryValue=0;
            int OutOfStockCount=0;
            int LowStockCount=0;
            int InStockCount=0;
            int HighestStockValue=0;
            string HighestValueProductName=" ";
            while (user != "stop")
            {
                Console.Write("Enter Product Name: ");
                productName = Console.ReadLine();
                Console.Write("Enter Product price: ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Product quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                int stockValue = price * quantity;

                ProductsCount++;
                InventoryValue += stockValue;

                if (quantity == 0)
                {
                    OutOfStockCount++;
                }
                else if(quantity>=1 && quantity <= 10)
                {
                    LowStockCount++;
                }
                else
                {
                    InStockCount++;
                }

                if (HighestStockValue < stockValue)
                {
                    HighestValueProductName = productName;
                    HighestStockValue = stockValue;
                }
                Console.WriteLine("Do you want to stop entering products (stop/no): ");
                user =Console.ReadLine();

            }
            Console.WriteLine("=============Product Inventory summary===============");

            Console.WriteLine("Total number of products: " + ProductsCount);
            Console.WriteLine("Total inventory value: " + InventoryValue);
            Console.WriteLine("Number of out-of-stock products: "+OutOfStockCount);
            Console.WriteLine("Number of low-stock products: "+LowStockCount);
            Console.WriteLine("Number of in-stock products: "+InStockCount);
            Console.WriteLine($"Product with the highest stock value is  {HighestValueProductName}: {HighestStockValue}");

            Console.ReadLine();
        }
    }
}
