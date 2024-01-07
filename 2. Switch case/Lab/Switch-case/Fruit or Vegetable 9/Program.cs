using System;

namespace Fruit_or_Vegetable_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch(input)
            {
                case "banana":
                case "apple":
                case "cherry":
                case "lemon":
                case "grapes":
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
