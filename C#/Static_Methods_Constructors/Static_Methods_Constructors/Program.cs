using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Methods_Constructors
{
    class Program
    {


        static void One_piece()
        {
            Console.WriteLine("========World of One Piece==========");


            Console.WriteLine("Captain: Monkey D. Luffy");
            Console.WriteLine("1st mate: Roronoa Zoro");
            Console.WriteLine("2nd member: Nami");
            Console.WriteLine("3rd member: Usopp");
            Console.WriteLine("4th memeber: Sanji");
            Console.WriteLine("5th member: Chopper");
            Console.WriteLine("6th memeber: Nico Robin");
            Console.WriteLine("7th member: Franky");
            Console.WriteLine("8th member: ");


        }

        static void Naruto()
        {
            Console.WriteLine("===========World of Naruto============");

            Console.WriteLine("Main Charactor: Ukumaki Naruto");
            Console.WriteLine("1st Hoakge: Hashirama senju");
            Console.WriteLine("2nd Hokage: Tobirama senju");
            Console.WriteLine("3rd Hokage: Hiruzen sarutobi");
            Console.WriteLine("4th Hokage: Namikaze Minato");

        }
        static void Main(string[] args)
        {
            One_piece();
            Naruto();

            Static_sample obj = new Static_sample();

            Console.ReadLine();
        }
    }
}
