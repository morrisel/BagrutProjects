using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0;

        for (int i = 1; i <= 4; i++)
        {
            //int count = 0;
            count++;
            for (int j = 2; j <= i + 1; j++)
            {
                Console.Write(count);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}