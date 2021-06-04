using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine(Hello(name));

            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine(Hello(name));

            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine(Hello(name, "how are you?"));
        }

        static string Hello(string name, string? how = null)
        {
            string message = "Hello " + name + "! " + how+"\n";
            return message;
        }
    }
}
