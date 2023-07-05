using System;

namespace Back_in_30_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes < 59)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            if (minutes > 59)
            {
                int add = hours + 1;
                if (add > 23)
                {
                    add = 0;
                    int dec = minutes - 60;
                    Console.WriteLine($"{add}:{dec:d2}");

                }
                else
                {
                    add = hours + 1;
                    int dec = minutes - 60;
                    Console.WriteLine($"{add}:{dec:d2}");
                }
            }
        }
    }
}
