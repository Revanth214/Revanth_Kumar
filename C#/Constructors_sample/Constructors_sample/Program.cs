using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_sample
{
    class Program
    {

        private Program() // 'Private' Constructor.
                          // I wrote here, because it doesn't being called from another class or outside the class. It has to be same class.
        {
            Console.WriteLine("Private class prevents objects of the class from being created from outside the class");
        }
        static void Main(string[] args)
        {

            Parameterless_Constructor obj = new Parameterless_Constructor();
            

            Parameterized_Constructor obj2 = new Parameterized_Constructor("Roronoa zoro.", "Three Sword Style");

            Copy_Constructor obj3 = new Copy_Constructor("Sanji", 20);
            Copy_Constructor obj4 = new Copy_Constructor(obj3);

            Static_Constructor obj5 = new Static_Constructor();



            //'Private' Constructor: 
            Program obj6 = new Program();

            Console.ReadLine();
        }
    }
}
