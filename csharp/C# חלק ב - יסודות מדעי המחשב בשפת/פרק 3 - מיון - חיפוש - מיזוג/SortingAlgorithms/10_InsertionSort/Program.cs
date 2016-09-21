using System;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static int[] InsertionSort(int size)
    {
        int[] A = new int[size];
        int key, j;

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the number to A[{0}]: ");
            A[i] = int.Parse(Console.ReadLine());

            key = A[i];

            for (j = i - 1; j >= 0 && A[j] > key; j--)
            {
                A[j + 1] = A[j];
            }

            A[j + 1] = key;
        }

        return A;
    }
    /*
    void insert_sort(int *a, int n)
    {
        int i, j, value;
 
        for(i = 1; i < n; i++)
        {
            value = a[i];
            for (j = i - 1; j >= 0 && a[j] > value; j--)
            {
                a[j + 1] = a[j];
            }
            a[j + 1] = value;
        }
    }
    */
    static void Main()
    {
        int size;
        int[] arr;

        Console.Write("Enter the size of array: ");
        size = int.Parse(Console.ReadLine());

        arr = InsertionSort(size);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}