using System;

namespace Employee_Management_system_2
{
    abstract class Employee
    {
        private int employeeID;
        private string employeeName;
        private string department;
        private double basicSalary;
        private int employeeExperience;

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Employee ID must be greater than 0.");
                }

                employeeID = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Employee name cannot be empty.");
                }

                employeeName = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department cannot be empty.");
                }

                department = value;
            }
        }

        public double BasicSalary
        {
            get
            {
                return basicSalary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Salary must be greater than 0.");
                }

                basicSalary = value;
            }
        }

        public int EmployeeExperience
        {
            get
            {
                return employeeExperience;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience cannot be negative.");
                }

                employeeExperience = value;
            }
        }

        public double Salary { get; protected set; }

        public Employee()
        {
        }

        public Employee(
            int id,
            string name,
            string department,
            double salary,
            int experience)
        {
            EmployeeID = id;
            EmployeeName = name;
            Department = department;
            BasicSalary = salary;
            EmployeeExperience = experience;
        }

        public void UpdateSalary(double salary)
        {
            BasicSalary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Experience: " + EmployeeExperience);
        }

        public abstract double CalculateSalary();

        public double CalculateSalary(double basicSalary)
        {
            return basicSalary;
        }
    }
}