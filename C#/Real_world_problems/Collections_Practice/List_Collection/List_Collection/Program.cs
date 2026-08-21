using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Casual Shoes");
            shoppingList.Add("One Jacket");
            shoppingList.Add("Cargo Pant");
            shoppingList.Add("One White T-Shirt");
            shoppingList.Add("One Tie");

            Console.WriteLine("========== Shopping List ==========");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Total items: " + shoppingList.Count);

            Console.WriteLine();
            Console.Write("Which item do you want to remove? ");
            string itemToRemove = Console.ReadLine();

            if (shoppingList.Remove(itemToRemove))
            {
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item was not found.");
            }

            Console.WriteLine();
            Console.WriteLine("========== Updated Shopping List ==========");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total items: " + shoppingList.Count);

            Console.WriteLine();
            Console.Write("Which item do you want to find? ");
            string itemToFind = Console.ReadLine();

            if (shoppingList.Contains(itemToFind))
            {
                Console.WriteLine("Item is available in the shopping list.");
            }
            else
            {
                Console.WriteLine("Item is not available in the shopping list.");
            }

            Console.ReadLine();
        }
    }
}
