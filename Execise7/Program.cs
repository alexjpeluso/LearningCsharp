using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;
            int sum = 0;

            Console.Write("Enter an integer: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer: ");
            third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the three integers is " + sumitup(first, second, third));

            Console.Write("Enter an integer: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer: ");
            third = Convert.ToInt32(Console.ReadLine());

            sumitup(first, second, third, ref sum);

            Console.WriteLine("The sum of the three integers is " + sum);

        }

        static int sumitup(int one, int two, int three)
        {
            return one + two + three;
        }

        static void sumitup(int one, int two, int three, ref int sum)
        {
            sum = one + two + three;
        }
    }
}
