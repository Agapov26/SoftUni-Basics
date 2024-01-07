using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = int.MinValue;
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                    break;

                int number;
                if (int.TryParse(input, out number))
                {
                    if (number > largestNumber)
                        largestNumber = number;
                }
            }
             Console.WriteLine(largestNumber);
        }
    }
}
