using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static int[] MergeArray(int[] a1, int[] a2)
    {
        int p1 = 0, p2 = 0, p3 = 0;
        int[] a3 = new int[a1.Length + a2.Length];

        while (p1 < a1.Length && p2 < a2.Length)
        {
            if (a1[p1] < a2[p2])
            {
                a3[p3] = a1[p1];
                p1++;
            }
            else
            {
                a3[p3] = a2[p2];
                p2++;
            }
            p3++;
        }

        while (p1 < a1.Length)
        {
            a3[p3] = a1[p1];
            p1++;
            p3++;
        }

        while (p2 < a2.Length)
        {
            a3[p3] = a2[p2];
            p2++;
            p3++;
        }

        return a3;
    }

    static void Main()
    {
        int[] a1 = { 10, 17, 90 };
        int[] a2 = { 1, 3, 12, 100, 110 };
        int[] arr = new int[a1.Length + a2.Length];

        arr = MergeArray(a1, a2);

        Console.ReadKey();
    }
}