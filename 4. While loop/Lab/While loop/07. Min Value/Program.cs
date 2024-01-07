using System;

namespace _07._Min_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                int number;
                if (int.TryParse(input, out number))
                {
                    if (number < smallest)
                        smallest = number;
                }

            }
            Console.WriteLine(smallest);
        }
    }
}
