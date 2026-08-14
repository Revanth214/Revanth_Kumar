using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipping shipment;
            shipment = new StandardShipment(12, 500);
            Console.WriteLine("Standard Shipping Cost: "+shipment.CalculateShippingCost());
            shipment = new ExpressShipment(12, 500);
            Console.WriteLine("Express Shipping Cost: " + shipment.CalculateShippingCost());
            shipment = new InternationalShipment(12, 500);
            Console.WriteLine("International Shipping Cost: " + shipment.CalculateShippingCost());

            Console.ReadLine();
        }
    }
}
