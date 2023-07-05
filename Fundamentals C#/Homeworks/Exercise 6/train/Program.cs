using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                wagons[i] = people;
            }
            for (int j = 0; j < wagons.Length; j++)
            {
                sum += wagons[j];
                Console.Write(wagons[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
