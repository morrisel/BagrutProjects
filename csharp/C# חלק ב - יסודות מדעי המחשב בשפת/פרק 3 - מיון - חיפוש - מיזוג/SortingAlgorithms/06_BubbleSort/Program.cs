using System;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void Sort(int[] arr)
    {
        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr.Length-1; j > i; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
    }



    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Original Array:");
        Print(arr);

        Sort(arr);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}