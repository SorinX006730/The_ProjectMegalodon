using System;
using System.Threading;

namespace Area_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the height : ");
            float Height = float.Parse(Console.ReadLine());

            Console.Write("Insert the width : ");
            float width = float.Parse(Console.ReadLine());

            float areaCalc = Height * width;

            Console.WriteLine($"This terrain has {areaCalc} square feets");
        }
    }
}
