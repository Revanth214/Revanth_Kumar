using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Pointer_Technique
{
    class Program
    {
        static bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                if (text[left] != text[right])
                {
                return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            if (IsPalindrome(text))
            {
                Console.WriteLine("Polindrome");
            }
            else
            {
                Console.WriteLine("Not a Polindrome");
            }    
           


            Console.ReadLine();
        }
    }
}
