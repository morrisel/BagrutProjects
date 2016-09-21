using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num = 0, t = 0, u = 0;

        while (t + u != 7 || t != u + 1)
        {
            t = num / 10;
            u = num % 10;
            Console.WriteLine(" {0} / 10 = {1}\t{2} % 10 = {3}", num, t, num, u);

            num++;
        }

        Console.ReadKey();
    }
}