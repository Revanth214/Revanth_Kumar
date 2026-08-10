using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Patient p = new Patient();
            p.Name = "Revanth";
            p.Age = 20;
            p.Decease = "Stomache Pain";
            Console.WriteLine($"{p.Name} is {p.Age} years older and is suffering from {p.Decease}");

            Doctor d = new Doctor();
            d.Name = "Bharath";
            d.Age = 21;
            d.Job = "Physiotherapyst";
            Console.WriteLine($"{d.Name} is {d.Age} years older and has been serving as a {p.Decease}");

            Parent inherit = new Parent();

            Base_Keyword base_class = new Base_Keyword("Rama");

            Fun_Game fun_obj = new Fun_Game();
            fun_obj.Fascinating();

            Human animal = new Human();
            animal.show();


            This_Keyword this_key = new This_Keyword("Rama");
            this_key.display();

            Student_of obj_per = new Student_of();
            obj_per.Show();

            Console.ReadLine();
        }
    }
}
