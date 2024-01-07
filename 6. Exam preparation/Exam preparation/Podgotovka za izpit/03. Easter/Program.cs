using System;

namespace _03._Easter
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int bathes = int.Parse(Console.ReadLine());
            double price;

            if (size == "Large")
            {
                if (color == "Red")
                    price = 16;
                else if (color == "Green")
                    price = 12;
                else
                    price = 9;
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                    price = 13;
                else if (color == "Green")
                    price = 9;
                else
                    price = 7;
            }
          
            else
            {
                if (color == "Red")
                    price = 9;
                else if (color == "Green")
                    price = 8;
                else
                    price = 5;
            }
           
            price = price * bathes;

            price = price - price * 0.35;

            Console.WriteLine($"{price:f2} leva.");

        }
    }
}
