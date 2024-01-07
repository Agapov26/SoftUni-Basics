using System;

namespace _01._Cat_diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatPercentage = int.Parse(Console.ReadLine());
            int proteinPercentage = int.Parse(Console.ReadLine());
            int carbPercentage = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int waterPercentage = int.Parse(Console.ReadLine());

            double fatCalories = (fatPercentage * totalCalories) / 100.0;
            double proteinCalories = (proteinPercentage * totalCalories) / 100.0;
            double carbCalories = (carbPercentage * totalCalories) / 100.0;

            double totalGrams = (fatCalories / 9) + (proteinCalories / 4) + (carbCalories / 4);
            double caloriesPerGram = totalCalories / totalGrams;
            double waterCalories = (waterPercentage * caloriesPerGram) / 100.0;

            double finalCalories = caloriesPerGram - waterCalories;

            Console.WriteLine($"{finalCalories:F4}");               
        }
    }
}
