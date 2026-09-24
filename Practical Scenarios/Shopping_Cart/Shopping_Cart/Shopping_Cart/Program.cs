using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Cart
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class CartProducts
    {
        public List<Cart> items;
        public CartProducts()
        {
            items = new List<Cart>();
        }
        public void Addproducts(Cart cart)
        {
            items.Add(cart);
        }
        public double TotalAmount;
        public void CalculatePrice()
        {
            TotalAmount = 0;
            foreach (Cart item in items)
            {

                TotalAmount += item.Price;

            }
        }
        public void TotalPrice()
        {
            if (TotalAmount > 2000)
            {
                TotalAmount = TotalAmount - TotalAmount * 10 / 100;
            }
            else if (TotalAmount > 5000)
            {
                TotalAmount = TotalAmount - TotalAmount * 20 / 100;
            }
        }
        public string coupon { get; set; }
        public void ApplyCoupon()
        {
            if (coupon == "2487")
            {
                TotalAmount = TotalAmount - TotalAmount * 5 / 100;
            }
        }
        public void AllProducts()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("    Cart Summary   ");
            Console.WriteLine("=====================");
            foreach (Cart item in items)
            {
                
                Console.WriteLine($"{item.ProductName}:{item.Price}");
            }
        }
        public void Total()
        {
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CartProducts products = new CartProducts();
            Cart cart = new Cart();
            cart.ProductName = "Tie";
            cart.Price = 265;
            products.Addproducts(cart);

            Cart c2 = new Cart();
            c2.ProductName = "Shirt";
            c2.Price = 500;
            products.Addproducts(c2);
            products.CalculatePrice();
            products.AllProducts();
            products.Total();
            Console.WriteLine("Do you want to add more products(y/n):");
            string choice = Console.ReadLine();
            while(choice == "y")
            {
                Cart c3 = new Cart();
                Console.WriteLine("Enter Product Name: ");
                c3.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Price: ");
                c3.Price = Convert.ToDouble(Console.ReadLine());
                products.Addproducts(c3);
                products.CalculatePrice();
                products.AllProducts();
                products.Total();
                Console.WriteLine("Do you want to add more(y/n):");
                choice = Console.ReadLine();
                
            }
            products.CalculatePrice();
            products.TotalPrice();
            Console.WriteLine("Enter Coupon Number if you had then write 'No': ");
            products.coupon = Console.ReadLine();
            products.AllProducts();
            products.Total();

            Console.ReadLine();
        }
    }
}
