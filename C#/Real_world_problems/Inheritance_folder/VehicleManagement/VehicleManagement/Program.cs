using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Car Details=============");

            Car cr = new Car();
            cr.Model = "BMW M5";
            cr.Brand = "BMW";
            cr.Year =2025;
            cr.NoOfDoors = 4;
            Console.WriteLine($"No of Doors: {cr.NoOfDoors}");
            cr.DisplayVehicleInfo();
            cr.Drive();

            Console.WriteLine("======Motor Cycle Details==========");
            MotorCycle mc = new MotorCycle();
            mc.Model = "NS 200";
            mc.Brand = "Pulser";
            mc.Year = 2025;
            mc.DisplayVehicleInfo();
            mc.HasSidecar = true;
            Console.WriteLine($"Has Side Car: {mc.HasSidecar}");
            mc.Ride();
            Console.ReadLine();
        }
    }
}
