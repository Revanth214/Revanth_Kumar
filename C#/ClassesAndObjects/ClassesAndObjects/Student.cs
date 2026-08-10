using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Student
    {
        public string Name;
        public void Study()
        {
            Console.WriteLine("==========Studying===============");
        }


        //Uisng Name

        public void Learn()
        {
            Console.WriteLine($"{Name} is studying");
        }

    }
}
