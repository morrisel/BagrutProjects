using System;

class Program
{
    static bool ZigZag(int[] a)
    {
        int i = 0;

        while (i < a.Length - 1)
        {
            if (i % 2 == 0)
            {
                if (a[i] >= a[i + 1])      
                {
                    return false;
                }
            }
            else
            {
                if (a[i] <= a[i + 1])
                {
                    return false;
                }
            }
            i++;
        }

        return true;
    }


    static void Main()
    {
        int[] a = { 2, 3, 4 };
        int[] arr = { 3, 1, 5, 3, 2, };

        bool isPlaceEmpty;

        isPlaceEmpty=ZigZag(a);


        Console.ReadKey();
    }
}