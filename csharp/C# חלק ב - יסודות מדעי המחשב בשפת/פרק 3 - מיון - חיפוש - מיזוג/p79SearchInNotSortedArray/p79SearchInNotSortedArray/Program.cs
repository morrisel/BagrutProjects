using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);
    }

    static int LinearSearch(int[] a, int value)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] == value)
                return i;

        return -1;
    }

    static void Main()
    {
        int[] a = new int[] { 23, 1, 3, 33, 15, 6, 7, 30 };
        int value;

        Console.WriteLine("Enter a value");
        value = int.Parse(Console.ReadLine());

        Console.WriteLine("intdex of value: {0} is: {1}", value, LinearSearch(a, value));

        Console.ReadKey();
    }
}