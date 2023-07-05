using System;

namespace array_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            long first = factorial(a);
            long second = factorial(b);
            double result = (double)first / second;

            Console.WriteLine($"{result:F2}");
        }

        private static long factorial(long a)
        {
            long sum = 1;

            for (long i = 1; i <= a; i++)
            {
                sum *= i;

            }
            return sum;
        }
    }
}
