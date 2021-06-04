using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 4) {
                Console.Write("Choose a door between 1-5 and win a prize! This is attempt #" + i + ": ");
                string number =Console.ReadLine();

                switch (number)
                {
                    case "1":
                        Console.WriteLine("You win a balloon!");
                        break;
                    case "2":
                        Console.WriteLine("You win a stuffed animal!");
                        break;
                    case "3":
                        Console.WriteLine("You win a bicycle!");
                        break;
                    case "4":
                        Console.WriteLine("You win a car!");
                        break;
                    case "5":
                        Console.WriteLine("You win a million dollars!");
                        break;
                    default:
                        Console.WriteLine("That's not even a choice. you won nothing");
                        break;

                }

                i++;
            }
        }
    }
}
