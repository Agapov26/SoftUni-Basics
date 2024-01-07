using System;

namespace _02._Football_kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double targetAmount = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double buttonsPrice = (tshirtPrice + shortsPrice) * 2;

            double totalAmount = tshirtPrice + shortsPrice + socksPrice + buttonsPrice;
            double discountedAmount = totalAmount - (totalAmount * 0.15);

            if (discountedAmount >= targetAmount)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {discountedAmount:F2} lv.");
            }
            else
            {
                double lackOfMoney = targetAmount - discountedAmount;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {lackOfMoney:F2} lv. more.");        
            }
        }
    }
}
