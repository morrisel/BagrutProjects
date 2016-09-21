using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        for (int a = 1; a <= 20; a++)
            if (a % 2 == 0)
                Console.Write("{0} ", a);

        Console.WriteLine();
        for (int b = 1; b <= 20; b++)
            if (b % 3 == 0)
                Console.Write("{0} ", b);


        Console.WriteLine();
        for (int c = 1; c <= 20; c++)
            if (c % 4  == 0)
                Console.Write("{0} ", c);

        Console.ReadKey();
    }
}