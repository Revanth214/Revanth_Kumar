using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_sample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Doctor:Person
    {
        public string Job { get; set; }
    }

    public class Patient:Person
    {
        public string Decease { get; set; }
    }


    public class Teacher:Person
    {
        public string  Subject { get; set;}
}


}
