using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Poly
    {

        public string Name;
        public string Friend;


        public virtual void Fashion()
        {
            Console.WriteLine("-------- Friends ---------");

            Console.WriteLine("My Name: "+ Name);
            Console.WriteLine("Best Friend: "+Friend);

        }
    }

    class Morph:Poly
    {
        public string Mother;
        public string Father;
        public string Brother;

        public override void Fashion()
        {


            Console.WriteLine("------- Family members ---------");

            Console.WriteLine("My Name: " + Name);
            Console.WriteLine("Mother: " + Mother);
            Console.WriteLine("Father: " + Father);
            Console.WriteLine("Brother: "+ Brother);

            base.Fashion();
        }
    }
}
