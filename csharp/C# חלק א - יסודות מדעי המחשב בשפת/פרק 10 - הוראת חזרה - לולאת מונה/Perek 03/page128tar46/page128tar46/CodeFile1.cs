using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int m = 1, x, y;

        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());

        Console.Write("y = ");
        y = int.Parse(Console.ReadLine());

        for (int j = x; j <= y; j++)
            m = m * j;

        Console.WriteLine(m);

        Console.ReadKey();
    }
}