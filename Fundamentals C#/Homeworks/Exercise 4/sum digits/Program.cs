using System;

namespace sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n;
            int sum = 0;
            while (number > 0)
            {
                n = number % 10;
                sum = sum + n;
                number = number / 10;


            }
            Console.WriteLine(sum);
        }
    }
}
