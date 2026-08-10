using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_sample
{
    class BankStatement
    {
        public decimal balance { get; private set; }

        public void Deposite(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"A deposite of {amount} has been successfully completed.");
            }
            else
            {
                Console.WriteLine("The deposite amount is invalid.");
            }
        }

        public BankStatement(string Name, long AccountNumber)
        {
            Console.WriteLine($"Account holder : {Name}");
            Console.WriteLine($"Account number: {AccountNumber}");
        }


        public void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"Your withdrawal of {amount} was successful.");
        }
    }
}
