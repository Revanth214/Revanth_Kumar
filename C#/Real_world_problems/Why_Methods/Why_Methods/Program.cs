using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int>();
            my_list.Add(5);
            my_list.Add(12);
            my_list.Add(10);
            void Show()
            {
                foreach (var item in my_list)
                {
                    Console.WriteLine(item);
                }
            }
            Show();
            my_list.Add(20);

            Console.WriteLine("After Adding another element");
            Show();
            Console.ReadLine();
        }
    }
}
