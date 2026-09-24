using System;
using System.Collections.Generic;

namespace Employee_Management_system_2
{
    class EmployeeManagement
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeManagement()
        {
            Employee employee = new Manager(12,"Rama","IT",200000,4,10);

            employees.Add(employee);
        }

        public void AddEmployee()
        {
            Console.WriteLine("\n========== ADD EMPLOYEE ==========");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Developer");

            Console.Write("Select Employee Type: ");
            int employeeType =
                Convert.ToInt32(Console.ReadLine());

            if (employeeType == 1)
            {
                AddManager();
            }
            else if (employeeType == 2)
            {
                AddDeveloper();
            }
            else
            {
                Console.WriteLine("Invalid Employee Type.");
            }
        }

        private void AddManager()
        {
            Console.WriteLine("\n========== MANAGER DETAILS ==========");

            int id;

            do
            {
                Console.Write("Enter Employee ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (id <= 0)
                {
                    Console.WriteLine(
                        "Employee ID must be greater than 0.");
                }

            } while (id <= 0);

            string name;

            do
            {
                Console.Write("Enter Employee Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine(
                        "Employee name cannot be empty.");
                }

            } while (string.IsNullOrWhiteSpace(name));

            string department;

            do
            {
                Console.Write("Enter Department: ");
                department = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(department))
                {
                    Console.WriteLine(
                        "Department cannot be empty.");
                }

            } while (string.IsNullOrWhiteSpace(department));

            double salary;

            do
            {
                Console.Write("Enter Basic Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());

                if (salary <= 0)
                {
                    Console.WriteLine(
                        "Salary must be greater than 0.");
                }

            } while (salary <= 0);

            int experience;

            do
            {
                Console.Write("Enter Experience: ");
                experience =
                    Convert.ToInt32(Console.ReadLine());

                if (experience < 0)
                {
                    Console.WriteLine(
                        "Experience cannot be negative.");
                }

            } while (experience < 0);

            int teamSize;

            do
            {
                Console.Write("Enter Team Size: ");
                teamSize =
                    Convert.ToInt32(Console.ReadLine());

                if (teamSize < 0)
                {
                    Console.WriteLine(
                        "Team Size cannot be negative.");
                }

            } while (teamSize < 0);

            Manager manager = new Manager(
                id,
                name,
                department,
                salary,
                experience,
                teamSize);

            employees.Add(manager);

            Console.WriteLine(
                "\nManager added successfully.");
        }

        private void AddDeveloper()
        {
            Console.WriteLine("\n========== DEVELOPER DETAILS ==========");

            int id;

            do
            {
                Console.Write("Enter Employee ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (id <= 0)
                {
                    Console.WriteLine(
                        "Employee ID must be greater than 0.");
                }

            } while (id <= 0);

            string name;

            do
            {
                Console.Write("Enter Employee Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine(
                        "Employee name cannot be empty.");
                }

            } while (string.IsNullOrWhiteSpace(name));

            string department;

            do
            {
                Console.Write("Enter Department: ");
                department = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(department))
                {
                    Console.WriteLine(
                        "Department cannot be empty.");
                }

            } while (string.IsNullOrWhiteSpace(department));

            double salary;

            do
            {
                Console.Write("Enter Basic Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());

                if (salary <= 0)
                {
                    Console.WriteLine(
                        "Salary must be greater than 0.");
                }

            } while (salary <= 0);

            int experience;

            do
            {
                Console.Write("Enter Experience: ");
                experience =
                    Convert.ToInt32(Console.ReadLine());

                if (experience < 0)
                {
                    Console.WriteLine(
                        "Experience cannot be negative.");
                }

            } while (experience < 0);

            string programmingLanguage;

            do
            {
                Console.Write(
                    "Enter Programming Language: ");

                programmingLanguage =
                    Console.ReadLine();

                if (string.IsNullOrWhiteSpace(
                    programmingLanguage))
                {
                    Console.WriteLine(
                        "Programming Language cannot be empty.");
                }

            } while (string.IsNullOrWhiteSpace(
                programmingLanguage));

            Developer developer = new Developer(
                id,
                name,
                department,
                salary,
                experience,
                programmingLanguage);

            employees.Add(developer);

            Console.WriteLine(
                "\nDeveloper added successfully.");
        }

