using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_sample
{
    interface IPayments
    {
        void Pay(decimal amount);
    }

    class PhonePay:IPayments
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid using PhonePay");
        }
    }

    class GooglePay:IPayments
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid using GooglePay");
        }
    }

    class AmazonPay:IPayments
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid using AmazonPay");

        }
    }

}
