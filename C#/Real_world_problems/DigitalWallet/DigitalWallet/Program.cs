using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalWallet.Money();// static method can take parameters.
            // public static Money() method executes before object creating. This is the first method executes in the program
            DigitalWallet dw = new DigitalWallet(0);

            Console.WriteLine("Do you want to make transaction (y/n): ");
            char user = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(dw.IsEmpty); // we have to use Console.WriteLine to call IsEmpty because it's a get property.
            while (user == 'y')
            {
                Console.WriteLine("Transaction Type (d/w):");
                char Transaction = Convert.ToChar(Console.ReadLine());
                if (Transaction == 'd' || Transaction == 'D')
                {
                    Console.WriteLine("Enter your deposite amount: ");
                    decimal depositeAmount = Convert.ToDecimal(Console.ReadLine());
                    dw.Deposite(depositeAmount);
                }
                else if (Transaction == 'w' || Transaction == 'W')
                {
                    Console.WriteLine("Enter your withdrawl amount: ");
                    decimal withdrawlAmount = Convert.ToDecimal(Console.ReadLine());
                    dw.Withdrawl(withdrawlAmount);
                }

                Console.WriteLine("Do you wanna make transaction again (y/n):");
                user = Convert.ToChar(Console.ReadLine());
            }
            dw.Display();
            Console.ReadLine();
        }
    }
}
