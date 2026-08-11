using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWithdrawlSystem
{
    class ATM
    {
        public decimal balance;
        public ATM(decimal balance)
        {
            this.balance = balance;
        }

        public decimal Withdrawl_Amount;
        public void EnterAmount(decimal amount)
        {
            if (amount<=0)
            {
                Console.WriteLine("Enter valid amount");

            }
            else
            {
                Withdrawl_Amount = amount;
            }
        }


        public void CurrentBalance()
        {
            Console.WriteLine("Your current balance: " + balance);
        }

        public void Withdrawl()
        {
            if (Withdrawl_Amount>balance)
            {
                Console.WriteLine("Withdrawl amount should be less than balance");
            }
            else
            {
                balance -= Withdrawl_Amount;
                Console.WriteLine("Amount withdrawl has been successfully completed");
            }
        }


        public void Display()
        {
            Console.WriteLine($"your Balance: {balance}");
        }

    }
}
