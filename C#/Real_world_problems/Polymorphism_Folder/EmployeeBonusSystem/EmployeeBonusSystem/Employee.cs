using System;

namespace EmployeeBonusSystem
{
    abstract class Employee
    {
        public string Name { get; private set; }
        public int EmployeeID { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, int id, decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }

            Name = name;
            EmployeeID = id;
            Salary = salary;
        }

        public abstract decimal CalculateBonus();
    }

    class Developer : Employee
    {
        public Developer(string name, int id, decimal salary)
            : base(name, id, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * 10 / 100;
        }
    }

    class Manager : Employee
    {
        public Manager(string name, int id, decimal salary)
            : base(name, id, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * 20 / 100;
        }
    }
}