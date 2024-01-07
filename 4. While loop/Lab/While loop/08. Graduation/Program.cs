using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            double gradeSum = 0;
            double excluded = 0;
            bool isExcluded = false;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    gradeSum += grade;
                    counter++;
                }
                else if (grade < 4)
                {
                    excluded++;
                }
                if (excluded >= 2)
                {
                    isExcluded = true;
                    break;
                }

            }
            if (isExcluded == false)
            {
                double averageGrade = gradeSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter + 1} grade");
            }
        }
    }
}
