using System;

class Program
{
    static void SelectionSortByDescending(int[] a)
    {
        int tempIndex;
        int tempElem;

        for (int i = 0; i < a.Length-1; i++)
        {
            tempIndex = i;

            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] < a[j])
                    tempIndex = j;
            }

            tempElem = a[i];
            a[i] = a[tempIndex];
            a[tempIndex] = tempElem;
            
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

        SelectionSortByDescending(a);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}