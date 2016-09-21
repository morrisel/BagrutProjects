using System;

class Program
{
    const int TOP = 10;

    static void Main()
    {
        int[] a = { 13, -7, 3, -5, 2, -17, 11, -19, 23, 29 };
        int[] b = new int[TOP];

        int temp = 0;

        Console.WriteLine("Printing the original array a[]");
        Console.Write("array a[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", a[i]);

        Console.WriteLine("\n" + new string('-', 50));

        for (int i = 0; i < TOP; i++)
        {
            for (int j = 0; j < TOP-1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
            b[i] = a[i];
        }

        Console.Write("\narray b[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", b[i]);

        Console.ReadKey();
    }
}
