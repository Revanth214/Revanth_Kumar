using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Employee
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, string employeeid, decimal salary)
        {
            Name = name;
            EmployeeID = employeeid;
            BaseSalary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"EmployeeId: {EmployeeID}");
            Console.WriteLine($"Base Salary: {BaseSalary}");
        }
    }

    class Developer: Employee
    {
        public string ProgrammingLangauge { get; set; }
        public Developer(string name, string employeeid, decimal salary, string programmingLangauge) : base(name, employeeid, salary)
        {
            ProgrammingLangauge = programmingLangauge;
        }
        public void WriteCode()
        {
            Console.WriteLine($"Developer writes code using {ProgrammingLangauge} langauge");
        }

    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, string id, decimal sal, int teamsize): base(name, id, sal)
        {
            TeamSize = teamsize;
        }
        public void ConductMeeting()
        {
            Console.WriteLine("Manager manages teams");
        }
    }
}

/*
 new Developer("Revanth", 101, 100000, "C#")
                ↓
       Developer constructor
                ↓
base("Revanth", 101, 100000)
                ↓
       Employee constructor
                ↓
Name / ID / Salary initialized
                ↓
Developer constructor continues
                ↓
ProgrammingLanguage initialized
 */
