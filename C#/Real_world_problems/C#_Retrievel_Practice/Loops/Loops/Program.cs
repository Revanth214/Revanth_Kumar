using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemps = 1;
            while (attemps < 4)
            {
                Console.WriteLine($"============Attemp {attemps}==========");
                Console.Write("Enter Username: ");
                string Username = Console.ReadLine();                
                if(Username== "admin")
                {
                    Console.WriteLine("Enter password: ");
                    int password = Convert.ToInt32(Console.ReadLine());
                    if (password == 1234)
                    {
                        Console.WriteLine("Login Successfull");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password");
                        attemps++;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Usename");
                    attemps++;
                }
            }

            if (attemps > 3)
            {
                Console.WriteLine("Account Locked");
            }

            Console.ReadLine();
        }
    }
}
