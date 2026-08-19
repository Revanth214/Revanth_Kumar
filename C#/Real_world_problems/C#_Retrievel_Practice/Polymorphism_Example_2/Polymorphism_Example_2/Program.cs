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

    // Common behavior — every derived class MUST implement this
    public abstract void Withdraw();

    // Common behavior — available to every derived class
    public void ShowAccountHolder()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
    }
}

class Bank : Account
{
    public Bank(string accountHolder) : base(accountHolder)
    {
    }

    // Required because Withdraw() is abstract
    public override void Withdraw()
    {
        Console.WriteLine("Withdrawing from Bank account");
    }

    // Bank-specific member
    public void OpenBank()
    {
        Console.WriteLine("Bank account opened");
    }
}

class OnlineBank : Account
{
    public OnlineBank(string accountHolder) : base(accountHolder)
    {
    }

    // Required because Withdraw() is abstract
    public override void Withdraw()
    {
        Console.WriteLine("Withdrawing from Online Bank");
    }

    // OnlineBank-specific member
    public void GenerateUPI()
    {
        Console.WriteLine("UPI ID generated");
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(string accountHolder) : base(accountHolder)
    {
    }

    // Required because Withdraw() is abstract
    public override void Withdraw()
    {
        Console.WriteLine("Withdrawing from Savings Account");
    }

    // SavingsAccount-specific member
    public void AddInterest()
    {
        Console.WriteLine("Interest added to Savings Account");
    }
}

class Program
{
    // This method only needs common Account functionality.
    public static void ProcessWithdrawal(Account account)
    {
        account.Withdraw();
    }

    static void Main()
    {
        // =========================================================
        // 1. SAME REFERENCE TYPE AND OBJECT TYPE
        // =========================================================

        Bank bank = new Bank("Revanth");

        bank.Withdraw();           // Bank's overridden method
        bank.ShowAccountHolder();  // Account's method
        bank.OpenBank();           // Bank-specific method


        Console.WriteLine();


        // =========================================================
        // 2. PARENT REFERENCE + CHILD OBJECT
        // =========================================================

        Account account1 = new Bank("Revanth");
        Account account2 = new OnlineBank("Bharath");
        Account account3 = new SavingsAccount("Kiran");

        // Common members are accessible

        account1.Withdraw();          // Bank's Withdraw()
        account1.ShowAccountHolder();

        account2.Withdraw();          // OnlineBank's Withdraw()
        account2.ShowAccountHolder();

        account3.Withdraw();          // SavingsAccount's Withdraw()
        account3.ShowAccountHolder();


        // Child-specific members are NOT accessible
        //
        // account1.OpenBank();       // ❌
        // account2.GenerateUPI();    // ❌
        // account3.AddInterest();    // ❌


        Console.WriteLine();


        // =========================================================
        // 3. POLYMORPHISM
        // =========================================================

        ProcessWithdrawal(new Bank("Revanth"));
        ProcessWithdrawal(new OnlineBank("Bharath"));
        ProcessWithdrawal(new SavingsAccount("Kiran"));


        Console.WriteLine();


        // =========================================================
        // 4. ACCESSING CHILD-SPECIFIC MEMBER USING CASTING
        // =========================================================

        Account account4 = new Bank("Revanth");

        // account4.OpenBank();       // ❌

        Bank bank2 = (Bank)account4;

        bank2.OpenBank();             // ✅


        Console.WriteLine();


        // =========================================================
        // 5. SAFE CASTING USING 'is'
        // =========================================================

        Account account5 = new Bank("Revanth");

        if (account5 is Bank bank3)
        {
            bank3.OpenBank();         // ✅
        }

        Console.ReadLine();
    }
}