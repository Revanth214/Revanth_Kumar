using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Sample
{
    class Polymorphism
    {
        public string Name="Revanth Kuamr";
        public int Age = 20;
        public string Company = "Mouser";

        public virtual void Emp_details()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Company: {Company}");

        }
    }
    class FreeLancer: Polymorphism
    {
        public int date = 2030;
        public override void Emp_details()
        {

            
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Ending year:{date}");
            Console.WriteLine("----------------Accessing Base class method ---------------");
            base.Emp_details();

        }
    }

}
