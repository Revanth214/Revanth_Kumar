using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    class This_Keyword
    {
        public string Name;
        public This_Keyword(string Name)
        {
            this.Name = Name;
        }
        public void display()
        {
            Console.WriteLine(Name);
        }

    }


    class Person_this
    {
        public string Name = "Parent";
    }

    class Student_of : Person_this
    {
        public string Name = "Child";

        public void Show()
        {
            Console.WriteLine(this.Name);

            Console.WriteLine(base.Name);
        }
    }
}
