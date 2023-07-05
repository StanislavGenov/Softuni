using System;

namespace smallest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMinNumer(a, b, c);
            Console.WriteLine(result);
        }

        private static int GetMinNumer(int a, int b, int c)
        {
            int minNumber = b;

            if (a < b)
            {
                minNumber = a;
            }
            if (c < minNumber)
            {
                minNumber = c;
            }
            return minNumber;
        }
    }
    }
