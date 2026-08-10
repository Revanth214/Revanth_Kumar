using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)         //static methid: we don't need 'obj' to run a static method
        {
            Student obj = new Student();
            obj.Study();

            obj.Name = "Zoro";
            obj.Learn();


            Console.ReadLine();
        }
    }
}
