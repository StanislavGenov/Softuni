using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday")
            {
                if (group == "Students")
                {
                    price = 8.45;
                }
                else if (group == "Business")
                {
                    price = 10.90;
                }
                else if (group == "Regular")
                {
                    price = 15;
                }
            }
            if (day == "Saturday")
            {
                if (group == "Students")
                {
                    price = 9.80;
                }
                else if (group == "Business")
                {
                    price = 15.60;
                }
                else if (group == "Regular")
                {
                    price = 20;
                }
            }
            if (day == "Sunday")
            {
                if (group == "Students")
                {
                    price = 10.46;
                }
                else if (group == "Business")
                {
                    price = 16;
                }
                else if (group == "Regular")
                {
                    price = 22.50;
                }
            }
            double current = people * price;
            if (group == "Students" && people >= 30)
            {
                current *= 0.85;
            }
            else if (group == "Buisness" && people >= 100)
            {
                current = (people - 10) * price;
            }
            else if (group == "Regular" && people >= 10 && people <= 20)
            {
                current *= 0.95;
            }
            Console.WriteLine($"Total price: {current:F2}");

        }
    }
}
