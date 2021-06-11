using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            SnazzyQueue<int> queue = new SnazzyQueue<int>();

            int input = 0;

            do
            {
                Console.WriteLine("1 - Enqueue");
                Console.WriteLine("2 - Dequeue");
                Console.WriteLine("3 - Exit");
                input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (input == 1)
                {
                    Console.Write("Enter an item to enqueue: ");
                    queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine();
                }
                else if (input == 2)
                {
                    Console.WriteLine($"{queue.Dequeue().ToString()} has been removed from the queue");
                    Console.WriteLine();
                }

            } while (input != 3);
        }
    }
}
