using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    static class Inventory
    {
        private static List<Product> inventory;

        static Inventory()
        {
            inventory = new List<Product>();
        }

        static public void printInventory()
        {
            double totalinventory = 0;
            Console.WriteLine();
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("**************************************\n");
            foreach (Product x in Inventory.inventory)
            {
                Console.WriteLine(x.displayInfo());
                Console.WriteLine();
                totalinventory += x.totalValue();
            }

            Console.WriteLine($"Total inventory value ${totalinventory.ToString("F")}");
            Console.WriteLine();
        }

        static public void addProduct(Product product)
        {
            inventory.Add(product);
        }
    }
}
