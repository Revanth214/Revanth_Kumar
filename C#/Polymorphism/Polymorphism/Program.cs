using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Morph obj = new Morph(); 
            
            // Poly obj=new Morph(); -- We use this upcasting to call methods only if the declaration of the all variables done in base(parent) class.

            obj.Name = "C Revanth Kumar";
            obj.Friend = "Chinni";
            obj.Mother = "C Nagaveni";
            obj.Father = "C Gangadhar";
            obj.Brother = "C Bharath";

            obj.Fashion();

            Over_Loading over = new Over_Loading();
            over.Fun("Krishna", "Flutist");

            over.Fun(50, 50);

            Console.ReadLine();
        }
    }
}
