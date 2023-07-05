using System;

namespace splitmoveempty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello,,Softuni";
            string[] words = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
    }
}
