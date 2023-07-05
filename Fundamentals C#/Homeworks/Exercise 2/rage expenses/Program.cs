using System;

namespace rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double money = (headset * (lostgames / 2)) +
                (mouse * (lostgames / 3)) +
                (keyboard * (lostgames / 6)) +
                (display * (lostgames / 12));


            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
