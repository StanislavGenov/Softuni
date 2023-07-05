using System;
using System.Linq;

namespace sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < evens.Length; i++)
            {
                int current = evens[i];
                if (current % 2 == 0)
                {
                    sum += current;

                }

            }
            Console.WriteLine(sum);
        }
    }
}
