using System;
using System.Linq;

namespace reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
