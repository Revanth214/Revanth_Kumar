using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deployment_Configure
{
    class DeploymentConfig
    {
        public string Environment { get; set; }
        public int Port { get; private set; }
        public bool IsProduction { get; private set; }

        public void config(int port, bool production)
        {
            Port = port;
            IsProduction = production;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DeploymentConfig dp = new DeploymentConfig();
            dp.Environment = "Productiion";
            dp.config(8080, true);

            Console.WriteLine("Environment: " + dp.Environment);
            Console.WriteLine("Port: " + dp.Port);
            Console.WriteLine("IsProduction: " + dp.IsProduction);

            Console.ReadLine();
        }
    }
}
