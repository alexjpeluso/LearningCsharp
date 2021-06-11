using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Console.Write("Enter the x coordinate for point 1: ");
            point1.x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the x coordinate for point 2: ");
            point1.y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the x coordinate for point 3: ");
            point2.x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the x coordinate for point 4: ");
            point2.y = Convert.ToDouble(Console.ReadLine());

            double distance = distance2Points(point1, point2);

            Console.WriteLine();

            Console.WriteLine($"The distance between these two points is {distance.ToString("F")}");
        }

        static double distance2Points(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.x - point1.x), 2) + Math.Pow((point2.y - point1.y), 2));
        }


    }
}
