using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Services
{
    class ApplicationService
    {
        public string ServiceName { get; private set; }
        public ApplicationService(string service)
        {
            ServiceName = service;
        }
        public void start()
        {
            Console.WriteLine("Payment Processing Service started.");
        }
        public void stop()
        {
            Console.WriteLine("Payment Processing Service stopped.");
        }
        public void DisplayServiceIfo()
        {
            Console.WriteLine("Service: Payment Processing Service.");
        }
    }
    class PaymentService:ApplicationService
    {
        public PaymentService(string service) : base(service)
        {

        }
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PaymentService obj = new PaymentService("Payment Processing Service");

            obj.start();
            obj.DisplayServiceIfo();
            obj.ProcessPayment();
            obj.stop();

            Console.ReadLine();
        }
    }
}
