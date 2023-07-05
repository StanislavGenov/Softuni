using System;

namespace Pounds_to_dollars
{
    class Program
    {
        static void Main(string[] args)
        {

            double pounds = double.Parse(Console.ReadLine());
            double result = pounds * 1.31;
            Console.WriteLine($"{result:F3}");
        }
    }
}
