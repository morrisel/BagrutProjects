using System;

class CodeFile1
{
    // Sum of product numbers
    static void Main(string[] args)
    {
        int a1, a2, mult = 1, sum = 0;

        while (mult != 0)
        {
            Console.Write("\nEnter a nunber ");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a nunber ");
            a2 = int.Parse(Console.ReadLine());

            mult = a1 * a2;
            sum = sum + mult;
        }

        if (sum < 0)
            Console.WriteLine("\nThe sum of product {0} is negative.", sum);
        else
            Console.WriteLine("\nThe sum of product {0} is positive.", sum);

        Console.ReadKey();
    }
}