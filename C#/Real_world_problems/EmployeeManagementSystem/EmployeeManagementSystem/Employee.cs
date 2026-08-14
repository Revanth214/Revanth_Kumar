using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        public string Name;
        public int EmployeeID;
        public decimal salary;

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    class Developer:Employee
    {
       public string ProgrammingLanguage;

        public void WriteCode()
        {
            Console.WriteLine($"Developer wrote code in {ProgrammingLanguage} programming langauge.");
        }
    }

    class Manager : Employee
    {
        public int TeamSize;
        public void ConductMeeting()
        {
            Console.WriteLine("Team Size: " + TeamSize);
        }
    }
}
