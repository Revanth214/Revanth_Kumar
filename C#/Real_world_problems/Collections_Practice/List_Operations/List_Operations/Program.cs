using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>();
            inventory.Add("Medkit");
            inventory.Add("Gloo Wall");
            inventory.Add("AR Ammo");
            inventory.Add("SMG Ammo");
            inventory.Add("Grenade");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i} - {inventory[i]}");
            }

            inventory[3] = "Shotgun Ammo";
            inventory.Insert(1, "Armor");
            Console.WriteLine("Which Item do you want to remove (by index): ");
            int indx = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveAt(indx);
            Console.WriteLine("Do you want to know any item position then tell me what is that item: ");
            string item = Console.ReadLine();
            Console.WriteLine($"Index of {item}: "+inventory.IndexOf(item));
            foreach (string itm in inventory)
            {
                Console.WriteLine($"{inventory.IndexOf(itm)} - {itm}");
            }

            Console.ReadLine();
        }
    }
}
