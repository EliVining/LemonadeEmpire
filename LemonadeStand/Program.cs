using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey!");
            Console.WriteLine("How many lemonade stands would you like to open?");

            int numberOfLemonadeStands = int.Parse(Console.ReadLine());
            List<LemonadeStand> locations = new List<LemonadeStand>();

            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand lemonadeStand = new LemonadeStand();

                Console.WriteLine($"What is the name of location {i+1}?");
                lemonadeStand.Name = Console.ReadLine();
                             
                Console.WriteLine("How many cups will you sell?");
                lemonadeStand.NumberOfCups = Int32.Parse(Console.ReadLine());
               
                Console.WriteLine("How much will you sell each cup for?");
                lemonadeStand.PricePerCup = decimal.Parse(Console.ReadLine());
               
                Console.WriteLine("How much will each cup cost to make?");
                lemonadeStand.CostPerCup = decimal.Parse(Console.ReadLine());
               
                Console.WriteLine($"You'll be opening a stand called {lemonadeStand.Name}.");
                Console.WriteLine($"If you sell all {lemonadeStand.NumberOfCups} cups");
                Console.WriteLine($"Your total revenue will be ${lemonadeStand.GetTotalRevenue()}.");
                Console.WriteLine($"Your total expnses will be ${lemonadeStand.GetTotalExpenses()}.");
                Console.WriteLine($"Your total profit will be ${lemonadeStand.GetTotalProfit()}.");             
            }

            Console.ReadLine();           
        }
    }
}
