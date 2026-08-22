using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_in_Polymorphism
{
    class Sports
    {
        public virtual void Display()
        {
            Console.WriteLine("Sports");
        }
        public virtual void Show()
        {
            Console.WriteLine("They are Playing Kabaddi");
        }
    }
    class Kabaddi : Sports
    {
        public new void Display()
        {
            Console.WriteLine("Kabaddi");
        }
        public override void Show()
        {
            Console.WriteLine("I like Playing Kabaddi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kabaddi kbd = new Kabaddi();
            kbd.Display();
            kbd.Show();

            Sports spr = new Kabaddi();
            spr.Display();
            spr.Show();

            Console.ReadLine();
        }
    }
}
