using System;

// ?כמה ראשוניים
class CodeFile1
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 30; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
                if (i % j == 0)
                    count++;
            if (count <= 2)
                Console.WriteLine("Prime number {0}", i);
        }

        Console.ReadKey();
    }
}