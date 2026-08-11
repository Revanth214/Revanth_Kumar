using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAttempSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string username;
            string password;
            int count=1;

            while (count<4)
            {

                Console.WriteLine($"-----{count} attempt------");
                Console.WriteLine("Enter username: ");
                username = Console.ReadLine();
                if (username == "admin")
                {
                    Console.WriteLine("Enter password: ");
                    password = Console.ReadLine();
                    if (password == "CSharp@123")
                    {
                        Console.WriteLine("Login successfull");
                        break;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine("Password is incorrect");
                    }
                }
                else
                {
                    count++;
                    Console.WriteLine("Username is incorrect");
                }
            }
            if (count > 3)
            {
                Console.WriteLine("Account Locked");
            }

            Console.ReadLine();
        }
    }
}
