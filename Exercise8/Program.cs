using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] groceryitems = new string[5];

            int j = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter grocery item " + i + ": ");
                groceryitems[j] = Console.ReadLine();
                j++;
            }

            string item;

            Console.WriteLine();

            Console.Write("Enter a substring to search for: ");
            item = Console.ReadLine();

            Console.WriteLine();

            int occurances=0;

            for (int i = 0; i < groceryitems.Length; i++)
            {
                if (groceryitems[i].Contains(item))
                {
                    occurances++;
                }
            }

            Console.WriteLine("There are " + occurances + " that contain the substring \"" + item + "\"");

        }
    }
}
