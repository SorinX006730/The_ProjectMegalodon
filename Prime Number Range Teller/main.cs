using System;
using System.Threading;

namespace Fibb_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCounter = 0;

            Console.Write("Enter the start number : ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number :");
            int endNumber = int.Parse(Console.ReadLine());

            NumbersTester(startNumber, endNumber);

            Console.WriteLine($"The prime numbers between {startNumber} and {endNumber} are : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }

            Thread.Sleep(2000);
        }
        static void NumbersTester(int _startNumber, int _endNumber)
        {
            if (_startNumber < 0)
                throw new ArgumentOutOfRangeException("The number you inserted is less than [ 0 ]");
            else if (_startNumber == _endNumber)
                throw new ArgumentOutOfRangeException("The start number can't be equal with the end one ");
            else if (_startNumber > _endNumber)
                throw new ArgumentOutOfRangeException("The start number can't be bigger than the end number");
            else if (_endNumber < _startNumber)
                throw new ArgumentOutOfRangeException("The end number can't be less than the start number");
            else if (_startNumber == 0 && _endNumber == 0)
                throw new ArgumentOutOfRangeException("They are equal to 0");
        }
    }
}
