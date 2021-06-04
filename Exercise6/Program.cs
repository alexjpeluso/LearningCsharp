using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime;
            bool isPrime;

            do
            {
                Console.Write("Enter an integer (1 to exit): ");
                prime = Convert.ToInt32(Console.ReadLine());

                isPrime = PrimeCheck(prime);

                if (prime != 1)
                {
                    if (isPrime)
                    {
                        Console.WriteLine(prime + " is a prime number");
                    }
                    else
                    {
                        Console.WriteLine(prime + " is not a prime number");
                    }
                }

            } while (prime != 1);
        }

        static bool PrimeCheck (int prime)
        {
            bool isPrime = true;

            if (prime == 2 || prime == 3)
            {
                isPrime = true;
            }
            else if (prime <= 1 || (prime%2)==0 || (prime%3)==0 )
            {
                isPrime = false;
            }

            int i = 5;

            while(i*i <= prime)
            {
                if((prime%i)==0 || (prime % (i + 2)) == 0)
                {
                    isPrime = false;
                }

                i += 6;
            }

            return isPrime;
        }
    }
}
