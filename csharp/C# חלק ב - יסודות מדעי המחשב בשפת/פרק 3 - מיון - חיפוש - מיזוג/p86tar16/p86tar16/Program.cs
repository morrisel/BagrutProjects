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

    static int[] Merge(int[] a, int[] b)
    {
        int indx1 = 0, indx2 = 0, indx3 = 0;
        int[] c = new int[a.Length + b.Length];

        while (indx1 < a.Length && indx2 < b.Length)
        {
            if (a[indx1] < b[indx2])
            {
                c[indx3] = a[indx1];
                indx1++;
            }
            else
            {
                c[indx3] = b[indx2];
                indx2++;

                while (a[indx1] == b[indx2])
                    indx1++;

                while (b[indx2] == b[indx2 - 1])
                    indx2++;
            }
            indx3++;
        }

        while (indx1 < a.Length)
        {
            c[indx3] = a[indx1];
            indx1++;
            indx3++;
        }

        while (indx2 < b.Length)
        {
            c[indx3] = b[indx2];
            indx2++;
            indx3++;
        }

        return c;
    }

    static void Main()
    {
        int[] a = { 2, 5, 5, 17 };
        int[] b = { 1, 3, 4, 4, 5, 5, 10, 20 };
        int[] c;

        c = Merge(a, b);

        Console.ReadKey();
    }
}