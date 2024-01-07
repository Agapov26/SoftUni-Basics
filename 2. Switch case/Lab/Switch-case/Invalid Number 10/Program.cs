using System;

namespace Invalid_Number_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((a != 0) && ((a <= 99) || (a >= 201)))
            {
                Console.WriteLine("invalid");
            }            
        }
    }
}
