using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0, n, m;

        Console.WriteLine("Enter two numbers");
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());

        for (int i = 3; i <= m - 2; i++)
        {
            for (int j = 0; j <= n; j++)
                count++;
            Console.WriteLine(count);
        }


        Console.ReadKey();
    }
}