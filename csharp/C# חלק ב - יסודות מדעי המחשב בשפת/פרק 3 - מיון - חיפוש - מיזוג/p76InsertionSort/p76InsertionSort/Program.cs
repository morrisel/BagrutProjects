using System;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void AddToSortArray(int[] a, int n, int num)
    {
        int i;

        //for (i = 0; i < n && a[i] < num; i++) ;

        i = 0;
        while (i < n && a[i] < num)
        {
            i++;
        }

        for (int j = n; j > i; j--)
            a[j] = a[j - 1];

        a[i] = num;
    }

    static int[] InsertionSort(int size)
    {
        int[] a = new int[size];
        int num;

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value ");
            num = int.Parse(Console.ReadLine());
            AddToSortArray(a, i, num);
        }

        return a;
    }



    static void Main()
    {
        int size;
        int[] arr;

        Console.Write("Enter a size for array ");
        size = int.Parse(Console.ReadLine());

        arr = InsertionSort(size);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}