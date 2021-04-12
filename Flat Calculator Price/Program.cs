using System;
using System.Threading;

namespace Flat_Calculation_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the height : ");
            float Height = float.Parse(Console.ReadLine());

            Console.Write("Insert the width : ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("What is the cost of one square feet ? : ");
            float squareFeetPrice = float.Parse(Console.ReadLine());

            float areaCalc = Height * width;
            float Price = areaCalc * squareFeetPrice;

            Console.WriteLine($"This terrain has {areaCalc} square feets");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write($"This flat costs {Price} dollars");
        }
    }
}
