using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_constructor_base
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int employeeID, decimal salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(
            string name,
            int employeeID,
            decimal salary,
            string programmingLanguage)
            : base(name, employeeID, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(
            string name,
            int employeeID,
            decimal salary,
            int teamSize)
            : base(name, employeeID, salary)
        {
            TeamSize = teamSize;
        }
    }
}
