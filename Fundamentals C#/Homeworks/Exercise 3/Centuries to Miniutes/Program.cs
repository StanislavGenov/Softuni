using System;

namespace Centuries_to_Miniutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = (int)(years * 365.242);
            double hours = 24 * days;
            double min = 60 * hours;
            Console.WriteLine($"{centuries} centuries =" +
                $"{years} years = " +
                $"{days} days = " +
                $"{hours} hours = {min} minutes");
        }
    }
}
