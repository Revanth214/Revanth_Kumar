using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Instance_vs_Static obj = new Instance_vs_Static();
            obj.Name = "Rama";
            obj.Age = 20;
            obj.display();


            Static_example se = new Static_example();
            Static_example.Name = "Krishan";
            Static_example.Age = 20;
            Static_example.show();

            Employee ep = new Employee();
            Employee ep2 = new Employee();          
            ep.Name = "Gangadhar";
            ep2.Name = "Revanth";
            Employee.CompanyEmoloyeeCount = 1;
            ep.ShowName();
            ep2.ShowName();
            Employee.ShowCount();




            Console.ReadLine();
        }
    }
}
