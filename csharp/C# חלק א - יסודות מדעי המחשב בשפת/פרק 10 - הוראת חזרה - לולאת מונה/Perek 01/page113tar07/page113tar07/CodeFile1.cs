using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 50; i++)
            if (i % 2 != 0)
                Console.Write(" " + i);

        Console.ReadKey();
    }
}