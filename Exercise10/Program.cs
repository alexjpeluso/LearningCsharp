using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("Choose an option from the menu");
                Console.WriteLine("1 - Enter Product:");
                Console.WriteLine("2 - Display Inventory");
                Console.WriteLine("3 - Exit");

                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        Product product = new Product();
                        Inventory.addProduct(product);
                        Console.WriteLine("Added to Inventory");
                        Console.WriteLine();
                        break;
                    case 2:
                        Inventory.printInventory();
                        Console.WriteLine();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        Console.WriteLine();
                        break;
                }
            } while (input != 3);
            
        }

    }
}
