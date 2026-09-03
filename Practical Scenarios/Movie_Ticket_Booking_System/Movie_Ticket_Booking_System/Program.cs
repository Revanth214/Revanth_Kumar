using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System
{
    class MovieBooking
    {
        public string MovieName { get; set; }
        public Dictionary<string, int> TicketType { get; set; }

        public decimal TotalAmount=0;
        public int TotalTickets = 0;
        public void FindTotalAmount()
        {
            foreach(var typ in TicketType)
            {
                if (typ.Key == "Regular")
                {
                    TotalAmount = typ.Value * 100 + TotalAmount;
                    TotalTickets = typ.Value+ TotalTickets;
                }
                else if (typ.Key == "Premium")
                {
                    TotalAmount = typ.Value * 150+ TotalAmount;
                    TotalTickets = typ.Value + TotalTickets;
                }
                else if (typ.Key == "VIP")
                {
                    TotalAmount = typ.Value * 200 + TotalAmount;
                    TotalTickets = typ.Value + TotalTickets;
                }
                
            }
        }
        public decimal Discount;
        public decimal TotalAmount_AfterDiscount;
        public void AfterDiscount()
        {
            if (TotalTickets > 5)
            {
                Discount = TotalAmount*5/100;
                TotalAmount_AfterDiscount = TotalAmount-Discount;
            }
        }
        public void Display()
        {
            Console.WriteLine($"======Movie Ticket Summary=======");
            Console.WriteLine("Movie Name: " + MovieName);
            Console.WriteLine("------Ticket Type and Count------");
            foreach (var typ in TicketType)
            {
                if (typ.Key == "Regular")
                {
                    Console.WriteLine($"{typ.Key}:{typ.Value}");
                }
                else if (typ.Key == "Premium")
                {
                    Console.WriteLine($"{typ.Key}:{typ.Value}");
                }
                else if (typ.Key == "VIP")
                {
                    Console.WriteLine($"{typ.Key}:{typ.Value}");
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Total Number of Tickets: " + TotalTickets);
            Console.WriteLine("Total Amount: " + TotalAmount);
            Console.WriteLine($"Total Discount: " + Discount);
            Console.WriteLine($"Amount after Discount: " + TotalAmount_AfterDiscount);
            Console.WriteLine("---------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MovieBooking mb = new MovieBooking();
            mb.MovieName = "Hanuman";
            mb.TicketType = new Dictionary<string, int>();
            mb.TicketType.Add("Regular",1);
            mb.TicketType.Add("Premium",2);
            mb.TicketType.Add("VIP",5);
            mb.FindTotalAmount();
            mb.AfterDiscount();
            mb.Display();

            Console.ReadLine();
        }
    }
}
/*
Movie Ticket Booking

A movie theatre wants a simple ticket-booking program.

Requirements:

Ask the user for movie name, number of tickets and ticket type.
Ticket prices depend on type: Regular, Premium, VIP.
Calculate the total amount using a function.
If the customer buys more than 5 tickets, give a discount.
Display a formatted booking summary.
Store the booked movie names in a collection.
Allow the user to search whether a particular movie has been booked.

Concepts: if-else, loops, functions, strings, collections.
*/

