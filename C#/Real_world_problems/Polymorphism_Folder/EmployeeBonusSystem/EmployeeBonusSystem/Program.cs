using System;
using System.Collections.Generic;

namespace EmployeeBonusSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            string user = "yes";

            while (user == "yes")
            {
                Console.WriteLine();
                Console.Write("Enter employee type (developer/manager): ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                try
                {
                    if (type == "developer")
                    {
                        employees.Add(new Developer(name, id, salary));
                    }
                    else if (type == "manager")
                    {
                        employees.Add(new Manager(name, id, salary));
                    }
                    else
                    {
                        Console.WriteLine("Invalid employee type.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Do you want to add another employee? (yes/no): ");
                user = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.WriteLine("========== Employee Bonus Summary ==========");

            decimal totalBonus = 0;

            foreach (Employee emp in employees)
            {
                decimal bonus = emp.CalculateBonus();

                Console.WriteLine();
                Console.WriteLine($"Employee Name: {emp.Name}");
                Console.WriteLine($"Employee ID: {emp.EmployeeID}");
                Console.WriteLine($"Employee Salary: ₹{emp.Salary}");
                Console.WriteLine($"Employee Bonus: ₹{bonus}");

                totalBonus += bonus;
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Total Employees: {employees.Count}");
            Console.WriteLine($"Total Bonus Paid: ₹{totalBonus}");

            Console.ReadLine();
        }
    }
}