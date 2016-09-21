using System;

class CodeFile1
{
    // The numbers
    static void Main(string[] args)
    {
        int x, y, z, i;
        double avg, positiveAvg = 0;
        Console.WriteLine("Enter a group of three (x,y,z)\n");
        for (i = 1; i <= 5; i++)
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            avg = (double)(x + y + z) / 3;
            Console.WriteLine("The average of group of three is: {0}\n", avg);

            if (avg >= 0)
                positiveAvg++;
        }
        Console.WriteLine("\nThe number of positive average of the group of three is: {0}", positiveAvg);

        Console.ReadKey();
    }
}