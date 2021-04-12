using System;

namespace Fibb_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int fibbonaciSequence, nextNumber;
            int numberOfElements;

            Console.Write("How many  numbers you want to print : ");
            int numbersToPrint = int.Parse(Console.ReadLine());

            if (numbersToPrint < 2 && numbersToPrint != 0)
            {
                Console.WriteLine("Please enter a number greater than [ 2 ]");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(firstNumber + secondNumber);

                for (int i = 2; i < numbersToPrint; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
        }
    }
}