        public void DisplayEmployees()
        {
            Console.WriteLine(
                "\n========== ALL EMPLOYEES ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(
                    "\n------------------------------");

                employee.DisplayEmployeeDetails();

                if (employee is Manager manager)
                {
                    Console.WriteLine(
                        "Employee Type: Manager");

                    Console.WriteLine(
                        "Team Size: " +
                        manager.TeamSize);
                }
                else if (employee is Developer developer)
                {
                    Console.WriteLine(
                        "Employee Type: Developer");

                    Console.WriteLine(
                        "Programming Language: " +
                        developer.ProgrammingLanguage);
                }
            }
        }

        public void SearchEmployee()
        {
            Console.WriteLine(
                "\n========== SEARCH EMPLOYEE ==========");

            Console.Write("Enter Employee ID: ");
            int id =
                Convert.ToInt32(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID == id)
                {
                    Console.WriteLine(
                        "\nEmployee Found");

                    employee.DisplayEmployeeDetails();

                    return;
                }
            }

            Console.WriteLine(
                "\nEmployee Not Found.");
        }

        public void CalculateSalaries()
        {
            Console.WriteLine(
                "\n========== SALARY CALCULATION ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            foreach (Employee employee in employees)
            {
                double salary =
                    employee.CalculateSalary();

                Console.WriteLine(
                    employee.EmployeeName +
                    " -> Final Salary: " +
                    salary);
            }
        }

        public void CalculateBonuses()
        {
            Console.WriteLine(
                "\n========== BONUS CALCULATION ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            foreach (Employee employee in employees)
            {
                IEmployeeOperations operations =
                    employee as IEmployeeOperations;

                if (operations != null)
                {
                    double bonus =
                        operations.CalculateBonus();

                    Console.WriteLine(
                        employee.EmployeeName +
                        " -> Bonus: " +
                        bonus);
                }
            }
        }

        public void UpdateEmployeeSalary()
        {
            Console.WriteLine(
                "\n========== UPDATE SALARY ==========");

            Console.Write("Enter Employee ID: ");
            int id =
                Convert.ToInt32(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID == id)
                {
                    double salary;

                    do
                    {
                        Console.Write(
                            "Enter New Basic Salary: ");

                        salary =
                            Convert.ToDouble(
                                Console.ReadLine());

                        if (salary <= 0)
                        {
                            Console.WriteLine(
                                "Salary must be greater than 0.");
                        }

                    } while (salary <= 0);

                    employee.UpdateSalary(salary);

                    Console.WriteLine(
                        "\nSalary updated successfully.");

                    return;
                }
            }

            Console.WriteLine(
                "\nEmployee Not Found.");
        }

        public void DisplayHighestPaidEmployee()
        {
            Console.WriteLine(
                "\n========== HIGHEST PAID EMPLOYEE ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            Employee highestPaid =
                employees[0];

            foreach (Employee employee in employees)
            {
                if (employee.BasicSalary >
                    highestPaid.BasicSalary)
                {
                    highestPaid = employee;
                }
            }

            highestPaid.DisplayEmployeeDetails();
        }

        public void DisplayLowestPaidEmployee()
        {
            Console.WriteLine(
                "\n========== LOWEST PAID EMPLOYEE ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            Employee lowestPaid =
                employees[0];

            foreach (Employee employee in employees)
            {
                if (employee.BasicSalary <
                    lowestPaid.BasicSalary)
                {
                    lowestPaid = employee;
                }
            }

            lowestPaid.DisplayEmployeeDetails();
        }

        public void DisplayAverageSalary()
        {
            Console.WriteLine(
                "\n========== AVERAGE SALARY ==========");

            if (employees.Count == 0)
            {
                Console.WriteLine(
                    "No employees available.");

                return;
            }

            double totalSalary = 0;

            foreach (Employee employee in employees)
            {
                totalSalary += employee.BasicSalary;
            }

            double averageSalary =
                totalSalary / employees.Count;

            Console.WriteLine(
                "Average Salary: " +
                averageSalary);
        }

        public void DisplayEmployeesAbove50000()
        {
            Console.WriteLine(
                "\n========== SALARY ABOVE 50000 ==========");

            bool found = false;

            foreach (Employee employee in employees)
            {
                if (employee.BasicSalary > 50000)
                {
                    Console.WriteLine(
                        employee.EmployeeName +
                        " -> " +
                        employee.BasicSalary);

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(
                    "No employee has salary above 50000.");
            }
        }

        public void CountITEmployees()
        {
            Console.WriteLine(
                "\n========== IT EMPLOYEE COUNT ==========");

            int count = 0;

            foreach (Employee employee in employees)
            {
                if (employee.Department.Equals(
                    "IT",
                    StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine(
                "Number of IT Employees: " +
                count);
        }

        public void GenerateEmployeeReports()
        {
            Console.WriteLine(
                "\n========== EMPLOYEE REPORTS ==========");

            foreach (Employee employee in employees)
            {
                IEmployeeOperations operations =
                    employee as IEmployeeOperations;

                if (operations != null)
                {
                    operations.GenerateEmployeeReport();
                }
            }
        }
    }
}