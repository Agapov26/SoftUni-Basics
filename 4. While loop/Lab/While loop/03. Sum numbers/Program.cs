using System;

namespace _03._Sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            while (sum < target)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;
                count++;
            }

            Console.WriteLine(sum);
        }
    }
}
