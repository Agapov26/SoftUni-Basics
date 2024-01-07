using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenthCake = int.Parse(Console.ReadLine());
            int widthCake = int.Parse(Console.ReadLine());
            int partsCake = lenthCake * widthCake;
            for (int i = 0; i < 1000000; i++)
            {
                string partsC = Console.ReadLine();
                if (partsC == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.", Math.Abs(partsCake));
                    break;
                }
                int parts = int.Parse(partsC);
                partsCake = partsCake - parts;

                if (partsCake < 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(partsCake)); break;
                }
            }
        }
    }
}
