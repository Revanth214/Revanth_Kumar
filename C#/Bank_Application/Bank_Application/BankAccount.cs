using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    class BankAccount
    {
        private string AccountNumber;

        public BankAccount(string AccountNumber)
        {
            this.AccountNumber = AccountNumber;
        }
        public decimal Balance { get; private set; }

        public void Deposite(decimal amount)
        {
            if (amount>0)
            {
                Balance += amount;
                Console.WriteLine("You successfully deposited the money");
            }
            else
            {
                Console.WriteLine("Invalid deposite amount");
            }
        }

        public void WithDraw(decimal amount)
        {
            if (amount>Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else if(amount<=0)
            {
                Console.WriteLine("Enter valid amount for same withdraw");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Your amount has been withdrawn successfully");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Accout Number: {AccountNumber}");
            Console.WriteLine($"Your bank balance: {Balance}");
        }

    }
}
