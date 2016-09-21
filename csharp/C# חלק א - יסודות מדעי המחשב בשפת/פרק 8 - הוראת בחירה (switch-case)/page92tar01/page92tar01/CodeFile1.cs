using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int x;
        Console.Write("Enter a number: ");
        x = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1: Console.WriteLine("one");
                break;
            case 2: Console.WriteLine("two");
                break;
            case 3:
            case 4:
                Console.WriteLine("three of four");
                break;
            case 5:
                Console.WriteLine("five");
                x = x + 5;
                break;
                
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Console.WriteLine("6-10");
                break;
        }
        switch (x)
        {
            case 10:
            case 11:
                Console.WriteLine("10-11");
                break;
        }

        Console.ReadKey();
    }
}