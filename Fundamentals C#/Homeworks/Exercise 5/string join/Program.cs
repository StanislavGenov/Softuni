using System;

namespace string_join
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            string joined = string.Join("hopa", array);
            Console.WriteLine(joined);

        }
    }
}
