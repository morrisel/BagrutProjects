using System;

class Program
{
    public static int GetTwoArray(int[] a, int[] b)
    {
        int len, common = 0;
        bool flag = true;
        int i = 0, j = 0;

        len = a.Length * b.Length;
        while (flag)
        {
            if (a[i] == b[j])
            {
                common = a[i];
                flag = false;
            }
            else
                i++;

            if (i == a.Length)
            {
                i = 0;
                j++;
            }
        }

        return common;
    }


    static void Main()
    {
        int[] arr1 = { 2, 3, 5, 7, 11, 13, 17, 19 };
        int[] arr2 = { 1, 4, 7, 9, 12, 15, 16, 17 };

        int commonDigit;

        commonDigit = GetTwoArray(arr1, arr2);

        Console.WriteLine(commonDigit);

        Console.ReadKey();
    }
}