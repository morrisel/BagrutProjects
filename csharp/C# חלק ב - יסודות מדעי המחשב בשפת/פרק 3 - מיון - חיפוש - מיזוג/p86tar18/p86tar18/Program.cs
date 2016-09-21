using System;

// .פתח ויישם אלגוריתם המקבל כקלט שני מערכים ממוינים בסדר עולה ובהם יש איברים חוזרים
// .האלגוריתם מחזיר מערך ממוזג כך שכל איבר במערך המיזוג יופיע פעם אחת בלבד
class Program
{
    const int A = 3, B = 5, C = A + B;

    // printing the array
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write("{0,4}", arr[i]);

        Console.WriteLine();
    }

    // Sorting an elements by insertion sort
    static void InsertionSortAsc(int[] a)
    {
        int num;

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter a value: ");
            a[i] = int.Parse(Console.ReadLine());

            num = a[i];

            int j = 0;
            for (j = 0; j < i && a[j] < num; j++) ;

            for (int k = i; k > j; k--)
            {
                a[k] = a[k - 1];
            }

            a[j] = num;
        }

    }

    static int[] IntersectionMerge(int[] a, int[] b)
    {
        int[] arr = new int[Math.Min(a.Length, b.Length)];
        int i = 0, j = 0, k = 1;

        while (k - 1 < Math.Min(a.Length, b.Length))
        {
            if (b[j] == a[i])
            {
                arr[k - 1] = a[i];
                k++; i++; j++;
            }
            else
            {
                if (a.Length < b.Length)
                {
                    if (j != Math.Max(a.Length, b.Length) - 1)
                        j++;
                    else
                        break;
                }
                else
                {
                    if (i != Math.Max(a.Length, b.Length) - 1)
                        i++;
                    else
                        break;
                }
            }
        }

        return arr;
    }

    static void Main()
    {
        int[] a = { 3, 5, 15 };
        int[] b = { 2, 5, 5, 17 };
        int[] c = { 1, 3, 4, 4, 5, 5, 10, 20 };
        //int[] d = { 1, 3, 4, 4, 5, 5, 10, 20, 143, 234, 265, 432 };
        int[] arr;

        arr = IntersectionMerge(c, a);

        Print(arr);

        Console.ReadKey();
    }
}