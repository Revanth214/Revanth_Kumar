using System;

namespace Employee_Management_system_2
{
    class Manager : Employee, IEmployeeOperations
    {
        public int TeamSize { get; set; }

        public double ManagerAllowance { get; private set; }

        public Manager()
        {
        }

        public Manager(
            int id,
            string name,
            string department,
            double salary,
            int experience,
            int teamSize)
            : base(id, name, department, salary, experience)
        {
            TeamSize = teamSize;
        }

        public override double CalculateSalary()
        {
            ManagerAllowance = 0;

            if (TeamSize > 10)
            {
                ManagerAllowance = 20000;
            }

            Salary = BasicSalary + ManagerAllowance;

            return Salary;
        }

        public double CalculateSalary(
            double basicSalary,
            double allowance)
        {
            return basicSalary + allowance;
        }

        public double CalculateBonus()
        {
            if (EmployeeExperience > 5)
            {
                return 30000;
            }

            return 0;
        }

        public void GenerateEmployeeReport()
        {
            Console.WriteLine("\n========== MANAGER REPORT ==========");

            DisplayEmployeeDetails();

            Console.WriteLine("Team Size: " + TeamSize);

            CalculateSalary();

            Console.WriteLine("Manager Allowance: " + ManagerAllowance);
            Console.WriteLine("Final Salary: " + Salary);
            Console.WriteLine("Bonus: " + CalculateBonus());
        }
    }
}