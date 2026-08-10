using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Over_Loading
    {
        public void Fun(string Name, string Skill)
        {
            Console.WriteLine( $"{Name}: {Skill}");
        }
        public void Fun(int num1, int num2)
        {
            Console.WriteLine($"Addition of {num1} and {num2} is: {num1+num2}") ;
        }
    }
}
