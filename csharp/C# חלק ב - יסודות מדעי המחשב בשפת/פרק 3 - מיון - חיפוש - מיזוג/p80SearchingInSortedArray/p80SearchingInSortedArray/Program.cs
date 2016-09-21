using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);
        Console.WriteLine();
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

    static void Main()
    {
        int[] a = new int[] { 23, 1, 3, 33, 15, 6, 7, 30 };
        int value;

        Print(a);
        BubbleSortByAscending(a);
        Print(a);

        Console.WriteLine("Enter a value");
        value = int.Parse(Console.ReadLine());

        Console.WriteLine("intdex of value: {0} is: {1}", value, LinearSearch(a, value));

        Console.ReadKey();
    }
}