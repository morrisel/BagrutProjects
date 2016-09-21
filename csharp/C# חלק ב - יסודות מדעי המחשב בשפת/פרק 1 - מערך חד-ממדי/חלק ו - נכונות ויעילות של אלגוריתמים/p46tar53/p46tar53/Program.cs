using System;

class Program
{
    public static bool Simetri(int[] a)
    {
        int sum1 = 0, sum2 = 0;

        for (int i = 0; i < a.Length/2; i++)
        {
            sum1 += a[i];
            sum2 += a[(a.Length - 1) - i];
            //if (sum1 != sum2)
            //    return true;
        }

        if (sum1 == sum2)
            return true;
        else
            return false;
    }
    static void Main()
    {
        int[] a = new int[] { 10, 2, 8, 5, 3, 12 };
        bool isSimetric;

        isSimetric = Simetri(a);

        if (isSimetric)
            Console.WriteLine("Array is simetri");
        else
            Console.WriteLine("Array isn't simetri");

        Console.ReadKey();
    }
}