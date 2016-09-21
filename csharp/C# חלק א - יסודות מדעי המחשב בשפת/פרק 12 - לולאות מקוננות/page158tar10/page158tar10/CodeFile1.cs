using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num = 0;

        for (int i = 1; i <= 3; i++)
        {
            for (int j = i + 1; j <= i + 3; j++)
                num = i * 10 + j;
            Console.WriteLine(num);
        }


        Console.ReadKey();
    }
}