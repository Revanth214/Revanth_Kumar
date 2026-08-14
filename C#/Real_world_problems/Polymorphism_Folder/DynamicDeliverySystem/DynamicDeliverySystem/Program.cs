using System;
using System.Collections.Generic;

namespace DynamicDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Delivery> deliveries = new List<Delivery>();

            string deliveryType = "";

            while (deliveryType != "stop")
            {
                Console.Write("Enter delivery type (bike/truck/drone) or stop: ");
                deliveryType = Console.ReadLine().ToLower();

                if (deliveryType == "stop")
                {
                    break;
                }

                Console.Write("Enter delivery ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter distance in kilometers: ");
                int kilometers = Convert.ToInt32(Console.ReadLine());

                if (deliveryType == "bike")
                {
                    deliveries.Add(new BikeDelivery(id, kilometers));
                }
                else if (deliveryType == "truck")
                {
                    deliveries.Add(new TruckDelivery(id, kilometers));
                }
                else if (deliveryType == "drone")
                {
                    deliveries.Add(new DroneDelivery(id, kilometers));
                }
                else
                {
                    Console.WriteLine("Invalid delivery type.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("=========== Delivery Summary ===========");

            decimal totalDeliveryCost = 0;

            foreach (Delivery delivery in deliveries)
            {
                decimal cost = delivery.CalculateDeliveryCost();

                Console.WriteLine($"Delivery ID: {delivery.ID}");
                Console.WriteLine($"Distance: {delivery.Kilometers} km");
                Console.WriteLine($"Delivery Cost: ₹{cost}");
                Console.WriteLine("----------------------------------------");

                totalDeliveryCost += cost;
            }

            Console.WriteLine($"Total Delivery Cost: ₹{totalDeliveryCost}");

            Console.ReadLine();
        }
    }
}