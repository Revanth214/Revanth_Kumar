using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFunction
{
    class Customer
    {
        public void Greet()
        {
            Console.Write("Enter your favourite: ");
            string anime = Console.ReadLine();
            Console.WriteLine(anime);
        }
    }
}
