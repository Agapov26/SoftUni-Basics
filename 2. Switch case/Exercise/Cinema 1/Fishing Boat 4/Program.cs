using System;

namespace Fishing_Boat_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());

            double sprinShip = 3000;
            double summerAndAutumnShip = 4200;
            double winterShip = 2600;

            double bonus = 0;

            switch (season)
            {
                case "Spring":
                    if (fisherMan <= 6)
                    {
                        bonus = sprinShip * 0.9;
                    }
                    else if (fisherMan >= 7 && fisherMan <= 11)
                    {
                        bonus = sprinShip * 0.85;
                    }
                    else if (fisherMan > 11)
                    {
                        bonus = sprinShip * 0.75;
                    }
                    break;
                
                case "Summer":
                    if (fisherMan <= 6)
                    {
                        bonus = summerAndAutumnShip * 0.9;
                    }
                    else if (fisherMan >= 7 && fisherMan <= 11)
                    {
                        bonus = summerAndAutumnShip * 0.85;
                    }
                    else if (fisherMan > 11)
                    {
                        bonus = summerAndAutumnShip * 0.75;
                    }
                    break;
                
                case "Autumn":
                    if (fisherMan <= 6)
                    {
                        bonus = summerAndAutumnShip * 0.9;
                    }
                    else if (fisherMan >= 7 && fisherMan <= 11)
                    {
                        bonus = summerAndAutumnShip * 0.85;
                    }
                    else if (fisherMan > 11)
                    {
                        bonus = summerAndAutumnShip * 0.75;
                    }
                    break;
                
                case "Winter":
                    if (fisherMan <= 6)
                    {
                        bonus = winterShip * 0.9;
                    }
                    else if (fisherMan >= 7 && fisherMan <= 11)
                    {
                        bonus = winterShip * 0.85;
                    }
                    else if (fisherMan > 11)
                    {
                        bonus = winterShip * 0.75;
                    }
                    break;
                default:
                    break;
            }
            double discount = 0;

            if (fisherMan % 2 == 0 && season != "Autumn")
            {
                discount = 0.05;
            }

            double totalPrice = budget - (bonus - bonus * discount);

            if (totalPrice >= 0)
            {
                Console.WriteLine($"Yes! You have {totalPrice:f2} leva left.");
            }
            else
                Console.WriteLine($"Not enough money! You need {(totalPrice * -1):f2} leva.");
        }
    }
}
