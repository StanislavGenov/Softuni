using System;
using System.Numerics;

namespace snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger largest = 0;

            int lasnow = 0;
            int lastime = 0;
            int lastquality = 0;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, quality);

                if (value > largest)
                {
                    largest = value;
                    lasnow = snow;
                    lastime = time;
                    lastquality = quality;
                }
            }
            Console.WriteLine($"{lasnow} : {lastime} = {largest} ({lastquality})");
        }
    }
}
