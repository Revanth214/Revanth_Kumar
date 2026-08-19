using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Account
{
    public string AccountHolder { get; set; }

    public Account(string accountHolder)
    {
        AccountHolder = accountHolder;
    }

    // Every Account must provide its own Withdraw implementation
    public abstract void Withdraw();
}

class Bank : Account
{
    public Bank(string accountHolder) : base(accountHolder)
    {
    }

    public override void Withdraw()
    {
        Console.WriteLine($"{AccountHolder}: Withdraw from Bank");
    }

    public void OpenBank()
    {
        Console.WriteLine($"{AccountHolder}: Bank account opened");
    }
}

class OnlineBank : Account
{
    public OnlineBank(string accountHolder) : base(accountHolder)
    {
    }

    public override void Withdraw()
    {
        Console.WriteLine($"{AccountHolder}: Withdraw from Online Bank");
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(string accountHolder) : base(accountHolder)
    {
    }

    public override void Withdraw()
    {
        Console.WriteLine($"{AccountHolder}: Withdraw from Savings Account");
    }
}

class Program
{
    // This method doesn't care about the specific Account type.
    public static void Process(Account account)
    {
        account.Withdraw();
    }

    static void Main()
    {
        // Parent reference → Child object

        Account account1 = new Bank("Revanth");
        Account account2 = new OnlineBank("Bharath");
        Account account3 = new SavingsAccount("Kiran");

        Process(account1);
        Process(account2);
        Process(account3);

        Console.WriteLine();

        // We cannot do this:
        // account1.OpenBank();  ❌

        // Because account1's reference type is Account.

        // But we can do this:
        Bank bank = new Bank("Revanth");

        bank.OpenBank();       // ✅ Bank-specific method
        bank.Withdraw();       // ✅

        Console.ReadLine();
    }
}
