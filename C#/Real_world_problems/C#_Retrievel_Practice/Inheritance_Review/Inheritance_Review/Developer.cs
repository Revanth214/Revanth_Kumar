using System;

namespace Inheritance_Review
{
    class Developer : Employee
    {
        public Developer(int id, string name, string email, decimal salary) 
            : base(id, name, email, salary)
        {
            Console.WriteLine("========Developer Details=========");
        }
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is a developer");
        }
    }
}
