using System;

namespace _05._Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGrams = food * 1000;
            int totalFood = 0;
            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int foodEaten = int.Parse(command);
                totalFood += foodEaten;
                command = Console.ReadLine();
            }

            if (totalFood <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - foodInGrams} grams more.");
            }
        }
    }
}
