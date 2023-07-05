using System;

namespace vending_machines
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string command = Console.ReadLine();

            while (command != "Start")
            {

                double inputmoney = double.Parse(command);
                if (inputmoney == 0.1 || inputmoney == 0.2 || inputmoney == 0.5 || inputmoney == 1 || inputmoney == 2)
                {
                    money += inputmoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputmoney}");

                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                double productprice = 0;
                if (command == "Nuts")
                {
                    productprice = 2;
                }
                else if (command == "Water")
                {
                    productprice = 0.7;
                }
                else if (command == "Crisps")
                {
                    productprice = 1.5;
                }
                else if (command == "soda")
                {
                    productprice = 0.8;
                }
                else if (command == "coke")
                {
                    productprice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                    continue;
                }
                if (money >= productprice)
                {
                    money -= productprice;
                    Console.WriteLine($"Purchased {command}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
