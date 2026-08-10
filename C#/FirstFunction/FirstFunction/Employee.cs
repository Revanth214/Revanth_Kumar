using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFunction
{
    class Employee
    {
        public void Emp()
        {
            Console.WriteLine("Enter employee ID: ");
            int emp_id= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee Name: ");
            string emp_name=Console.ReadLine();
            Console.WriteLine("Employee ID: "+ emp_id + " Employee Name: "+ emp_name);
        }
    }
}
