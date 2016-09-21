using System;

class CodeFile
{
    static void Main(string[] args)
    {
        int x, y;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        switch (x + y)
        {
            case 8: x++; break;
            case 9: x--; break;
        }
        Console.WriteLine(x);
    }
}