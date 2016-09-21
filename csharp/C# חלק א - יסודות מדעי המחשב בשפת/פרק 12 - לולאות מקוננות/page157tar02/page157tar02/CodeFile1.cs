using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int grd, sum = 0, fails = 0;
        double avg;

        Console.WriteLine();

        for (int i = 1; i <= 5; i++)
        {
            int block = 1;

            while (block <= 6)
            {
                Console.Write("Enter the grade of {0} profession: ", block);
                grd = int.Parse(Console.ReadLine());

                if (grd < 55)
                    fails++;

                sum = sum + grd;
                block++;
            }
            avg = (double)sum / 6;
            Console.WriteLine("\nThe average of {0} student is: {1}\n\n", i, avg);
            sum = 0;
        }

        Console.WriteLine("The mount of fail grades is: {0}", fails);
        

        Console.ReadKey();
    }
}