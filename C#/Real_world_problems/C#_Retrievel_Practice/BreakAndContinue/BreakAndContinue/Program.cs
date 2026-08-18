using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=10; i++)
            {
                if (i == 5)
                {
                    continue;
                    
                }
                else if (i == 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
