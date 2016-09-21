using System;

class Program
{
    static void StupidSort(int[] arr)
    {
        int i = 0, temp;
        while (i < arr.Length - 1)
        {
            if (arr[i + 1] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;

                i = 0;
            }
            else
                i++;
        }
    }

    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0,4}", arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Before sorting");
        Print(arr);

        StupidSort(arr);

        Console.WriteLine("After sorting");
        Print(arr);

        Console.ReadKey();
    }
}