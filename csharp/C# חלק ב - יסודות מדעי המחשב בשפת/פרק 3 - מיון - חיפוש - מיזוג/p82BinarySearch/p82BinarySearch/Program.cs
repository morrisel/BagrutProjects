using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);
        Console.WriteLine();
    }

    static void BubbleSortByAscending(int[] a)
    {
        int temp;

        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 1; j < a.Length; j++)
            {
                if (a[j - 1] > a[j])
                {
                    temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }
        }
    }

    static int LinearSearch(int[] a, int value)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == value)
                return i;
            else
                if (a[i] > value)
                    return -1;
        }

        return -1;
    }

    static int BinarySearch(int[] a, int num)
    {
        int low = 0, hight = a.Length - 1, middle;

        while (low <= hight)
        {
            middle = (low + hight) / 2;

            if (num == a[middle])
            {
                return middle;
            }
            else
            {
                if (num < a[middle])
                    hight = middle - 1;
                else
                    low = middle + 1;
            }
        }

        return -1;
    }





    static void Main()
    {
        int[] a = { 1, 3, 6, 12, 15, 23, 30, 60, 70, 75, 80, 90, 92, 95, 98 };
        int value;

        Print(a);

        Console.WriteLine("Enter a value");
        value = int.Parse(Console.ReadLine());

        Console.WriteLine("intdex of value: {0} is: {1}", value, BinarySearch(a, value));

        Console.ReadKey();
    }
}