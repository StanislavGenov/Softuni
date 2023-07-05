using System;

namespace greater_two_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            PrintIfItsInside(words, n);

        }

        private static void PrintIfItsInside(string[] words, int n)
        {
            if (n >= 0 && n < words.Length)
            {
                Console.WriteLine(words[n]);
            }
        }
    }
}
