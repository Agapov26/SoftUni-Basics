using System;

namespace Small_Shop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * number);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.80 * number);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.20 * number);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * number);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.60 * number);
                }

            }
            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.40 * number);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * number);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * number);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * number);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.50 * number);
                }
            }
            if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * number);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * number);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.10 * number);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * number);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * number);
                }
            }
        }
    }
}
