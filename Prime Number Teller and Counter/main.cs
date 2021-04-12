using System;
using System.Threading;

namespace Fibb_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCounter = 0;

            while (true)
            {
                bool isPrime = true;

                Console.Write("Enter some number (If you want to exit enter [ 0 ]) : ");
                int numbersInput = int.Parse(Console.ReadLine());

                if (numbersInput == 0)
                    break; // While - break

                for (int i = 2; i < numbersInput - 1; i++)
                {
                    if (numbersInput % i == 0)
                    {
                        isPrime = false;
                        break; // For - brea
                    }
                    else if (numbersInput % i == 1 && numbersInput != 0)
                    {
                        isPrime = true;
                        primeCounter++;
                    }
                }

                if (isPrime == true)
                {
                    Console.WriteLine("Is Prime");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Is not prime");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }
            Console.WriteLine($"Total prime numbers : {primeCounter}");
        }
    }
}
