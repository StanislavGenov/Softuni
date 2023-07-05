using System;

namespace Poke_mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targets = 0;
            int half = n / 2;
            while (n >= m)
            {
                targets++;
                if (half == n && y > 0)
                {
                    n /= y;
                }
                else
                {
                    n -= m;
                }

            }
            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
