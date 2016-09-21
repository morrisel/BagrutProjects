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

    static void Main()
    {
        int size;
        int[] a;

        Console.Write("Enter a size for array ");
        size = int.Parse(Console.ReadLine());

        a = InsertionSortByDescending(size);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}