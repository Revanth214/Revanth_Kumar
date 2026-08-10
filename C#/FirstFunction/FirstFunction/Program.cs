using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFunction
{
    class Program
    {
        public void Get_Name()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine(); 
            Console.WriteLine("Your Name: "+name);
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Get_Name();

            Customer a = new Customer();
            a.Greet();

            Employee e = new Employee();
            e.Emp();

            Console.ReadLine();
        }
        
    }
}
