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
            decimal Salary =Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Is employee still working : ");
            bool Is_Curr_Working = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Employee Initial: ");
            char First_initial =Convert.ToChar( Console.ReadLine());

            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("Employee Is still working: " + Is_Curr_Working);
            Console.WriteLine("Employee first intial: " + First_initial);

            Console.ReadLine();


        }
    }
}
