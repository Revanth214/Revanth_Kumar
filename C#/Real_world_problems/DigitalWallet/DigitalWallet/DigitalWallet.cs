using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet
{
    class DigitalWallet
    {
        public static void Money()
        {
            Console.WriteLine($"Static method");
        }

        public bool IsEmpty
        {
            get
            {
                return Balance == 0;
            }
        }

        public string OwnerName { get; set; }
        public decimal Balance { get; private set; }
        public DigitalWallet(decimal balance)
        {
            Console.Write("Enter owner name: ");
            OwnerName = Console.ReadLine();
            Balance = balance;
            Console.WriteLine($"Mr.{OwnerName} your Bank balance: {Balance}");
        }


        public void Deposite(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Successfully deposited");
            }
            else
            {
                Console.WriteLine("Deposite amount must be greater than zero");
            }

        }

        public void Withdrawl(decimal amount)
        {
            if (amount <= Balance && amount >0)
            {
                Balance -= amount;
                Console.WriteLine("Successfully withdrawn money");
            }
            else
            {
                Console.WriteLine("Withdrawl amount must be less than and equal to balance");
            }
        }

        public void Display()
        {
            Console.WriteLine("======Your Digita Wallet Summary=========");

            Console.WriteLine($"Mr.{OwnerName} your Current balance: {Balance}");
        }
    }
}
