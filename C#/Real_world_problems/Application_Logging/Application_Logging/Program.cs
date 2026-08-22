using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Logging
{
    class Application
    {
        public virtual void Log(string message)
        {
            Console.WriteLine("[APPLICATION]: "+ message);
        } 
    }
    class API:Application
    {
        public override void Log(string message)
        {
            Console.WriteLine($"[API]: " + message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            API api = new API();
            api.Log("User requested /api/orders");
            Application app = new API();
            app.Log("User requested /api/orders");

            Console.ReadLine();
        }
    }
}
