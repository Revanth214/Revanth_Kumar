using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethods
{
    interface IPayment
    {
        void Pay(decimal amount);
    }

    class UPI : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("UPI Payment");
        }
    }
    class CASH : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Cash Payment");
        }
    }

    abstract class Order
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public Order(string name, decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Order can't be nagative");
            }
            else
            {
                Name = name;
                Amount = amount;
            }
        }


        public abstract void Display();
    }

    class Online : Order
    {
        public IPayment Paytm { get; set; }
        public Online(string name, decimal amount, IPayment payment):base(name, amount)
        {
            Paytm = payment;
        }
        public override void Display()
        {
            Console.WriteLine("======Online Order Summary===========");
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer Amount: " + Amount);
        }
        public void makePaymet()
        {
            Paytm.Pay(Amount);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IPayment upi = new UPI();
            IPayment cash = new CASH();
            Online online = new Online("Revanth", 1000000, upi);
            List<Order> orders = new List<Order>();
            orders.Add(online);

            foreach(Order ord in orders)
            {
                ord.Display();
            }

            online.makePaymet();
            Console.ReadLine();
        }
    }
}
