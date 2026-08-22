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
        public int Port { get; set; }
        public ApplicationService(string ServiceName, int Port)
        {
            this.ServiceName = ServiceName;
            this.Port = Port;
        }
        public void start()
        {
            Console.WriteLine("Payment Processing Service started.");
        }
        public void stop()
        {
            Console.WriteLine("Payment Processing Service stopped.");
        }
        public void DisplayServiceInfo()
        {
            Console.WriteLine("Service: " + ServiceName);
            Console.WriteLine("Port: " + Port);
        }
    }
    class PaymentService:ApplicationService
    {
        public PaymentService(string service, int port) : base(service, port)
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
            PaymentService obj = new PaymentService("Payment Processing Service",8080);

            obj.start();
            obj.DisplayServiceInfo();
            obj.ProcessPayment();
            obj.stop();

            Console.ReadLine();
        }
    }
}
