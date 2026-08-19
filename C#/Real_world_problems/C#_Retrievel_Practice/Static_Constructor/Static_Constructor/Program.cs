using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Company
    {
        static string CompanyName;
        static int EmployeeCount;

        static Company()
        {
            Console.WriteLine("Static constructor executed.");
            CompanyName = "TechCorp";
            EmployeeCount = 500;
        }

        public void DisplayCompany()
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Employee Count: " + EmployeeCount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company cm = new Company();
            cm.DisplayCompany();
            Console.ReadLine();
        }
    }
}
