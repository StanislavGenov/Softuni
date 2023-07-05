using System;

namespace beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string largkeg = string.Empty;
            double largvolume = 0;
            for (int i = 0; i < n; i++)
            {
                string kegname = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > largvolume)
                {
                    largvolume = volume;
                    largkeg = kegname;
                }
            }
            Console.WriteLine(largkeg);
        }
    }
}
