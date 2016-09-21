using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int grd, sum, count, best = 0;
        double avg;

        for (int i = 1; i <= 38; i++)
        {
            sum = 0;
            count = 0;

            Console.Write("Enter a grade: ");
            grd = int.Parse(Console.ReadLine());

            while (grd != -999)
            {
                sum = sum + grd;
                count++;

                Console.Write("Enter a grade: ");
                grd = int.Parse(Console.ReadLine());


            }

            avg = (double)sum / count;
            Console.WriteLine("\nThe average of stud num: {0} is {1}", i, avg);
            if (avg > 90)
                best++;
            Console.WriteLine("There are {0} excellent students\n", best);
            Console.WriteLine("-------------------------------------------\n");
        }


        Console.ReadKey();
    }
}