using System;

namespace _03.__Final_competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDancer = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = Console.ReadLine();
            var price = 0.0;
            var razhodi = 0.0;
            var TotalPrice = 0.0;
            if (season == "summer")
            {
                if (location == "Bulgaria")
                {
                    price = points * numberDancer;
                    razhodi = price * 0.05;
                    TotalPrice = price - razhodi;
                }

                else if (location == "Abroad")
                {
                    price = numberDancer * points;
                    var bonus = price * 0.50;
                    TotalPrice = (bonus + price);
                    razhodi = TotalPrice * 0.10;
                    TotalPrice -= razhodi;
                }
            }
            else if (season == "winter")
            {
                if (location == "Bulgaria")
                {
                    price = points * numberDancer;
                    razhodi = price * 0.08;
                    TotalPrice = price - razhodi;
                }

                else if (location == "Abroad")
                {
                    price = numberDancer * points;
                    var bonus = price * 0.50;
                    TotalPrice = (bonus + price);
                    razhodi = TotalPrice * 0.15;
                    TotalPrice -= razhodi;
                }
            }
            var Charity = TotalPrice * 0.75;
            var MoneyPerDancer = (TotalPrice - Charity) / numberDancer;
            Console.WriteLine($"Charity - {Charity:F2}");
            Console.WriteLine($"Money per dancer - {MoneyPerDancer:F2}");                   
        }
    }
}
