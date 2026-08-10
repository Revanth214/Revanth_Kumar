using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_sample
{
    class Parameterized_Constructor
    {
        public string Name;
        public string Power;

        public Parameterized_Constructor(string name, string power)
        {
            Name = name;
            Power = power;

            Console.WriteLine(Name + " " + Power);
        }

    }
}
