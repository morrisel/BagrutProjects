using System;

class Program
{
    static void Main()
    {
        int[] a = { 4, 2, 8, 5, 6, 5 };
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,3} ", a[i]);

        Console.WriteLine();

        int[] b = new int[a.Length];
        for (int i = 0; i < b.Length; i++)
        {
            b[i] = a[i] * 2;
            Console.Write("{0,3} ", b[i]);
        }

        Console.ReadKey();
    }
}