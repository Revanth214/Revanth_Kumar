using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    class Inherit_constructor
    {
        public Inherit_constructor()
        {
            Console.WriteLine("Parent class constructor");
        }
    }

    class Student:Inherit_constructor
    {
        public Student()
        {
            Console.WriteLine("Derived class constructor");
        }
    }
    class Parent:Student
    {
        public Parent()
        {
            Console.WriteLine("Second derived class constructor");
        }
    }

    //How compiler executes code:

    /*class Parent : Student
    {
        public Parent():base()  // Here, compiler automatically create and run base method to call parent constructor if it it's a parameterless constructor
        {                       //If the parent constructor has parameterized it won't automatically call parent constructor.
                                //So, we need to call it with manually. 
            Console.WriteLine("Second derived class constructor");
        }
    }*/


}
