using System;

class Program
{
    static void SelectionSrot(int[] a)
    {
        int temp, pmin;

        for (int i = 0; i < a.Length - 1; i++)
        {
            pmin = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] < a[pmin]) // מציאת את האינדקס של האיבר הקטן ביותר במערך
                    pmin = j;   // שמירת האינדקס במשתנה הזמני של האיבר הקטן ביותר
            }

            temp = a[i];
            a[i] = a[pmin];
            a[pmin] = temp;
        }
    }

    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("{0,4}", a[i]);
        }
    }

    static void Main()
    {
        int[] a = new int[5] { 23, 15, 6, 7, 30 };

        Console.WriteLine("Before sorting");
        Print(a);

        SelectionSrot(a);

        Console.WriteLine("\n\nAfter sorting");
        Print(a);

        Console.ReadKey();
    }
}