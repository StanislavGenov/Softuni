using System;
using System.Linq;

namespace Equal_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                if (numbers[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += current;
                }

            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
