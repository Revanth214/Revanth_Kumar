using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Review
{
    class Manager : Employee
    {
        public Manager(int id, string name, string email, decimal salary)
            : base(id, name, email, salary)
        {
            Console.WriteLine("========Manager Details=========");
        }
        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is a manager and he manages the team");
        }
    }
}
