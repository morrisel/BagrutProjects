using System;

class Program
{
    const int TOP = 6;

    static void Main()
    {
        //int[] a = new int[TOP] { 5, 9, 8, 7, 3, 1 };

        int[] a = new int[TOP];
        int temp;

        Console.WriteLine("Enter {0} integer numbers", TOP);
        for (int i = 0; i <= TOP - 1; i++)
            a[i] = int.Parse(Console.ReadLine());

        temp = a[TOP - 1];

        for (int i = TOP - 1; i >= 1; i--)
            a[i] = a[i - 1];

        a[0] = temp;

        Console.WriteLine();
        for (int i = 0; i <= TOP-1; i++)
            Console.WriteLine("{0} ", a[i]);

        Console.ReadKey();
    }
}