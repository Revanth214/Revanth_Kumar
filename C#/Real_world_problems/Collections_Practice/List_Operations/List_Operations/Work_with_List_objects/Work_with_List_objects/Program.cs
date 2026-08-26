using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_List_objects
{
    class Weapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Ammo { get; set; }
        public Weapon(string name, string type, int damage, int ammo)
        {
            Name = name;
            Type = type;
            Damage = damage;
            Ammo = ammo;
        }
        public void Display()
        {
            Console.WriteLine($"{Name}: Type:{Type}| Damage: {Damage}|Ammo:{Ammo}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("M1887", "Shotgun", 100, 2));
            weapons.Add(new Weapon("AWM", "Sniper", 150, 5));
            weapons.Add(new Weapon("Groza", "Assult Rifle", 85, 30));
            weapons.Add(new Weapon("MP40", "SMG", 75, 40));

            void foreach_loop()
            {
                foreach (Weapon guns in weapons)
                {
                    guns.Display();
                }
            }
            foreach_loop();
            Console.WriteLine("Count: " + weapons.Count);
            Console.WriteLine("First Weapon: "+weapons[0].Name);
            Console.WriteLine("First Weapon Damage: " + weapons[0].Damage);

            weapons[0].Damage = 110;
            Console.WriteLine("Updated damage: " + weapons[0].Damage);
            Console.WriteLine("===========After Update=========");
            foreach_loop();
            weapons.Insert(1, new Weapon("Desert Eagle", "Pistol", 60, 7));
            Console.WriteLine("======After Insert=========");
            foreach_loop();
            Weapon weaponAtRemove = weapons[2];
            weapons.Remove(weapons[3]);
            weapons.Remove(weapons[2]);
            Console.WriteLine("=======After Removing the object========");
            foreach_loop();
            weapons.RemoveAt(0);
            foreach_loop();

            bool exists = weapons.Contains(weapons[0]);
            Console.WriteLine("First Object exists: " + exists);

            Console.ReadLine();
        }
    }
}
