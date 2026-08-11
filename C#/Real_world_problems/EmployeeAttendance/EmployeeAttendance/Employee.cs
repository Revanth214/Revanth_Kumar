using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance
{
    class Employee
    {

        public int No_of_Employees;
        public Employee(int emp_count)
        {
            No_of_Employees = emp_count;
        }

        public int e_count;

        public string Name;
        public int present_days;
        public int working_days;

        public void Employee_details()
        {

            for (int i = 0; i < e_count; i++)
            {
                Details();
                Attendance_per();
                clasiffy();
                display();
            }
        }
        public void Details()
        {
            Console.WriteLine("Enter employee name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee present days count: ");
            present_days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter company Total working days: ");
            working_days = Convert.ToInt32(Console.ReadLine());
        }
        public int attendance_percentage;

        public void Attendance_per()
        {
            attendance_percentage = (present_days / working_days) * 100;
        }
        public int Excellentcategory=0;
        public int Goodcategory=0;
        public int Averagecategory=0;
        public int Poorcategory=0;
        public void clasiffy()
        {
            if (attendance_percentage >= 90)
            {
                Excellentcategory += 1;
            }
            else if (attendance_percentage >= 75 && attendance_percentage <= 89)
            {
                Goodcategory += 1;
            }
            else if (attendance_percentage >= 60 && attendance_percentage <= 74)
            {
                Averagecategory += 1;
            }
            else
            {
                Poorcategory += 1;
            }
        }
        public void display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Per: " + attendance_percentage);
            Console.WriteLine("Excellent_Category: " + Excellentcategory);
            Console.WriteLine("Good_Category: " + Goodcategory);
            Console.WriteLine("Average_Category: " + Averagecategory);
            Console.WriteLine("Poor_Category: " + Poorcategory);
        }


    }
}
