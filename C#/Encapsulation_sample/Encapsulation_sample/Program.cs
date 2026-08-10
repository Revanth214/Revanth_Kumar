using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            BankStatement obj = new BankStatement("Revanth Kumar", 20120007164);
            Console.WriteLine("----------Deposite-------------");
            obj.Deposite(50000);
            Console.WriteLine("My Bank Balance: "+obj.balance);

            Console.WriteLine("-------After Withdraw----------");
            obj.Withdraw(10000);
            Console.WriteLine("My Bank Balance: "+obj.balance);
            Console.ReadLine();
        }
    }
}
