using System;

namespace On_Time_for_the_Exam_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHH = int.Parse(Console.ReadLine());
            int examMM = int.Parse(Console.ReadLine());
            int arrivalHH = int.Parse(Console.ReadLine());
            int arrivalMM = int.Parse(Console.ReadLine());
            string onTime = "On time";
            string earlyTime = "Early";
            string lateTime = "Late";
            string beforeT = "before the start";
            string afterT = "after the start";
            string min = "minutes";
            string hour = "hours";

            int examT = (examHH * 60) + examMM;
            int arrivalT = (arrivalHH * 60) + arrivalMM;
            int deltaT = examT - arrivalT;
            int printHH = 0;
            int printMM = 0;

            if (deltaT == 0)
            {
                Console.WriteLine(onTime);
            }
            else
            {
                if (deltaT > 0)
                {
                    if (deltaT <= 30)
                    {
                        Console.WriteLine(onTime);
                        Console.WriteLine("{0} {1} {2}", deltaT, min, beforeT);
                    }
                    else
                    {
                        printHH = deltaT / 60;
                        printMM = deltaT % 60;

                        Console.WriteLine(earlyTime);
                        if (printHH == 0)
                        {
                            Console.WriteLine("{0} {1} {2}", printMM, min, beforeT);
                        }
                        else
                        {
                            if (printMM < 10)
                            {
                                Console.WriteLine("{0}:0{1} {2} {3}", printHH, printMM, hour, beforeT);
                            }
                            else
                            {
                                Console.WriteLine("{0}:{1} {2} {3}", printHH, printMM, hour, beforeT);
                            }
                        }

                    }
                }
                else
                {
                    printHH = Math.Abs(deltaT) / 60;
                    printMM = Math.Abs(deltaT) % 60;

                    Console.WriteLine(lateTime);
                    if (printHH == 0)
                    {
                        Console.WriteLine("{0} {1} {2}", printMM, min, afterT);
                    }
                    else
                    {
                        if (printMM < 10)
                        {
                            Console.WriteLine("{0}:0{1} {2} {3}", printHH, printMM, hour, afterT);
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} {2} {3}", printHH, printMM, hour, afterT);
                        }
                    }
                }
            }
        }
    }
}

