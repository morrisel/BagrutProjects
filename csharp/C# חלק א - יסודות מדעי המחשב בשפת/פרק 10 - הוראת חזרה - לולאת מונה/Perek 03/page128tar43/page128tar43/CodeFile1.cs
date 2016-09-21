using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int m, time, moreFiveTime = 0, lessFourTime = 0, otherCountTime = 0, countMachine = 0, licNum;
        float avg;
        
        
        for (m = 1; m <= 4; m++)
        {
            Console.Write("Enter a license number: ");
            licNum = int.Parse(Console.ReadLine());
            Console.Write("Enter a pass time: ");
            time = int.Parse(Console.ReadLine());

            if (time > 5)
            {
                Console.WriteLine("You aren't rise to the next stage!");
                moreFiveTime = moreFiveTime + time;
            }
            else
            {
                if (time < 4)
                {
                    Console.WriteLine("The number of rasing car is: {0}", m);
                    Console.WriteLine("The license number of racing car is: {0}", licNum);
                    lessFourTime = lessFourTime + time;
                }
                else
                {
                    otherCountTime = otherCountTime + time;
                }
            }
            Console.WriteLine();
            countMachine++;
        }
        Console.WriteLine();
        avg = (float)(moreFiveTime + lessFourTime + otherCountTime) / countMachine;
        Console.WriteLine("The average of time is: {0}", avg);
        Console.ReadKey();
    }
}