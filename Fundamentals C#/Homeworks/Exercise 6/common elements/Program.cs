using System;

namespace common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < array2.Length; i++)
            {
                string current = array2[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (current == array[j])
                    {
                        Console.Write(current + " ");
                    }
                }
            }
        }
    }
}
