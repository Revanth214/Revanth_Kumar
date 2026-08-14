using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingSystem
{
    class Shipping
    {
        public int TrackingNumber { get; private set; }
        public decimal Weight { get; private set; }
        public Shipping(int number, decimal weight)
        {
            TrackingNumber = number;
            Weight = weight;
        }

        public virtual decimal CalculateShippingCost()
        {
            return Weight * 50;
        }
    }

    class StandardShipment: Shipping
    {
        public StandardShipment(int number, decimal weight):base(number, weight)
        {
        }

        public override decimal CalculateShippingCost()
        {
            return Weight * 50;
            //return base.CalculateShippingCost();
            //means: "Run the base class's implementation of CalculateShippingCost()."
        }
    }

    class ExpressShipment : Shipping
    {
        public ExpressShipment(int number, decimal weight) : base(number, weight)
        {

        }
        public override decimal CalculateShippingCost()
        {
            return Weight*100+200;
        }
    }
    class InternationalShipment: Shipping
    {
        public InternationalShipment(int number, decimal weight) : base(number, weight)
        {

        }
        public override decimal CalculateShippingCost()
        {
            return Weight * 300 + 1000;
        }
    }
}
