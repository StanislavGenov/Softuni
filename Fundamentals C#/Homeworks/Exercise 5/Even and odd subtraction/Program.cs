using System;
using System.Linq;

namespace Even_and_odd_subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumeven = 0;
            int sumodd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                int curentnumber = numbers[i];
                if (curentnumber % 2 == 0)
                {
                    sumeven += curentnumber;
                }
                else
                {
                    sumodd += curentnumber;
                }
            }
            Console.WriteLine($"{sumeven - sumodd}");
        }
    }
}
