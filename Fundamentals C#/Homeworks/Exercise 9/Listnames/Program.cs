using System;
using System.Collections.Generic;
using System.Linq;

namespace Listnames
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string[] arraysofNmaes = names.Split(", ");
            List<string> listofNames = names.Split(", ").ToList();

            Console.WriteLine(names);
            Console.WriteLine(string.Join(" ", arraysofNmaes));
            Console.WriteLine(string.Join(" ", listofNames));
        }
    }
}
