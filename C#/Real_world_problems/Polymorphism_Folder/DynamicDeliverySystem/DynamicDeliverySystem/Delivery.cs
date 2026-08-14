using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDeliverySystem
{
    class Delivery
    {
        public int ID { get; private set; }
        public int Kilometers { get; private set; }

        public Delivery(int id, int kilo)
        {
            ID = id;
            Kilometers = kilo;
        }

        public virtual decimal CalculateDeliveryCost()
        {
            return Kilometers * 20;
        }
    }
    class BikeDelivery : Delivery
    {
        public BikeDelivery(int id, int kilometes) : base(id, kilometes)
        {

        }
        public override decimal CalculateDeliveryCost()
        {
            return base.CalculateDeliveryCost();
        }
    }

    class TruckDelivery : Delivery
    {
        public TruckDelivery(int id, int kilometes) : base(id, kilometes)
        {

        }
        public override decimal CalculateDeliveryCost()
        {
            return Kilometers * 50 + 500;
        }
    }

    class DroneDelivery : Delivery
    {
        public DroneDelivery(int id, int kilometes) : base(id, kilometes)
        {

        }
        public override decimal CalculateDeliveryCost()
        {
            return Kilometers * 100 + 1000;
        }
    }
}
