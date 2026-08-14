using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Delivery> deliveries = new List<Delivery>();
            /*List<T> is a collection that can store multiple objects of a specified type.

            Here:- List<Delivery> means: "Create a list that can hold Delivery objects."
            */
            deliveries.Add(new BikeDelivery(12, 5));
            deliveries.Add(new TruckDelivery(13, 10));
            deliveries.Add(new DroneDelivery(14, 8));
            /*becomes:

            deliveries
            ┌───────────────────────────┐
            │ 0 → BikeDelivery          │
            │ 1 → TruckDelivery         │
            │ 2 → DroneDelivery         │
            └───────────────────────────┘

            So Add() simply means: Put this object into the collection.
            */


            //For each Delivery object in deliveries, temporarily call that object delivery.
            foreach (Delivery delivery in deliveries)
            {
                Console.WriteLine(delivery.CalculateDeliveryCost());
            }

            Console.ReadLine();
        }
    }
}
