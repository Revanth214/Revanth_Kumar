using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Example
{
    abstract class Cars_Company
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public void start()
        {
            Console.WriteLine($"{Brand} is started");
        }
        public void stop()
        {
            Console.WriteLine($"{Brand} has stopped");
        }
        public abstract void speed();
    }
    
    interface IChargable
    {
        void Charge();
    }

    interface IChagoCar
    {
        void Chargo();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Elextric_Car:Cars_Company, IChargable
    {
        public override void speed()
        {
            Console.WriteLine("Electric car can go up to 200Km/Hr");
        }

        public void Charge()
        {
            Console.WriteLine("Electric cars are chargable");
        }
    }

    class Charge_Cars : Cars_Company, IChagoCar
    {
        public override void speed()
        {
            Console.WriteLine("Chargo Cars can't go beyond 80 Km/Hr");
        }

        public void Chargo()
        {
            Console.WriteLine("Cargo cars designed to carry Large Chargo things");
        }
    }

    class Drones: IChargable, IChagoCar
    {
        public void Charge()
        {
            Console.WriteLine("Drones are Chargable");
        }
        public void Chargo()
        {
            Console.WriteLine("Drones can carry lagauge too");
        }
    }
}
