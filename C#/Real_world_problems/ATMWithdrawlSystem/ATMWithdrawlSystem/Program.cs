using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWithdrawlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your balance: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            ATM atm = new ATM(amt);
            atm.CurrentBalance();
            Console.WriteLine("Do you want to withdrawl amount: (y/n)");
            char again = Convert.ToChar(Console.ReadLine());
            do
            {
                Console.WriteLine("How much do you want to withdrawl");

                atm.EnterAmount(Convert.ToInt32(Console.ReadLine()));

                atm.Withdrawl();
                atm.Display();
                Console.WriteLine("Do you want to withdrawl again (y/n): ");
                again = Convert.ToChar(Console.ReadLine());
            }
            while (again == 'y');
            Console.ReadLine();
        }
    }
}
