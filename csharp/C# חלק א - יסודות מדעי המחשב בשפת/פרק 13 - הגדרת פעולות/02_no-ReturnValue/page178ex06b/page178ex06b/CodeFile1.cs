using System;

class CodeFile1
{
    static void P2(int num)
    {
        for (int i = 1; i <= num; i++)
            for (int j = 1; j <= num; j++)
            {
                if (i * j == num)
                    Console.WriteLine("{0,14}\t{1}\n   ........................", i, j);
            }
    }

    public static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Enter a number");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        P2(n);

        Console.ReadKey();
    }
}