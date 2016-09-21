using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Enter a number");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
                if (i < j)
                    Console.WriteLine(i + " " + j);
        }



        Console.ReadKey();
    }
}