using System;
using System.Linq;

namespace equal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;
            int middleindex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftsum = 0;
                int rightsum = 0;
                int middle = i + 1;

                for (int j = 0; j <= i; j++)
                {
                    leftsum += numbers[j];
                }

                for (int j = 0; j < i + 2; j++)
                {
                    rightsum += numbers[j];
                }

                if (numbers.Length == 1)
                {
                    isFound = true;
                    middleindex = 0;
                }

                if (leftsum == rightsum)
                {
                    isFound = true;
                    middleindex = middle;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(middleindex);
            }
        }
    }
}
