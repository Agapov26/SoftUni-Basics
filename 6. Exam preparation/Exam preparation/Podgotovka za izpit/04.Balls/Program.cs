using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int blackBalls = 0;
            int otherBalls = 0;

            for (int i = 0; i <= n; i++)
            {
                string color = Console.ReadLine();
                switch(color)
                {
                    case "red":
                        redBalls++;
                        points += 5;
                        break;
                    case "orange":
                        orangeBalls++;
                        points += 10;
                            break;
                    case "yellow":
                        yellowBalls++;
                        points += 15;
                        break;
                    case "white":
                        whiteBalls++;
                        points += 20;
                        break;
                    case "black":
                        blackBalls++;
                        points /= 2;
                        break;
                    default:
                        otherBalls++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherBalls}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");
        }
    }
}
