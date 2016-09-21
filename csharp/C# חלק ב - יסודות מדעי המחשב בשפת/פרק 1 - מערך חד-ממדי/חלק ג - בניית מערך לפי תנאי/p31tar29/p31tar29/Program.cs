using System;

class Program
{
    static void Main()
    {
        int[] a = { 3, 4, 8, 2, 1, 23, 30, 15, 16, 17 };
        int[] b = new int[a.Length];

        int j = 0, i = 0;

        while (i < 9)
        {
            if (Math.Abs(a[i] - a[i + 1]) == 1)
            {
                b[j] = a[i];
                j++;
                b[j] = a[i + 1];
                j++;
            }
            i++;
        }

        for (i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }


        Console.ReadKey();
    }
}