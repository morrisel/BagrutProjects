using System;

class Program
{
    static void Main()
    {
        int n;
        string kind, line;

        Console.WriteLine("Enter number of animals:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter animals kinds:");
        kind = Console.ReadLine();

        line = kind;

        for (int i = 1; i < n; i++)
        {
            kind = Console.ReadLine();
            line = line + " * " + kind;
        }

        Console.WriteLine(line);

        Console.ReadKey();
    }
}