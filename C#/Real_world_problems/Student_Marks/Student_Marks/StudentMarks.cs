using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks
{
    class StudentMarks
    {
        private string Name { get; set; }
        private int Marks { get; set; }
        public Char Grade
        {
            get // Grade demonstrates a calculated/read-only property.
            {
                if (Marks >= 90 && Marks <= 100)
                {
                    return 'A';
                }
                else if (Marks >= 75)
                {
                    return 'B';
                }
                else if (Marks >= 60)
                {
                    return 'C';
                }
                else
                {
                    return 'D';
                }
            }
        }

        public void EnterName(string name)
        {
            Name = name;
        }

        public void EnterMarks(int marks)
        {
            if (marks>=0 && marks<=100)
            {
                Marks = marks;
                Console.WriteLine("Marks have been successfully entered into system");
            }
            else
            {
                Console.WriteLine("Enter valid marks");
            }
        }

        public void Display()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Marks: " + Marks);

            Console.WriteLine("Student Grade: " + Grade);
        }

    }
}
