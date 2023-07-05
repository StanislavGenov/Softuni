using System;

namespace strong_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstnumber = number;
            int sum = 0;
            while (number > 0)
            {
                int current = number % 10;
                int factoriel = 1;

                for (int i = 1; i <= current; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                number /= 10;
            }
            if (firstnumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
