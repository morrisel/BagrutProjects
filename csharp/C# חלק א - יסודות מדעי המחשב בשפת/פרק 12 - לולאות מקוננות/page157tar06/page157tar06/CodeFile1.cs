using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= 6; j++)
            {
                Console.Write(" ({0},{1})  ", i, j);
            }
            Console.WriteLine("\n\n");
        }

        Console.ReadKey();
    }
}