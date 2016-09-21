using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("{0,4}", a[i]);
        }
    }

    static void BubbleSortByDescending(int[] a)
    {
        int temp;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            for (int j = a.Length - 2; j >= 0; j--)
            {
                if (a[j + 1] > a[j])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] a = new int[] { 23, 1, 3, 33, 15, 6, 7, 30 };

        Console.WriteLine("Before sorting");
        Print(a);

        BubbleSortByDescending(a);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}