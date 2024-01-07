using System;

namespace Area_of_Figures_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var S = a * a; Math.Round(S, 3);
                Console.WriteLine("{0:F3}", S);
            }
            else if (figure == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var a2 = double.Parse(Console.ReadLine());
                var S1 = a1 * a2; Math.Round(S1, 3);
                Console.WriteLine("{0:F3}", S1);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var S2 = Math.PI * r * r; Math.Round(S2, 3);
                Console.WriteLine("{0:F3}", S2);
            }
            else if (figure == "triangle")
            {
                var a3 = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var S3 = (a3 * h) / 2; Math.Round(S3, 3);
                Console.WriteLine("{0:F3}", S3);
            }
        }
    }
}
