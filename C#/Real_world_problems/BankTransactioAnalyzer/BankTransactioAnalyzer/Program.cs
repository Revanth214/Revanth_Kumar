using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactioAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            char transaction_type;
            int amount;
            decimal balance= 50000;
            char user = 'y';
            int depositeCount = 0;
            int withdrawCount = 0;
            int depositedAmount = 0;
            int withdrawnAmount = 0;
            int invalidTransactions = 0;


            while (user != 'x')
            {
                Console.Write("Enter transaction type : ");
                transaction_type = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter total amount: ");
                amount = Convert.ToInt32(Console.ReadLine());

                if (transaction_type == 'd' || transaction_type == 'D')
                {
                    if (amount > 0)
                    {
                        balance += amount;
                        depositeCount++;
                        depositedAmount += amount;
                        Console.WriteLine("Deposite completed");
                    }
                    else
                    {
                        Console.WriteLine("Amount must be greater than zero");
                        invalidTransactions++;
                    }
                }
                else if(transaction_type == 'w' || transaction_type == 'W')
                {
                    if (amount > 0 & amount < balance)
                    {
                        balance -= amount;
                        withdrawCount++;
                        withdrawnAmount += amount;
                        Console.WriteLine("Withdrawl completed");
                    }
                    else if (amount<0)
                    {
                        Console.WriteLine("Amount must be greater than zero and less than balance");
                        invalidTransactions++;
                    }
                    else
                    {
                        Console.WriteLine("Amount must be and less than balance");
                        invalidTransactions++;
                    }
                }

                Console.WriteLine("Do you want to make transaction again (y/x): ");
                user = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("===========Transaction History===============");

            Console.WriteLine("Final balance: " + balance);
            Console.WriteLine("No of successful deposites: " + depositeCount);
            Console.WriteLine("No of successful withdrawas: " + withdrawCount);
            Console.WriteLine("Total amount deposited: " + depositedAmount);
            Console.WriteLine("Total amount withdrawn: " + withdrawnAmount);
            Console.WriteLine("No of invalid transactions: " + invalidTransactions);

            Console.ReadLine();
        }
    }
}
