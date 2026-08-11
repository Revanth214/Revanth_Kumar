using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Employee
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            if (salary<0)
            {
                throw new ArgumentException("salary can't be nagative");
            }

            this.Name = name;
            Salary = salary;
        }

        public void GiveRaise(decimal amount)
        {
            if (amount>0)
            {
                Salary += amount;
            }
            else
            {
                Console.WriteLine("Salary shouldn't be nagative");
            }
        }


        public void display()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Salary: "+Salary);
        }

    }
}
