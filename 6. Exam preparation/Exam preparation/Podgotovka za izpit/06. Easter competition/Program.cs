using System;

namespace _06._Easter_competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int mostPoints = 0; string firstPerson = "";
            for (int i = 1; i <= easterBreads; i++)
            {
                int overallPoints = 0;
                string name = Console.ReadLine();
                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    int points = int.Parse(input);
                    overallPoints += points;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{name} has {overallPoints} points.");
                if (overallPoints > mostPoints)
                {
                    Console.WriteLine($"{name} is the new number 1!");
                    mostPoints = overallPoints;
                    firstPerson = name;
                }
            }
            Console.WriteLine($"{firstPerson} won competition with {mostPoints} points!");
        }
    }
}
