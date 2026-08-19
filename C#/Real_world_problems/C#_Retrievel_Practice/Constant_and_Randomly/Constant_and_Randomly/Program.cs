using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Constants_And_Readonly
{
    class Order
    {
        // Cannot be changed after declaration
        const decimal MaxOrderAmount = 100000;

        // Can be assigned in the constructor, but not changed afterward
        public readonly int OrderId;

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public void Display()
        {
            Console.WriteLine("Max Order Amount: " + MaxOrderAmount);
            Console.WriteLine("Order ID: " + OrderId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(101);
            Order order2 = new Order(102);

            Console.WriteLine("========= Order 1 =========");
            order1.Display();

            Console.WriteLine("\n========= Order 2 =========");
            order2.Display();

            // ❌ Compilation errors:
            // order1.OrderId = 500;
            // Order.MaxOrderAmount = 200000;

            Console.ReadLine();
        }
    }
}
