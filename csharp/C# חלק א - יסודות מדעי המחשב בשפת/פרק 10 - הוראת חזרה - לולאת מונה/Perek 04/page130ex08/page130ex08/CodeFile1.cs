using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double max, weight;

        Console.Write("Enter a ball weight: ");
        weight = double.Parse(Console.ReadLine());
        max = weight;

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Enter a ball weight: ");
            weight = double.Parse(Console.ReadLine());

            if (weight > max)
                max = weight;
        }
        Console.WriteLine("\n\nThe heaviest ball is: {0}", max);

        Console.ReadKey();
    }
}