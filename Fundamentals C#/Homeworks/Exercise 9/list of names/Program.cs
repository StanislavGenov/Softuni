using System;
using System.Collections.Generic;

namespace list_of_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);

            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
