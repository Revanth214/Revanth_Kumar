using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> FreeFire = new Dictionary<string, int>();
            FreeFire.Add("RB_LEO_517", 12);
            FreeFire.Add("Spark_NEO", 17);
            FreeFire.Add("Spark_Rider", 10);
            FreeFire.Add("Spark_Raju", 11);
            FreeFire.Add("Spark_Skanda", 5);
            void Display()
            {
                foreach (KeyValuePair<string, int> play in FreeFire)
                {
                    Console.WriteLine($"Player: {play.Key}, Kills: {play.Value}");
                }
            }
            Display();
            Console.WriteLine($"Spark_NEO: {FreeFire["Spark_NEO"]}");
            FreeFire["Spark_NEO"] = 25;
            Console.WriteLine("======After Updating Spark_NEO's Kills count=========");
            Display();
            Console.WriteLine("=====After deleting Spark_Raju=======");
            FreeFire.Remove("Spark_Raju");
            Display();
            Console.WriteLine("Count: " + FreeFire.Count);


            Console.ReadLine();
        }
    }
}
