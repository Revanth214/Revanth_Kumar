using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");

        }
    }

    class Car: Vehicle
    {
        public int NoOfDoors { get; set; }
        public void Drive()
        {
            Console.WriteLine("Car is being driven.");
        }
    }

    class MotorCycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public void Ride()
        {


            Console.WriteLine("Motorcycle is being ridden.");
        }
    }
}
