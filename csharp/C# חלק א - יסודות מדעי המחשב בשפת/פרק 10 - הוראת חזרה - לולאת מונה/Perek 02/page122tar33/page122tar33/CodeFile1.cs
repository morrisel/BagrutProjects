using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int c = 0, n;
        n = int.Parse(Console.ReadLine());
        for (int i = 5; i <= n; i++)
            if (i % 10 == 0)
                c++;
        Console.WriteLine(c);
        Console.ReadKey();
    }
}