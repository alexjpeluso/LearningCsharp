using System;

namespace Execise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            double money;
            string message_1 = "Let's go shopping!";
            string message_2 = "Let's stay home";

            Console.Write("Is guacamole on sale? (yes/no): ");
            answer = Console.ReadLine();

            Console.Write("How much money is in your pocket? ");
            money = Convert.ToDouble(Console.ReadLine());

            if (answer == "yes")
            {
                if(money >= 10)
                {
                    Console.Write(message_1);
                }
                else
                {
                    Console.Write(message_2);
                }
            }
            else
            {
                if (money >= 100)
                {
                    Console.Write(message_1);
                }
                else
                {
                    Console.Write(message_2);
                }
            }

        }
    }
}
