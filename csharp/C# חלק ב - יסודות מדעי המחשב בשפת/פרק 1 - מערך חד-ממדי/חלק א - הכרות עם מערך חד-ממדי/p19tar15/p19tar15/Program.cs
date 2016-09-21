using System;

class Program
{
    static void Main()
    {
        int count = 0;

        //int[] a = { 4, 7, 2, 8, 9, 1, 6 };

        // מערך ממוין בסדר עולה
        int[] a = { 3, 5, 7, 11, 13, 17, 19 };

        for (int i = 0; i < a.Length - 1; i++)
            if (a[i] > a[i + 1])
                count++;

        if (count != 0)
            Console.WriteLine("The array a[] isn't ordered");
        else
            Console.WriteLine("The array a[] is ordered");

        Console.ReadKey();
    }
}