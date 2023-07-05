using System;

namespace print_numebrs_in_reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversednumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reversednumbers[i] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < reversednumbers.Length; i++)
            {
                Console.Write(reversednumbers[i] + " ");
            }
        }
    }
}
