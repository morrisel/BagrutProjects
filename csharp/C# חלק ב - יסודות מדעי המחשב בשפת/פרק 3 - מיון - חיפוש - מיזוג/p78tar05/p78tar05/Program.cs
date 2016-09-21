using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void AddToSortArray(int[] a, int n, int num)
    {
        int i = 0;

        while (i < n && a[i] > num)
        {
            i++;
        }


        int j = n;
        while (j > i)
        {
            a[j] = a[j - 1];
            j--;
        }

        a[i] = num;
    }
    static int[] InsertionSortByDescending(int size)
    {
        int num;
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value ");
            num = int.Parse(Console.ReadLine());
            AddToSortArray(arr, i, num);
        }

        return arr;
    }

    static void SelectionSortByIndex(int[] a, int start, int last)
    {
        //int len = (int)Math.Abs(start - last);
        int tempIndex;
        int key;

        for (int k = start; k < 2; k++)
        {
            for (int i = start; i >= start && i < last; i++)
            {
                tempIndex = i;
                for (int j = i + 1; j >= start + 1 && j <= last; j++)
                {
                    if (a[j] < a[tempIndex])
                        tempIndex = j;
                }

                key = a[i];
                a[i] = a[tempIndex];
                a[tempIndex] = key;
            }

            start = last + 1;
            last = a.Length - 1;
        }

        //for (int i = start; i >= start && i < last; i++)
        //{
        //    tempIndex = i;
        //    for (int j = i + 1; j >= start + 1 && j <= last; j++)
        //    {
        //        if (a[j] < a[tempIndex])
        //            tempIndex = j;
        //    }

        //    key = a[i];
        //    a[i] = a[tempIndex];
        //    a[tempIndex] = key;
        //}
    }

    static void Main()
    {
        int[] a = { 2, 8, 20, 4, 7, 15, 18, 1 };
        int start, last;

        Console.WriteLine("\nBefore sorting");
        Print(a);

        Console.WriteLine("\nThe lenght of array is: {0}", a.Length);
        Console.WriteLine("The array started from index: {0}", a.Length - a.Length);
        Console.WriteLine("The array ended on index: {0}", a.Length - 1);

        Console.WriteLine("\nArray will be sort from start up to ending index that putted\n");

        Console.Write("Enter a number {0} for first-half of starting index an array: ", a.Length - a.Length);
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter a number {0} for first-half of last index an array: ", a.Length / 2 - 1);
        last = int.Parse(Console.ReadLine());

        SelectionSortByIndex(a, start, last);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}