using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two");
                break;
            default: Console.WriteLine("Other");
                break;
        }
    }
}