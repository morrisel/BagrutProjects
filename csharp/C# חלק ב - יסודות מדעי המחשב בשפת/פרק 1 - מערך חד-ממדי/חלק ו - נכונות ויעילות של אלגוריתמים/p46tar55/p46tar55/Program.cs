using System;

class Program
{
    // "מערך "מוכל ברצף
    public static bool IsArraySequenceContained(int[] a, int[] b)
    {
        int j = 0, count = 0;

        for (int i = 0; i < a.Length * b.Length; i++)
        {
            if (a[j] == b[i])
            {
                count++;
                if (count == a.Length)
                    return true;
                j++;
            }
            else
            {
                j = 0;
                count = 0;
            }
        }

        return false;
    }

    // "מערך "מוכל שלא ברצף
    public static bool IsArrayNotSequenceContained(int[] b, int[] c)
    {
        int j = 0, count = 0;

        for (int i = 0; i < c.Length; i++)
        {
            if (b[j] == c[i])
            {
                count++;
                if (count == b.Length)
                    return true;
                j++;
            }
        }

        return false;
    }


    static void Main()
    {
        int[] a = new int[] { 1, 3, 5, 7, 9, 2 };
        int[] b = new int[] { 1, 2, 3, 1, 3, 5, 7, 9, 2, 1, 8, 9 };
        int[] c = new int[] { 2, 1, 2, 3, 4, 4, 5, 2, 7, 9, 1, 2, 8 };

        bool isFind = false;

        isFind = IsArraySequenceContained(a, b);
        if (isFind)
            Console.WriteLine("Array a is \"Sequence Contained\" to array b");

        isFind = false;
        isFind = IsArrayNotSequenceContained(a, c);
        if (isFind)
            Console.WriteLine("Array a is \"Contained what Not Sequence\" to array b");


        Console.ReadKey();
    }
}