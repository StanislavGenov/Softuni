using System;
using System.Linq;

namespace max_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxs = 0;
            int current = 1;
            int mostleft = 0;
            string element = string.Empty;
            string comand = Console.ReadLine();

            while (comand != "Clone them!")
            {
                int[] numbers = Console.ReadLine().Split("!").Select(int.Parse).ToArray();

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        current++;
                    }
                    else
                    {
                        current = 1;
                    }
                    if (current > maxs)
                    {
                        maxs = current;
                    }

                }
                int currentleft = string.Join("", numbers).IndexOf(comand);
                if (currentleft < mostleft)
                {

                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(maxs);
        }
    }
}
