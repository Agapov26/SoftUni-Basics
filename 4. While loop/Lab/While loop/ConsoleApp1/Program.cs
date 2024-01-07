using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                Console.WriteLine(input);
            }
        }
    }
}
