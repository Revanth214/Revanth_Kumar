using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondADO_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDetails details = new MovieDetails();
            List<MovieModel> movie = details.GetDetials();
            foreach(MovieModel mv in movie)
            {
                Console.WriteLine(mv.MovieID);
                Console.WriteLine(mv.Title);
                Console.WriteLine(mv.Genre);
                Console.WriteLine(mv.StudiioName);
                Console.WriteLine("===================");
            }
            Console.ReadLine();
        }
    }
}
