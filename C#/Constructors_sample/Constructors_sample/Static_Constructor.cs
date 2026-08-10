using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_sample
{
    class Static_Constructor
    {

        public string Name;
        public string Power;
        public Static_Constructor()
        {

            Name = "Monkey D. Luffy.";
            Power = "Nika: The Sun God";
            Console.WriteLine(Name + "  " + Power);
        }

        static Static_Constructor() // This executes first even before 'public Staic_Constructor()' even if we write it before static, still static executes.
                                    // This happens always it doesn't care how many methods, constructors are there still static executes first.
        {
            Console.WriteLine("A static constructor called only once by the CLR before the class is used for the first time.");
        }
    }
}
