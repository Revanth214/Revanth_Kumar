using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentMarks obj = new StudentMarks();
            obj.EnterName("Revanth");
            obj.EnterMarks(99);
            obj.Display();

            Console.ReadLine();

        }
    }
}
