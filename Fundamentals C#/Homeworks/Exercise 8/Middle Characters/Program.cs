using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();

            string result = GetMiddle(characters);
            Console.WriteLine(result);
        }

        private static string GetMiddle(string characters)
        {
            string result = string.Empty;

            if (characters.Length % 2 == 1)
            {
                result = characters[characters.Length / 2].ToString();
            }
            else
            {
                result = characters[characters.Length / 2 - 1].ToString();
                result += characters[characters.Length / 2];
            }
            return result;
        }
    }
}
