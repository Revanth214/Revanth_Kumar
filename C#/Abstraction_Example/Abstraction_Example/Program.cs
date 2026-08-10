using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            Cars_Company obj = new Elextric_Car();
            obj.Brand = "BMW";
            obj.Model = "BMW G20";
            obj.start();
            obj.stop();
            obj.speed();

            Cars_Company chargo_obj = new Charge_Cars();
            chargo_obj.Brand = "Zeep";
            chargo_obj.Model = "Zeep 120";
            chargo_obj.start();
            chargo_obj.stop();
            chargo_obj.speed();

            Console.ReadLine();

        }
    }
}
