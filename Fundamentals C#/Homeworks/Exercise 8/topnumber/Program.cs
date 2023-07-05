using System;

namespace topnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (isDivisibleBy8(i) && containsodd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool isDivisibleBy8(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            bool isDivisible = sum % 8 == 0;

            return isDivisible;
        }
        private static bool containsodd(int i)
        {
            while (i > 0)
            {
                int current = i % 10;

                if (current % 2 == 1)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

    }
}

