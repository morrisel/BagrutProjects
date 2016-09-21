using System;

class Program
{
    static void Main()
    {
        int f = -1;
        int s = 24;
        int n = 6;
        int[] a = new int[] { 2, 3, 5, 12, 8, 6 };
        int[,] c = new int[n, 2];

        for (int i = 0; i < n-2; i++)
        {
            for (int j = i + 1; j < n-1; j++)
            {
                if (a[i] * a[j] == s)
                {
                    f = f + 1;
                    c[f, 0] = a[i];
                    c[f, 1] = a[j];
                }
            }
        }
        if (f == -1)
            Console.WriteLine("empty");
        else
            for (int i = 0; i < f + 1; i++)
                Console.WriteLine("c[{0},0] = {1}, c[{2},1] = {3}", i, c[i, 0], i, c[i, 1]);


        Console.ReadKey();
    }
}