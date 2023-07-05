using System;

namespace spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {

            int yield = int.Parse(Console.ReadLine());
            int total = 0;
            int days = 0;
            while (yield >= 100)
            {

                total += yield - 26;
                days++;
                yield -= 10;

            }
            if (days > 0)
            {
                total -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
