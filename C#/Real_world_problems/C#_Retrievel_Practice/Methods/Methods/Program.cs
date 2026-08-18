using System;

namespace Methods
{
    class Program
    {
        static decimal CalculateGrossSalary(
            decimal basicSalary,
            decimal allowance,
            decimal bonus)
        {
            return basicSalary + allowance + bonus;
        }

        static decimal CalculateAnnualSalary(decimal monthlyGrossSalary)
        {
            return monthlyGrossSalary * 12;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter employee Basic Salary: ");
            decimal basicSalary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter employee Allowance: ");
            decimal allowance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter employee Bonus: ");
            decimal bonus = Convert.ToDecimal(Console.ReadLine());

            decimal grossSalary =
                CalculateGrossSalary(basicSalary, allowance, bonus);

            decimal annualSalary =
                CalculateAnnualSalary(grossSalary);

            Console.WriteLine($"Gross Salary: {grossSalary}");
            Console.WriteLine($"Annual Salary: {annualSalary}");

            Console.ReadLine();
        }
    }
}