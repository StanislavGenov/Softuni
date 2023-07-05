using System;
using System.Linq;

namespace password_validator
{
    class Program
    {
        private static int digitcounter;

        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckeIfPasswordIsValid(password);

        }

        private static void CheckeIfPasswordIsValid(string password)
        {

            bool isValidLenght = password.Length >= 6 && password.Length <= 10;
            bool isValidSymbols = password.All(char.IsLetterOrDigit);
            bool contain2Digits = password.Count(char.IsDigit) >= 2;




            if (!isValidLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!contain2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValidSymbols && isValidLenght && contain2Digits)
            {
                Console.WriteLine("Password is valid");
            }


        }
    }
}

