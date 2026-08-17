using System;
using System.Collections.Generic;

namespace E_Commerce_Payment_Order_System
{
    // Interface
    interface IPayment
    {
        void Pay(decimal amount);
    }


    // Interface implementation
    class UPIPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using UPI.");
        }
    }


    // Interface implementation
    class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Credit Card.");
        }
    }


    // Interface implementation
    class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Cash.");
        }
    }

    // Abstraction
    abstract class Order
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public decimal Amount { get; private set; }

        public Order(string name, int id, decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Order amount cannot be negative.");
            }

            Name = name;
            ID = id;
            Amount = amount;
        }

        public abstract void DisplayDetails();
    }


    // Inheritance
    class OnlineOrder : Order
    {
        public string DeliveryAddress { get; private set; }

        // Composition: OnlineOrder HAS an IPayment
        public IPayment Payment { get; private set; }

        public OnlineOrder(
            string name,
            int id,
            decimal amount,
            string address,
            IPayment payment)  // "When creating an order, give me a payment method."
            : base(name, id, amount)
        {
            DeliveryAddress = address;
            Payment = payment;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("===== Online Order =====");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer ID: {ID}");
            Console.WriteLine($"Amount: ₹{Amount}");
            Console.WriteLine($"Delivery Address: {DeliveryAddress}");
        }

        public void MakePayment()
        {
            Payment.Pay(Amount);
        }
    }


    // Inheritance
    class StoreOrder : Order
    {
        public string StoreLocation { get; private set; }

        // Composition
        public IPayment Payment { get; private set; }

        public StoreOrder(
            string name,
            int id,
            decimal amount,
            string storeLocation,
            IPayment payment)
            : base(name, id, amount)
        {
            StoreLocation = storeLocation;
            Payment = payment;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("===== Store Order =====");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer ID: {ID}");
            Console.WriteLine($"Amount: ₹{Amount}");
            Console.WriteLine($"Store Location: {StoreLocation}");
        }

        public void MakePayment()
        {
            Payment.Pay(Amount);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            // Different payment objects
            IPayment upi = new UPIPayment();
            IPayment card = new CardPayment();
            IPayment cash = new CashPayment();


            // Different orders
            OnlineOrder onlineOrder =
                new OnlineOrder(
                    "Revanth",
                    101,
                    5000,
                    "Peddarikunta",
                    upi);

            StoreOrder storeOrder =
                new StoreOrder(
                    "Bharath",
                    102,
                    3000,
                    "Bangalore Store",
                    card);


            // Store different order types together
            List<Order> orders = new List<Order>();

            orders.Add(onlineOrder);
            orders.Add(storeOrder);


            // Runtime polymorphism
            foreach (Order order in orders)
            {
                order.DisplayDetails();
                Console.WriteLine();
            }


            // Process payments
            Console.WriteLine("===== Payment Processing =====");

            onlineOrder.MakePayment();
            storeOrder.MakePayment();


            Console.ReadLine();
        }
    }
}