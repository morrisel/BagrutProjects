using System;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void HeapSort(int[] a)
    {
        int i;
        int temp;

        for (i = a.Length / 2 - 1; i >= 0; i--)
        {
            ShiftDown(a, i, a.Length);
        }

        for (i = a.Length - 1; i >= 1; i--)
        {
            temp = a[0];
            a[0] = a[i];
            a[i] = temp;

            ShiftDown(a, 0, i);
        }

    }

    static void ShiftDown(int[] a, int i, int j)
    {
        bool done = false;
        int maxChild;
        int temp;

        while ((i * 2 + 1 < j) && (!done))
        {
            if (i * 2 + 1 == j - 1)
                maxChild = i * 2 + 1;
            else if (a[i * 2 + 1] > a[i * 2 + 2])
                maxChild = i * 2 + 1;
            else
                maxChild = i * 2 + 2;

            if (a[i] < a[maxChild])
            {
                temp = a[i];
                a[i] = a[maxChild];
                a[maxChild] = temp;

                i = maxChild;
            }
            else
            {
                done = true;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Original Array:");
        Print(arr);

        HeapSort(arr);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}