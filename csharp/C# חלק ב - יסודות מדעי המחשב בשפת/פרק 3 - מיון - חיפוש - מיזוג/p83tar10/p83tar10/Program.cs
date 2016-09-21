using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static int BinarySearch(int[] a, int value)
    {
        int low = 0, hight = a.Length - 1, middle;

        while (low <= hight)
        {
            middle = (low + hight) / 2;
            if (value == a[middle])
                return middle;
            else
                if (value > a[middle])
                    hight = middle - 1;
                else
                    low = middle + 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] a = { 98, 95, 92, 90, 80, 75, 70, 60, 30, 23, 15, 12, 6, 3, 1 };
        int value;

        Print(a);

        Console.WriteLine("Enter a value");
        value = int.Parse(Console.ReadLine());

        Console.WriteLine("intdex of value: {0} is: {1}", value, BinarySearch(a, value));

        Console.ReadKey();
    }
}