using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = max;
            for (int i = 2; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum = sum + a;
                if (a > max) max = a;
            }
            if (max == (sum - max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - (sum - max)));
            }
            
        }
    }
}
