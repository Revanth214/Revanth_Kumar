using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string strng = "   Revanth Kumar   ";

            Console.WriteLine("Original string: " + strng);

            string cleanedString = strng.Trim();

            Console.WriteLine("After Trim: " + cleanedString);
            Console.WriteLine("Convert to Upper Case: " + cleanedString.ToUpper());
            Console.WriteLine("Convert to Lower Case: " + cleanedString.ToLower());

            Console.WriteLine(
                "Length of the cleaned string: " + cleanedString.Length);

            Console.WriteLine(
                "Whether string contains 'a': " +
                cleanedString.ToLower().Contains('a'));

            Console.WriteLine(
                "Replace ' ' with '-': " +
                cleanedString.Replace(' ', '-'));

            Console.WriteLine(
                "First 5 characters: " +
                cleanedString.Substring(0, 5));

            Console.WriteLine("Cleaned string: " + cleanedString);

            Console.ReadLine();
        }
    }
}
