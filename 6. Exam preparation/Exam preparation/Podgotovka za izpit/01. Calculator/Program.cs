using System;

namespace _01._Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double durationTime = double.Parse(Console.ReadLine());

            double episodesTime = durationTime + durationTime * 0.2;
            double seasonTime = episodes * episodesTime + 10;
            double totalTime =seasons * seasonTime;

            Console.WriteLine($"Total time needed to watch the {serial} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
