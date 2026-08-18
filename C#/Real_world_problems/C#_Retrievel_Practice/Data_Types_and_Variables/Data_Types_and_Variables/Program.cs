using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
            decimal Salary =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Is employee still working : ");
            string Is_Curr_Working = Console.ReadLine();
            Console.WriteLine("Enter Employee Initial: ");
            string First_initial = Console.ReadLine();

            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("Employee Is still working: " + Is_Curr_Working);
            Console.WriteLine("Employee first intial: " + First_initial);

            Console.ReadLine();


        }
    }
}
