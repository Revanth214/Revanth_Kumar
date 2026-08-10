using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    class Base_method
    {
        public void Having_Fun()
        {
            Console.WriteLine("I am having fun right now");
        }

    }

    class Fun_Game: Base_method
    {
        public void Fascinating()
        {
            base.Having_Fun(); // we can call Having_Fun(); too, but the methods name should be different from both classes.
            Console.WriteLine("I am fascinating about combining programming and physics to create such an immersive game");

        }
    }


    class Animal
    {
        public string Name = "Revanth Kuamr";
    }

    class Human:Animal
    {
        public void show()
        {
            Console.WriteLine("My name is: "+base.Name);
        }
    }
}
