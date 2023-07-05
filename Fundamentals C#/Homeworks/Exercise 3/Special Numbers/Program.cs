using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int digits = i;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;

                }
                bool special = sum == 5 || sum == 7 || sum == 11;
                if (special)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}
