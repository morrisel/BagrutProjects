using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n;

        Random rnd = new Random();

        n = rnd.Next(3);
        Console.WriteLine(n);
        Console.ReadKey();
    }
}