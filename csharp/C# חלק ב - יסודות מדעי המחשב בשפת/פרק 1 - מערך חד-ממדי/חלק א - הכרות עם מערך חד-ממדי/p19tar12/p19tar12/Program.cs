using System;

class Program
{
    static void Main()
    {
        int[] a = { 4, 7, 2, 8, 9, 6 };

        for (int i = 0; i < 6; i++)
            a[i] = i;

        for (int i = 0; i < 6; i++)
            a[i] = i++;

        for (int i = 0; i < 6; i++)
            a[i] = a[i] + 1;
        /*
        for (int i = 0; i < 6; i++)         // Exception
            a[i] = a[i + 1];
        */
        /*
        for (int i = 0; i < 6; i++)         // Exception
            a[i - 1] = a[i];
        */

        for (int i = 0; i < 3; i++)
            a[i] = a[i * 2];

        /*
        int j = 1;
        while (j <= 6)                      // Exception
        {
            a[j + 1] = j + 1;
            j++;
        }
        */

        Console.ReadKey();
    }
}