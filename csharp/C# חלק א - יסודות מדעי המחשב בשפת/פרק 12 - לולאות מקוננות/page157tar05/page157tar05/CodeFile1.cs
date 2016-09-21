using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0,4} ", j * i);
            }
            Console.WriteLine("\n");
        }

        Console.ReadKey();
    }
}