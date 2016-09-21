using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int sumPass = 0, sumFail = 0, countPass = 0, countFail = 0;
        int i, n, grd;
        double avgPass, avgFail, difAvg;

        Console.Write("Enter the number of students: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (i = 1; i < n; i++)
        {
            Console.Write("Enter the grade: ");
            grd = int.Parse(Console.ReadLine());

            if (grd >= 55)
            {
                sumPass = sumPass + grd;
                countPass++;
            }
            else
            {
                sumFail = sumFail + grd;
                countFail++;
            }
        }


        if (countPass > 0)
            avgPass = (double)sumPass / countPass;
        else
            avgPass = 0;


        if (countFail > 0)
            avgFail = (double)sumFail / countFail;
        else
            avgFail = 0;



        difAvg = avgPass - avgFail;

        Console.WriteLine("\n\nThe difference between the average is: {0}", difAvg);

        Console.ReadKey();
    }
}