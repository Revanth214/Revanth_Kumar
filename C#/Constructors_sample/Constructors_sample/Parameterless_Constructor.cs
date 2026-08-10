using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_sample
{
    class Parameterless_Constructor
    {

        // Parameterless constructor

        public string Name;
        public string Power;
        public Parameterless_Constructor()
        {

            Name = "Monkey D. Luffy.";
            Power = "Nika: The Sun God";
            Console.WriteLine(Name +"  "+ Power);
        }
    }
}
