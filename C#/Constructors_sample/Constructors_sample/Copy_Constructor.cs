using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_sample
{
    class Copy_Constructor
    {
        public string Name;
        public int Age;
        public Copy_Constructor(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine(Name + " is " + Age + " years old.");
        }

        public Copy_Constructor(Copy_Constructor other)
        {
            Console.WriteLine($"{other.Name} is {other.Age} years old.....");
        }

    }
}
