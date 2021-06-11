using System;

namespace Execise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[4];
            double totalSales = 0;
            double totalExpenses;
            double profit;
            double averageProfitPerDistrict;

            // Input sales from each of the four districts
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter sales from district {i + 1}: ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write($"Enter total expenses: ");
            totalExpenses = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Calculate total sales
            //Fixed the problem with the loop, did not read last value for the array
            for (int i = 0; i < 4; i++)
            {
                totalSales += sales[i];
            }

            // Calculate profit
            // Fixed the equation, flip sales and expense
            profit = totalSales - totalExpenses;

            // Calculate average profit per district
            averageProfitPerDistrict = profit / 4;

            Console.WriteLine($"Average profit per district was ${averageProfitPerDistrict.ToString("F")}");

        }
    }
}
