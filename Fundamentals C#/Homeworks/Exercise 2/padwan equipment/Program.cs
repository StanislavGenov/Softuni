using System;

namespace padwan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double prilight = double.Parse(Console.ReadLine());
            double prirob = double.Parse(Console.ReadLine());
            double pribel = double.Parse(Console.ReadLine());
            var sum = prilight * Math.Ceiling(students * 1.1) + prirob * (students) + pribel * (students - (students / 6));
            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {sum - money:F2}lv more.");
            }
        }
    }
}
