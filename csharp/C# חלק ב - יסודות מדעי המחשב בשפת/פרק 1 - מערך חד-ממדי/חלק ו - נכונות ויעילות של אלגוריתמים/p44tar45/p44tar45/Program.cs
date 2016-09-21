using System;

class Program
{

    static bool GetArrAndNum(int[] a, int n)
    {
        bool isFind = false;

        for (int i = 0; i < a.Length; i++)
            if (a[i] == n)
                isFind = true;

        return isFind;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 5, 7, 11, 13, 17, 19 };
        int num = 9;
        bool find;

        find = GetArrAndNum(arr, num);

        if (find)
            Console.WriteLine("The " + num + " number in array");
        else
            Console.WriteLine("The " + num + " number isn't in array");

        Console.ReadKey();
    }
}