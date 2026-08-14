using System;

namespace RestaurantOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderCount = 0;
            int totalQuantity = 0;
            decimal totalBill = 0;

            while (true)
            {
                Console.WriteLine("\n======= MENU =======");
                Console.WriteLine("1. Burger  - ₹150");
                Console.WriteLine("2. Pizza   - ₹300");
                Console.WriteLine("3. Biryani - ₹250");
                Console.WriteLine("4. Coffee  - ₹100");
                Console.WriteLine("5. Exit");

                Console.Write("Select your item: ");
                int item = Convert.ToInt32(Console.ReadLine());

                if (item == 5)
                {
                    break;
                }

                decimal price = 0;

                switch (item)
                {
                    case 1:
                        price = 150;
                        break;

                    case 2:
                        price = 300;
                        break;

                    case 3:
                        price = 250;
                        break;

                    case 4:
                        price = 100;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity must be greater than zero.");
                    continue;
                }

                decimal itemTotal = price * quantity;

                totalBill += itemTotal;
                totalQuantity += quantity;
                orderCount++;

                Console.WriteLine("Item total: ₹" + itemTotal);
                Console.WriteLine("Item added successfully.");
            }

            Console.WriteLine("\n========== YOUR BILL ==========");

            Console.WriteLine("Number of orders: " + orderCount);
            Console.WriteLine("Total quantity: " + totalQuantity);
            Console.WriteLine("Total bill: ₹" + totalBill);

            Console.ReadLine();
        }
    }
}