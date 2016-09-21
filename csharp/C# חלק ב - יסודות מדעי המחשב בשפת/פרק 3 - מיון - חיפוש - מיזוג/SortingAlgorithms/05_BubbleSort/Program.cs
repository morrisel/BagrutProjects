using System;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void Sort1(int[] arr, int col)
    {
        int trash = 0;

        for (int i = 0; i < col - 1; i++)
        {
            for (int j = 0; j < col - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    trash = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = trash;
                }
            }
        }
    }

    static void Sort2(int[] arr, int col)
    {
        int trash = 0;
        bool flag = true;

        for (int i = 0; (i < col - 1) && (flag); i++)
        {
            flag = false;

            for (int j = 0; j < col - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    trash = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = trash;

                    flag = true;
                }
            }
        }
    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Original Array:");
        Print(arr);

        //Sort1(arr, arr.Length);

        Sort2(arr, arr.Length);
        

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}