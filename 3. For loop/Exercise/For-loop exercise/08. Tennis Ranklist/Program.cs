using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int tournamentPoints = 0;
            double tournamentsWon = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string tournamentStage = Console.ReadLine();
                if (tournamentStage == "W")
                {
                    tournamentPoints += 2000;
                    tournamentsWon++;
                }
                else if (tournamentStage == "F")
                {
                    tournamentPoints += 1200;
                }
                if (tournamentStage == "SF")
                {
                    tournamentPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {startingPoints + tournamentPoints}");
            Console.WriteLine($"Average points: {tournamentPoints / tournamentsCount}");
            Console.WriteLine($"{tournamentsWon / tournamentsCount * 100 :f2}%");
        }
    }
}
