using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int cost = 0;
            if (0 > age && age > 122)
            {
                Console.WriteLine("Error!");


                if (0 <= age && age <= 18)
                {
                    if (day == "Weekday")
                    {
                        cost = 12;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Weekend")
                    {
                        cost = 15;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Holiday")
                    {
                        cost = 5;
                        Console.WriteLine($"{cost}$");
                    }

                }
                if (18 <= age && age <= 64)
                {
                    if (day == "Weekday")
                    {
                        cost = 18;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Weekend")
                    {
                        cost = 20;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Holiday")
                    {
                        cost = 12;
                        Console.WriteLine($"{cost}$");
                    }

                }
                if (64 <= age && age <= 122)
                {
                    if (day == "Weekday")
                    {
                        cost = 12;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Weekend")
                    {
                        cost = 15;
                        Console.WriteLine($"{cost}$");
                    }
                    if (day == "Holiday")
                    {
                        cost = 10;
                        Console.WriteLine($"{cost}$");

                    }

                }
            }
        }
    }
}
