using System;

class CodeFile
{
    static void Main(string[] args)
    {
        int n = 1, b;
        b = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: switch (b)
                {
                    case 1: Console.WriteLine("11");
                        break;
                    case 2: Console.WriteLine("22");
                        break;
                }
                break;
            case 4: Console.WriteLine("4");
                break;
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}