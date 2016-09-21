using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n, j;
        Console.Write("Enter a number ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            j = n - i + 1;
            Console.WriteLine(j);
        }
        Console.ReadKey();
    }
}