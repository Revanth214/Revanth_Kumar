using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int employeeCount = Convert.ToInt32(Console.ReadLine());

            int excellentCategory = 0;
            int goodCategory = 0;
            int averageCategory = 0;
            int poorCategory = 0;

            double highestAttendance = 0;
            string highestAttendanceEmployee = "";

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"\n--- Employee {i + 1} ---");

                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter total working days: ");
                int workingDays = Convert.ToInt32(Console.ReadLine());

                while (workingDays <= 0)
                {
                    Console.WriteLine("Working days must be greater than 0.");
                    Console.Write("Enter total working days again: ");
                    workingDays = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter days present: ");
                int presentDays = Convert.ToInt32(Console.ReadLine());

                while (presentDays < 0 || presentDays > workingDays)
                {
                    Console.WriteLine(
                        "Present days cannot be negative or greater than working days."
                    );

                    Console.Write("Enter days present again: ");
                    presentDays = Convert.ToInt32(Console.ReadLine());
                }

                double attendancePercentage =
                    ((double)presentDays / workingDays) * 100;

                Console.WriteLine($"Attendance: {attendancePercentage:F2}%");

                // Classification
                if (attendancePercentage >= 90)
                {
                    excellentCategory++;
                }
                else if (attendancePercentage >= 75)
                {
                    goodCategory++;
                }
                else if (attendancePercentage >= 60)
                {
                    averageCategory++;
                }
                else
                {
                    poorCategory++;
                }

                // Highest attendance tracking
                if (attendancePercentage > highestAttendance)
                {
                    highestAttendance = attendancePercentage;
                    highestAttendanceEmployee = name;
                }
            }

            // Final summary
            Console.WriteLine("\n===== ATTENDANCE SUMMARY =====");

            Console.WriteLine(
                $"Excellent: {excellentCategory}"
            );

            Console.WriteLine(
                $"Good: {goodCategory}"
            );

            Console.WriteLine(
                $"Average: {averageCategory}"
            );

            Console.WriteLine(
                $"Poor: {poorCategory}"
            );

            Console.WriteLine(
                $"Highest Attendance: {highestAttendance:F2}%"
            );

            Console.WriteLine(
                $"Employee: {highestAttendanceEmployee}"
            );

            Console.ReadLine();
        }
    }
}
