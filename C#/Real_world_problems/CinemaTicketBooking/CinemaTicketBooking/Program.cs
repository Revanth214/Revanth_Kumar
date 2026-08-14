using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerCount = 0;
            int ticketSoldCount = 0;

            decimal totalRevenueBeforeDiscount = 0;
            decimal totalDiscount = 0;
            decimal finalRevenue = 0;

            decimal highestRevenue = 0;
            string highestSpendingCustomer = "";

            string customer = "yes";

            while (customer.ToLower() != "no")
            {
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

                Console.Write("Enter customer age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of tickets: ");
                int numberOfTickets = Convert.ToInt32(Console.ReadLine());

                // Determine ticket price
                decimal ticketPrice;

                if (age < 5)
                {
                    ticketPrice = 0;
                }
                else if (age <= 17)
                {
                    ticketPrice = 120;
                }
                else if (age <= 59)
                {
                    ticketPrice = 200;
                }
                else
                {
                    ticketPrice = 150;
                }

                // Calculate this customer's order
                decimal customerRevenue = ticketPrice * numberOfTickets;

                decimal customerDiscount = 0;

                if (numberOfTickets >= 5)
                {
                    customerDiscount = customerRevenue * 10 / 100;
                }

                decimal customerFinalAmount =
                    customerRevenue - customerDiscount;

                // Update overall totals
                customerCount++;
                ticketSoldCount += numberOfTickets;

                totalRevenueBeforeDiscount += customerRevenue;
                totalDiscount += customerDiscount;
                finalRevenue += customerFinalAmount;

                // Find highest-spending customer
                if (customerFinalAmount > highestRevenue)
                {
                    highestRevenue = customerFinalAmount;
                    highestSpendingCustomer = customerName;
                }

                // Display current customer's bill
                Console.WriteLine("\n----- Customer Bill -----");
                Console.WriteLine("Customer: " + customerName);
                Console.WriteLine("Revenue: ₹" + customerRevenue);
                Console.WriteLine("Discount: ₹" + customerDiscount);
                Console.WriteLine("Final Amount: ₹" + customerFinalAmount);

                Console.Write("\nDo you want to continue? (yes/no): ");
                customer = Console.ReadLine();

                Console.WriteLine();
            }

            // Final summary
            Console.WriteLine("========= CINEMA TICKET SUMMARY =========");

            Console.WriteLine("Total customers: " + customerCount);
            Console.WriteLine("Total tickets sold: " + ticketSoldCount);
            Console.WriteLine(
                "Total revenue before discounts: ₹" +
                totalRevenueBeforeDiscount);

            Console.WriteLine(
                "Total discounts: ₹" +
                totalDiscount);

            Console.WriteLine(
                "Final revenue: ₹" +
                finalRevenue);

            Console.WriteLine(
                "Highest-spending customer: " +
                highestSpendingCustomer +
                " - ₹" +
                highestRevenue);

            Console.ReadLine();
        }
    }
}
