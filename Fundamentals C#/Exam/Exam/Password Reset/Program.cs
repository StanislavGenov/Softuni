using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string command = Console.ReadLine();


            while (command != "Done")
            {
                if (command == "TakeOdd")
                {
                    StringBuilder odd = new StringBuilder();

                    for (int i = 1; i < input.Length; i += 2)
                    {
                        odd.Append(input[i]);
                    }

                    input = odd.ToString();

                    Console.WriteLine(input);
                }
                if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]);

                    input = input.Remove(index, length);


                    Console.WriteLine(input);
                }
                if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split();
                    string oldstring = splitted[1];
                    string newstring = splitted[2];

                    if (input.IndexOf(oldstring) < 0)
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        input = input.Replace(oldstring, newstring);
                        Console.WriteLine(input);
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");



        }
    }
}