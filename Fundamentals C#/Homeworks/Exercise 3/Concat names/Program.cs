using System;

namespace Concat_names
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"{number / 1000:F2}");
        }
    }
}
