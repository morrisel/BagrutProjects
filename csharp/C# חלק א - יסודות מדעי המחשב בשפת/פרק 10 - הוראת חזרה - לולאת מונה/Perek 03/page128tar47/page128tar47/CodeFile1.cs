using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, n, i;
        int sum1 = 0, sum2 = 0;

        Console.Write("Enter an integer number ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is maximum of loop");

        for (i = 1; i <= n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num >= 0)
                sum1 = sum1 + num;
            else
                sum2 = sum2 + num;
        }

        Console.WriteLine("The sum of positive = {0}", sum1);
        Console.WriteLine("The sum of negative = {0}", sum2);

        Console.ReadKey();
    }
}