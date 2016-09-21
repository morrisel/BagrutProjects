using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int result;

        for (int k = 1; k <= 5; k++)
        {
            result = 1;
            for (int m = 1; m <= k; m++)
            {
                result = result * m;
            }
            Console.WriteLine(result);
        }

        Console.ReadKey();
    }
}