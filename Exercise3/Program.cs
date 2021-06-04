using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.Write("Do you like pizza? (yes/no): ");
                answer = Console.ReadLine();

                if (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("You did not enter a valid response, please try again");
                }

            } while (answer != "yes" && answer != "no");


            if (answer.Equals("yes"))
            {
                Console.Write("You like Pizza");
            }
            else
            {
                Console.Write("You dont like Pizza");
            }
        }
    }
}
