using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string friend_name;
            int friend_age;
            int final_age;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " and you are " + age + " old");

            Console.WriteLine();

            Console.Write("Enter your friend's name:");
            friend_name = Console.ReadLine();

            Console.Write("Enter your friend's age:");
            friend_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Your friend's name is " + name + " and they are " + age + " old");

            final_age = age + friend_age;
            Console.WriteLine("There are " + final_age + " years between the two of you");
        }
    }
}
