using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commers_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Online Order===========");
            OnlineOrder oo = new OnlineOrder(12, "Revanth", new DateTime(2005, 10, 05), 7500000, "Peddarikunta", 50);
            oo.DisplayOrderDetails();
            oo.CalculateFinalAmount();

            Console.WriteLine("==========Store Pickup Order===========");
            StorePickupOrder sp = new StorePickupOrder(45, "Arjuna", new DateTime(2007, 10, 17), -500000, "Peddarikunta", "Bharath");
            sp.DisplayOrderDetails();
            sp.PrepareForPickup();

            Console.WriteLine("==========Corporate Order===========");
            CorporateOrder cpr = new CorporateOrder(5, "Sun", new DateTime(0001, 01, 01), 2000000, "Amazon", 500001);
            cpr.DisplayOrderDetails();
            cpr.CalculateDiscount();

            Console.ReadLine();
        }
    }
}
