using System;
using System.Linq;

namespace zigzag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int first = input[0];
                int second = input[1];
                if (i % 2 == 0)
                {
                    array[i] = first;
                    array2[i] = second;
                }
                else
                {
                    array[i] = second;
                    array2[i] = first;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
        }
    }
}
