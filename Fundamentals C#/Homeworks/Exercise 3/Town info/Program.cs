using System;

namespace Town_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            decimal population = decimal.Parse(Console.ReadLine());
            decimal km = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {km} square km. ");
        }
    }
}
