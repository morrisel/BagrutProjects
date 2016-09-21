using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, digCount = 0;

        Console.Write("Please enter an integer number: ");
        num = int.Parse(Console.ReadLine());

        if (num == 0)
            digCount = 1;

        while (num != 0)
        {
            num = num / 10;
            digCount = digCount + 1;
        }
        Console.WriteLine("The number has {0} digits", digCount);

        Console.ReadKey();
    }
}