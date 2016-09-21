using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0, wr;
        double r, sd, sum, tSum = 0, avg;

        Console.Write("\nEnter a mount of workers in the factory: ");
        wr = int.Parse(Console.ReadLine());
        for (int i = 1; i <= wr; i++)
        {
            sum = 0;

            Console.Write("\nWhat is a rate per hour of worker_{0}: ", i);
            r = double.Parse(Console.ReadLine());

            for (int d = 1; d <= 25; d++)
            {
                sd = r * 8;
                sum = sum + sd;
            }

            tSum = tSum + sum;
            Console.Write("The salary of worker_{0} is: {1}", i, sum);
            Console.WriteLine("\n---------------------------------------------\n");
            count = i;
        }

        avg = tSum / count;
        Console.WriteLine("\nThe average of total salaries on the factory is: {0}", avg);

        Console.ReadKey();
    }
}