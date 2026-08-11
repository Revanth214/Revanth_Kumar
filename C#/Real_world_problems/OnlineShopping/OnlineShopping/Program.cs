using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName;
            decimal productPrice;
            int quantity;

            string customer = "start";

            int orderCount = 0;

            decimal totalBeforeDiscount = 0;
            decimal totalDiscount = 0;
            decimal totalFinalAmount = 0;

            decimal highestFinalAmount = 0;
            string highestProduct = "";

            while (customer.ToLower() != "stop")
            {
                // Get product details
                Console.Write("Enter product name: ");
                productName = Console.ReadLine();

                Console.Write("Enter product price: ");
                productPrice = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                // Calculate current order total
                decimal orderTotal = productPrice * quantity;

                // Calculate discount
                decimal discount = 0;

                if (orderTotal >= 5000)
                {
                    discount = orderTotal * 10 / 100;
                }

                // Calculate final amount for this order
                decimal finalAmount = orderTotal - discount;

                // Count orders
                orderCount++;

                // Add current order to overall totals
                totalBeforeDiscount += orderTotal;
                totalDiscount += discount;
                totalFinalAmount += finalAmount;

                // Find highest order
                if (finalAmount > highestFinalAmount)
                {
                    highestFinalAmount = finalAmount;
                    highestProduct = productName;
                }

                // Display current order
                Console.WriteLine("\n----- Current Order -----");
                Console.WriteLine("Product: " + productName);
                Console.WriteLine("Order Total: " + orderTotal);
                Console.WriteLine("Discount: " + discount);
                Console.WriteLine("Final Amount: " + finalAmount);

                // Ask whether customer wants another order
                Console.Write("\nDo you want to order again? (yes/stop): ");
                customer = Console.ReadLine();

                Console.WriteLine();
            }

            // Final summary
            Console.WriteLine("========== ORDER SUMMARY ==========");

            Console.WriteLine("Total number of orders: " + orderCount);
            Console.WriteLine("Total before discount: " + totalBeforeDiscount);
            Console.WriteLine("Total discount given: " + totalDiscount);
            Console.WriteLine("Final amount paid: " + totalFinalAmount);
            Console.WriteLine("Highest order: " + highestFinalAmount);
            Console.WriteLine("Highest order product: " + highestProduct);

            Console.ReadLine();
        }
    }
}
