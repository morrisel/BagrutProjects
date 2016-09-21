using System;
using System.Collections;

class Program
{
    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    public static void RadixSort(int[] arr, int range, int lenght)
    {
        ArrayList[] lists = new ArrayList[range];
        int remainder, num;

        for (int i = 0; i < range; i++)
            lists[i] = new ArrayList();

        for (int step = 0; step < arr.Length; step++)
        {
            // распределение по спискам
            for (int i = 0; i < arr.Length; i++)
            {
                int tempNum1 = arr[i];
                int tempNum2 = (int)Math.Pow(range, step + 1);
                remainder = arr[i] % (int)Math.Pow(range, step + 1);
                num = (int)Math.Pow(range, step);

                int temp = remainder / num;
                //int temp = (arr[i] % (int)Math.Pow(range, step + 1)) / (int)Math.Pow(range, step);

                lists[temp].Add(arr[i]);
            }

            // сборка
            int k = 0;
            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < lists[i].Count; j++)
                {
                    arr[k++] = (int)lists[i][j];
                }
            }

            for (int i = 0; i < range; i++)
            {
                lists[i].Clear();
            }
        }
    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Original Array:");
        Print(arr);

        RadixSort(arr, 10, 2);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}