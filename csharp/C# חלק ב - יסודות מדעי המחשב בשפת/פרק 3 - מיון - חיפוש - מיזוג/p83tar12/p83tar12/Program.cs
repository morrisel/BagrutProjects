using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }


    static bool IsSortedArray(int[] a)
    {
        return IsEqualsForSortedArray(a);
    }
    static bool IsEqualsForSortedArray(int[] a)
    {
        if (a.Length % 2 == 0)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length / 2 + i])
                {
                    return false;
                }
            }
        }
        else
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length / 2 + i + 1])
                {
                    return false;
                }
            }
        }

        return true;
    }


    static bool IsNotSortedArray(int[] a)
    {
        return IsEqualsForNotSortedArray(a);
    }
    static bool IsEqualsForNotSortedArray(int[] a)
    {
        // finding by elements..
        int count = 0;

        if (a.Length % 2 == 0)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                for (int j = 0; j < a.Length / 2; j++)
                {
                    if (a[i] == a[j])
                        count++;
                }
            }

            if (count == a.Length / 2)
                return true;
        }
        else
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                for (int j = a.Length / 2 + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        count++;
                }
            }

            if (count == a.Length / 2)
                return true;
        }

        return false;
    }




    static void Main()
    {
        bool answer;

        int[] a1 = { 98, 80, 75, 70, 12, 6, 3, 1 };     // a1 - sorted array
        answer = IsSortedArray(a1);
        Console.WriteLine("a1: {0}", answer);

        int[] a2 = { 3, 92, 80, 75, 70, 60, 30 };       // a2 - not sorted array
        answer = IsNotSortedArray(a2);
        Console.WriteLine("a2: {0}", answer);


        int[] b1 = { 1, 2, 3, 5, 1, 2, 3 };
        answer = IsNotSortedArray(b1);
        Console.WriteLine("b1: {0}", answer);

        int[] b2 = { 1, 2, 3, 1, 2, 3 };
        answer = IsNotSortedArray(b2);
        Console.WriteLine("b2: {0}", answer);
        

        Console.ReadKey();
    }
}