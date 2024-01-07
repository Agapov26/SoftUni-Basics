using System;

namespace Sceleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());

            double reducedTime = lenght / 120 * 2.5;
            double marinTime = lenght / 100 * speed - reducedTime;
            int control = seconds + minutes * 60;

            if(marinTime <= control)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {marinTime - control:f3} second slower.");
            }
        }
    }
}
