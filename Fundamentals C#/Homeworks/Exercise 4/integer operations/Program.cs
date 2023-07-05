using System;

namespace integer_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int ab = a + b;
            int c1 = ab / c;
            int d1 = c1 * d;
            Console.WriteLine(d1);
        }
    }
}
