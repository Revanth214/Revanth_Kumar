using System;

namespace Employee_Management_system_2
{
    class Developer : Employee, IEmployeeOperations
    {
        public string ProgrammingLanguage { get; set; }

        public double TechnicalAllowance { get; private set; }

        public Developer()
        {
        }

        public Developer(
            int id,
            string name,
            string department,
            double salary,
            int experience,
            string programmingLanguage)
            : base(id, name, department, salary, experience)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override double CalculateSalary()
        {
            TechnicalAllowance = 0;

            if (!string.IsNullOrWhiteSpace(ProgrammingLanguage) &&
                ProgrammingLanguage.Equals(
                    "C#",
                    StringComparison.OrdinalIgnoreCase))
            {
                TechnicalAllowance = 15000;
            }

            Salary = BasicSalary + TechnicalAllowance;

            return Salary;
        }

        public double CalculateSalary(
            double basicSalary,
            double allowance,
            double bonus)
        {
            return basicSalary + allowance + bonus;
        }

        public double CalculateBonus()
        {
            if (EmployeeExperience > 5)
            {
                return 10000;
            }

            return 0;
        }

        public void GenerateEmployeeReport()
        {
            Console.WriteLine("\n========== DEVELOPER REPORT ==========");

            DisplayEmployeeDetails();

            Console.WriteLine(
                "Programming Language: " +
                ProgrammingLanguage);

            CalculateSalary();

            Console.WriteLine(
                "Technical Allowance: " +
                TechnicalAllowance);

            Console.WriteLine(
                "Final Salary: " +
                Salary);

            Console.WriteLine(
                "Bonus: " +
                CalculateBonus());
        }
    }
}