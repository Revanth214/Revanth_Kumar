using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commers_Order_System
{
    class Order
    {
        public int OrderId { get; private set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; private set; }

        public Order(int id, string name, DateTime date, decimal amount)
        {
            OrderId = id;
            CustomerName = name;
            OrderDate = date;
            if (amount > 0)
            {
                TotalAmount = amount;
            }
            else
            {
                throw new ArgumentException("Order amount shouldn't be negative");
            }
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }

    }
    class OnlineOrder: Order
    {
        public string DeliveryAddress { get; set; }
        public decimal ShippingFee { get; set; }

        public OnlineOrder(int id, string name, DateTime date, decimal amount, string address, decimal shippingfee):base(id, name, date, amount)
        {
            DeliveryAddress = address;
            ShippingFee = shippingfee;
        }

        public void CalculateFinalAmount()
        {
            Console.WriteLine("Order amount: "+ TotalAmount);
            Console.WriteLine("Shipping Fee: " + ShippingFee);
            decimal FinalFee = TotalAmount + ShippingFee;
            Console.WriteLine("Final Amount: " + FinalFee);
        }
    }
    class StorePickupOrder: Order
    {
        public string StoreLocation { get; set; }
        public string PickupPersonName { get; set; }
        public StorePickupOrder(int id, string name, DateTime date, decimal amount, string location, string pickupperson) : base(id, name, date, amount)
        {
            StoreLocation = location;
            PickupPersonName = pickupperson;
        }

        public void PrepareForPickup()
        {
            Console.WriteLine("Order is ready for pickup at Bangalore Store.");
            Console.WriteLine($"Pickup person: {PickupPersonName}");
        }
    }
    class CorporateOrder:Order
    {
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }

        public CorporateOrder(int id, string name, DateTime date, decimal amount, string companyname, int noofemployee) : base(id, name, date, amount)
        {
            CompanyName = companyname;
            NumberOfEmployees = noofemployee;
        }

        public void CalculateDiscount()
        {
            decimal Discount = TotalAmount * 5 / 100;
            Console.WriteLine("Order amount: " + TotalAmount);
            Console.WriteLine("Discount : " + Discount);
            decimal FinalAmount = TotalAmount - Discount;
            Console.WriteLine("Final Amount: " + FinalAmount);
        }
    }
}
