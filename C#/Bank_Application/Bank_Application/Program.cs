using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount obj = new BankAccount("2120007614");

            
            obj.Deposite(100000);
            obj.Display();
            obj.WithDraw(50000);
            obj.Display();
            obj.WithDraw(0000);
            obj.Display();


            Console.ReadLine();
        }
    }
}
