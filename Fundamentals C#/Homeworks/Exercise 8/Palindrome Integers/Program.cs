using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                bool isPalindrome = Palindrome(command);

                Console.WriteLine(isPalindrome);

                command = Console.ReadLine();
            }
        }

        private static bool Palindrome(string command)
        {
            string reversed = string.Empty;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                reversed += command[i];
            }
            bool isPalindrome = command == reversed;

            return isPalindrome;

        }
    }
    }

