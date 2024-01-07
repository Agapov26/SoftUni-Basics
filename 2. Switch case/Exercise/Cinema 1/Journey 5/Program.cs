using System;

namespace Journey_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (money <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double spend = money / 100.0 * 30;
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    double spend = money / 100.0 * 70;
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else if (money <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double spend = money / 100.0 * 40;
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    double spend = money / 100.0 * 80;
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }

            }
            else
            {
                Console.WriteLine("Somewhere in Europe");

                double spend = money / 100.0 * 90;
                Console.WriteLine("Hotel - {0:F2}", spend);
            }
        }
    }
}
