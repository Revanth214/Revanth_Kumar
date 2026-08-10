using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    class Base_Keyword
    {
        public Base_Keyword(string Name)
        {
            Console.WriteLine($"Person name: {Name}");
        }

    }

    class Fun:Base_Keyword
    {
        public Fun() : base("Shiva") // Calling the parent constructor
        {
            Console.WriteLine("That Student is having fun.");
        }
    }
}
