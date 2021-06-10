using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        enum cpoints { n, s, e, w }

        static void Main(string[] args)
        {
            string? entry = null;
            List<cpoints> directions = new List<cpoints>();
            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finish): ");
                entry = Console.ReadLine();

                switch (entry)
                {
                    case "n":
                        directions.Add(cpoints.n);
                        break;
                    case "s":
                        directions.Add(cpoints.s);
                        break;
                    case "e":
                        directions.Add(cpoints.e);
                        break;
                    case "w":
                        directions.Add(cpoints.w);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }

            } while (entry != "0");

            Console.WriteLine();

            Console.WriteLine("You have enter "+directions.Count+" directions. The directions are as follows:");

            foreach(cpoints direc in directions)
            {
                if (direc.Equals(cpoints.n))
                {
                    Console.Write("^");
                }
                else if (direc.Equals(cpoints.s))
                {
                    Console.Write("v");
                }
                else if (direc.Equals(cpoints.e))
                {
                    Console.Write(">");
                }
                else if (direc.Equals(cpoints.w))
                {
                    Console.Write("<");
                }
            }
        }
    }
}
