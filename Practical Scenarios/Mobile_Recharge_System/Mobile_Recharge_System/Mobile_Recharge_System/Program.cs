using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Recharge_System
{
    // Represents one recharge transaction
    class Recharge
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Plan { get; set; }
        public int Days { get; set; }
        public double Data { get; set; }
        public double Price { get; set; }
        public string PaymentMethod { get; set; }

        public void Display()
        {
            Console.WriteLine("\n----- Recharge Details -----");
            Console.WriteLine($"Customer Name : {Name}");
            Console.WriteLine($"Mobile Number : {MobileNumber}");
            Console.WriteLine($"Plan          : {Plan}");

            if (Plan == "Data-only")
            {
                Console.WriteLine($"Data          : {Data} GB");
            }
            else
            {
                Console.WriteLine($"Validity      : {Days} days");
            }

            Console.WriteLine($"Amount        : ₹{Price:F2}");
            Console.WriteLine($"Payment       : {PaymentMethod}");
            Console.WriteLine("-----------------------------");
        }
    }


    // Interface for payment
    interface IPayment
    {
        void Pay(double amount);
    }


    // UPI payment
    class UPI : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"₹{amount:F2} paid successfully through UPI.");
        }
    }


    // Card payment
    class Card : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"₹{amount:F2} paid successfully through Card.");
        }
    }


    // Wallet payment
    class Wallet : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"₹{amount:F2} paid successfully through Wallet.");
        }
    }


    class MobileRecharge
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Plan { get; set; }

        public double Price { get; private set; }
        public int Days { get; set; }
        public double Data { get; set; }

        // List stores all recharge transactions
        public List<Recharge> RechargeHistory { get; set; }


        public MobileRecharge()
        {
            RechargeHistory = new List<Recharge>();
        }


        // Display available plans
        public void AvailablePlans()
        {
            Console.WriteLine("\n===== Available Plans =====");
            Console.WriteLine("1. Prepaid");
            Console.WriteLine("2. Data-only");
            Console.WriteLine("3. Unlimited");
        }


        // Display offers according to plan
        public void Offers()
        {
            Console.WriteLine("\n===== Offer =====");

            if (Plan == "Prepaid")
            {
                Console.WriteLine("You will get Netflix and Amazon subscriptions.");
            }
            else if (Plan == "Data-only")
            {
                Console.WriteLine("You will get 2 GB bonus data.");
            }
            else if (Plan == "Unlimited")
            {
                Console.WriteLine("You will get 5G Unlimited Data and 90 days free JioHotstar subscription.");
            }
        }


        // Calculate recharge price
        public void RechargePrice()
        {
            Price = 0;

            if (Plan == "Prepaid")
            {
                double pricePerDay = 10.678;

                if (Days == 28)
                {
                    Price = 28 * pricePerDay;
                }
                else if (Days == 56)
                {
                    Price = 56 * pricePerDay;
                }
                else if (Days == 84)
                {
                    Price = 84 * pricePerDay;
                }
            }

            else if (Plan == "Data-only")
            {
                if (Data == 1.0)
                {
                    Price = 28;
                }
                else if (Data == 2.0)
                {
                    Price = 56;
                }
                else if (Data == 3.0)
                {
                    Price = 84;
                }
            }

            else if (Plan == "Unlimited")
            {
                double pricePerDay = 15.678;

                if (Days == 28)
                {
                    Price = 28 * pricePerDay;
                }
                else if (Days == 56)
                {
                    Price = 56 * pricePerDay;
                }
                else if (Days == 84)
                {
                    Price = 84 * pricePerDay;
                }
            }
        }


        // Display validity options
        public void AvailableValidity()
        {
            Console.WriteLine("\nSelect Validity:");
            Console.WriteLine("1. 28 Days");
            Console.WriteLine("2. 56 Days");
            Console.WriteLine("3. 84 Days");
        }


        // Display data options
        public void AvailableData()
        {
            Console.WriteLine("\nSelect Data:");
            Console.WriteLine("1. 1 GB");
            Console.WriteLine("2. 2 GB");
            Console.WriteLine("3. 3 GB");
        }


        // Process payment
        public IPayment SelectPayment()
        {
            Console.WriteLine("\n===== Payment Method =====");
            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Card");
            Console.WriteLine("3. Wallet");

            Console.Write("Select Payment Method: ");
            string choice = Console.ReadLine();

            IPayment payment = null;

            if (choice == "1")
            {
                payment = new UPI();
            }
            else if (choice == "2")
            {
                payment = new Card();
            }
            else if (choice == "3")
            {
                payment = new Wallet();
            }
            else
            {
                Console.WriteLine("Invalid payment method.");
            }

            return payment;
        }


        // Save recharge into history
        public void StoreRecharge(IPayment payment)
        {
            Recharge recharge = new Recharge();

            recharge.Name = Name;
            recharge.MobileNumber = MobileNumber;
            recharge.Plan = Plan;
            recharge.Days = Days;
            recharge.Data = Data;
            recharge.Price = Price;
            recharge.PaymentMethod = payment.GetType().Name;

            RechargeHistory.Add(recharge);

            Console.WriteLine("\nRecharge stored in history.");
        }


        // Search recharge history using mobile number
        public void SearchHistory(long mobileNumber)
        {
            bool found = false;

            Console.WriteLine("\n===== Recharge History =====");

            foreach (Recharge recharge in RechargeHistory)
            {
                if (recharge.MobileNumber == mobileNumber)
                {
                    recharge.Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No recharge history found for this mobile number.");
            }
        }


        // Display complete recharge history
        public void DisplayHistory()
        {
            Console.WriteLine("\n===== Complete Recharge History =====");

            if (RechargeHistory.Count == 0)
            {
                Console.WriteLine("No recharge history available.");
                return;
            }

            foreach (Recharge recharge in RechargeHistory)
            {
                recharge.Display();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MobileRecharge mr = new MobileRecharge();

            Console.WriteLine("=================================");
            Console.WriteLine("       MOBILE RECHARGE SYSTEM");
            Console.WriteLine("=================================");

            // Customer details
            Console.Write("Enter Customer Name: ");
            mr.Name = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            mr.MobileNumber = long.Parse(Console.ReadLine());

            // Display plans
            mr.AvailablePlans();

            Console.Write("Select Your Plan: ");
            string planChoice = Console.ReadLine();

            // Select plan
            if (planChoice == "1")
            {
                mr.Plan = "Prepaid";
            }
            else if (planChoice == "2")
            {
                mr.Plan = "Data-only";
            }
            else if (planChoice == "3")
            {
                mr.Plan = "Unlimited";
            }
            else
            {
                Console.WriteLine("Invalid plan.");
                return;
            }


            // Select validity or data
            if (mr.Plan == "Data-only")
            {
                mr.AvailableData();

                Console.Write("Select Data: ");
                string dataChoice = Console.ReadLine();

                if (dataChoice == "1")
                {
                    mr.Data = 1.0;
                }
                else if (dataChoice == "2")
                {
                    mr.Data = 2.0;
                }
                else if (dataChoice == "3")
                {
                    mr.Data = 3.0;
                }
                else
                {
                    Console.WriteLine("Invalid data option.");
                    return;
                }
            }
            else
            {
                mr.AvailableValidity();

                Console.Write("Select Validity: ");
                string validityChoice = Console.ReadLine();

                if (validityChoice == "1")
                {
                    mr.Days = 28;
                }
                else if (validityChoice == "2")
                {
                    mr.Days = 56;
                }
                else if (validityChoice == "3")
                {
                    mr.Days = 84;
                }
                else
                {
                    Console.WriteLine("Invalid validity.");
                    return;
                }
            }


            // Calculate price
            mr.RechargePrice();

            Console.WriteLine($"\nRecharge Amount: ₹{mr.Price:F2}");

            // Show offer
            mr.Offers();

            // Select payment
            IPayment payment = mr.SelectPayment();

            if (payment == null)
            {
                return;
            }

            // Payment
            payment.Pay(mr.Price);

            // Store recharge
            mr.StoreRecharge(payment);

            // Display current recharge
            Console.WriteLine("\nRecharge Successful!");
            Console.WriteLine($"Amount Paid: ₹{mr.Price:F2}");

            // Search history
            Console.Write("\nEnter mobile number to search recharge history: ");
            long searchNumber = long.Parse(Console.ReadLine());

            mr.SearchHistory(searchNumber);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
