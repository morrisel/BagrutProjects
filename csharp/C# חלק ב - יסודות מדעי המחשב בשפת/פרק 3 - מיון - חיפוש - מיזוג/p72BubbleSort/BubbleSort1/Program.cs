using System;

class Program
{
    static void BubbleSort(int[] a)
    {
        int temp;

        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("{0,4}", a[i]);
        }
    }

    static void Main()
    {
        int[] a = new int[5] { 23, 15, 6, 7, 30 };

        Console.WriteLine("Before sorting");
        Print(a);

        BubbleSort(a);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}