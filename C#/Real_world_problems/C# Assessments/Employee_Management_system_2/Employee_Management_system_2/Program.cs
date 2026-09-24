using System;

namespace Employee_Management_system_2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement management =
                new EmployeeManagement();

            int choice;

            do
            {
                Console.Clear();

                Console.WriteLine(
                    "========================================");

                Console.WriteLine(
                    "       EMPLOYEE MANAGEMENT SYSTEM");

                Console.WriteLine(
                    "========================================");

                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Search Employee");
                Console.WriteLine("4. Calculate Salary");
                Console.WriteLine("5. Calculate Bonus");
                Console.WriteLine("6. Update Salary");
                Console.WriteLine("7. Display Highest Paid Employee");
                Console.WriteLine("8. Exit");

                Console.WriteLine(
                    "========================================");

                Console.Write("Enter your choice: ");
                choice =
                    Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        management.AddEmployee();
                        break;

                    case 2:
                        management.DisplayEmployees();
                        break;

                    case 3:
                        management.SearchEmployee();
                        break;

                    case 4:
                        management.CalculateSalaries();
                        break;

                    case 5:
                        management.CalculateBonuses();
                        break;

                    case 6:
                        management.UpdateEmployeeSalary();
                        break;

                    case 7:
                        management.DisplayHighestPaidEmployee();
                        break;

                    case 8:
                        Console.WriteLine(
                            "Exiting Employee Management System...");
                        break;

                    default:
                        Console.WriteLine(
                            "Invalid choice.");
                        break;
                }

                if (choice != 8)
                {
                    Console.WriteLine(
                        "\nPress ENTER to continue...");

                    Console.ReadLine();
                }

            } while (choice != 8);
        }
    }
}