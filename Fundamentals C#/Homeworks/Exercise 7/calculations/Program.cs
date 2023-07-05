using System;

namespace calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string commanda = Console.ReadLine();
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());


            Print(commanda, input1, input2);
        }

        private static void Print(string command, int a, int b)
        {
            if (command == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (command == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
    }

