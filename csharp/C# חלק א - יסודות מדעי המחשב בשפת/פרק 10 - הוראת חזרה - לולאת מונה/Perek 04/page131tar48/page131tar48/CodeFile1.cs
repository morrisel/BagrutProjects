using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double height, min, max;

        Console.Write("Insert the height of plant ");
        height = double.Parse(Console.ReadLine());

        max = height;
        min = height;

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Insert the height of plant ");
            height = double.Parse(Console.ReadLine());

            if (height > max)
                max = height;
            if (height < min)
                min = height;
        }
        Console.Write("\n\nMaximum = {0}", max);
        Console.Write("\nMinimum = {0}", min);


        Console.ReadKey();
    }
}