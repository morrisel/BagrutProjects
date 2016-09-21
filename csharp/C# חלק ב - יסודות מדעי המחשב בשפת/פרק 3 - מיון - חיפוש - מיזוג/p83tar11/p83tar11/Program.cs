using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static int BinarySearchForDescendingArray(int[] a, int value, int start, int last)
    {
        int middle, low, hight;

        low = start;
        hight = last;

        while (low <= hight)
        {
            middle = (low + hight) / 2;

            if (value == a[middle])
                return middle;
            else
            {
                if (value > a[middle])
                    hight = middle - 1;
                else
                    low = middle + 1;
                
            }
        }


        return -1;
    }

    static int BinarySearchForAscendingArray(int[] a, int value, int start, int last)
    {
        int middle;

        while (start <= last)
        {
            middle = (start + last) / 2;

            if (value == a[middle])
                return middle;
            else
            {
                if (value < a[middle])
                    last = middle - 1;
                else
                    start = middle + 1;
            }
        }

        return -1;
    }

    static void SelectionSort(int[] a)
    {
        int temp, pmin;

        for (int i = 0; i < a.Length - 1; i++)
        {
            pmin = i;

            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] < a[pmin])
                {
                    pmin = j;
                }
            }

            temp = a[i];
            a[i] = a[pmin];
            a[pmin] = temp;
        }
    }

    static void Main()
    {
        // א. עבור מערך ממוין
        int[] a1 = { 98, 95, 92, 90, 80, 75, 70, 60, 30, 23, 15, 12, 6, 3, 1 };
        int value, start, last;
        int answer;

        Print(a1);

        Console.Write("Enter a value for find it: ");
        value = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for from: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for up to: ");
        last = int.Parse(Console.ReadLine());

        Console.WriteLine("finding the index ...");

        answer = BinarySearchForDescendingArray(a1, value, start, last);

        Console.WriteLine("The index of falue {0} is: {1}", value, answer);
        Console.WriteLine("\n");

        // ב. עבור מערך לא ממוין
        int[] a2 = { 3, 92, 80, 75, 70, 60, 30, 23, 90, 15, 12, 95, 6, 98, 1 };

        Console.WriteLine("The array a2 before sorting is: ");
        Print(a2);

        // а2 נמיין את המערך
        SelectionSort(a2);
        Console.WriteLine("The array a2 before sorting is: ");
        Print(a2);

        Console.Write("Enter a value for find it: ");
        value = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for from: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for up to: ");
        last = int.Parse(Console.ReadLine());

        Console.WriteLine("finding the index ...");

        answer = BinarySearchForAscendingArray(a2, value, start, last);

        Console.WriteLine("The index of falue {0} is: {1}", value, answer);

        Console.ReadKey();
    }
}