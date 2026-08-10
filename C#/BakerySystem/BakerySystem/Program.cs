using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryItems obj = new BakeryItems();

            for (int i = 0; i < obj.item.Length; i++)
            {
                Console.WriteLine(obj.item[i]);
            }
            obj.select_item("cake",6,'N');

            Console.ReadLine();
        }
    }
}
