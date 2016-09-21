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

    static int[] Merge(int[] a, int[] b, int[] c)
    {
        int aind = 0, bind = 0, cind = 0, dind = 0;
        int[] d = new int[a.Length + b.Length + c.Length];

        // c-ו b ,a כאן מתבצע חיפוש והשמה של האיברים על החיתוך בין שלושת המערכים
		while (aind < a.Length && bind < b.Length && dind < c.Length)
        {
            if (a[aind] < b[bind] && a[aind] < c[dind] ||
                a[aind] < b[bind] && b[aind] < c[dind])
            {
                d[dind] = a[aind];
                aind++;
            }
            else
            {
                if (b[bind] < c[cind])
                {
                    d[dind] = b[bind];
                    bind++;
                }
                else
                {
                    d[dind] = c[cind];
                    cind++;
                }

                while (a[aind] == b[bind] || a[aind] == c[cind])
                    aind++;

                while (b[bind] == c[cind])
                    bind++;

                if (bind != 0)
                    while (b[bind] == b[bind - 1])
                        bind++;
                if (cind != 0)
                    while (c[cind] == c[cind - 1])
                        cind++;
            }
            dind++;
        }

        // b-ו a כאן מתבצע חיפוש והשמה של האיברים של החיתוך בין שני המערכים
        while (aind < a.Length && bind < b.Length)
        {
            if (a[aind] < b[bind])
            {
                d[dind] = a[aind];
                aind++;
            }
            else
            {
                d[dind] = b[bind];
                bind++;
                while (a[aind] == b[bind]) aind++;
                while (b[bind] == b[bind - 1]) bind++;
            }
            dind++;
        }
        // c-ו a כאן מתבצע חיפוש והשמה של האיברים של החיתוך בין שני המערכים
        while (aind < a.Length && cind < c.Length)
        {
            if (a[aind] < c[cind])
            {
                d[dind] = a[aind];
                aind++;
            }
            else
            {
                d[dind] = c[cind];
                cind++;
                while (a[aind] == c[cind]) aind++;
                while (c[cind] == b[cind - 1]) cind++;
            }
            dind++;
        }
        // c-ו b כאן מתבצע חיפוש והשמה של האיברים של החיתוך בין שני המערכים
        while (bind < b.Length && cind < c.Length)
        {
            if (b[bind] < c[cind])
            {
                d[dind] = b[bind];
                bind++;
            }
            else
            {
                d[dind] = c[cind];
                cind++;
                while (b[bind] == c[cind]) bind++;
                while (c[cind] == b[cind - 1]) cind++;
            }
            dind++;
        }

        // a כאן מתבצע חיפוש והשמה של האיברים שנשארו במערך
        while (aind < a.Length)
        {
            d[dind] = a[aind];
            aind++;
            dind++;
        }
        // b כאן מתבצע חיפוש והשמה של האיברים שנשארו במערך
        while (bind < b.Length)
        {
            d[dind] = b[bind];
            bind++;
            dind++;
        }
        // c כאן מתבצע חיפוש והשמה של האיברים שנשארו במערך
        while (cind < c.Length)
        {
            d[dind] = c[cind];
            cind++;
            dind++;
        }

        return d;
    }

    static void Main()
    {
        int[] a = { 3, 5, 15 };
        int[] b = { 2, 5, 5, 17 };
        int[] c = { 1, 3, 4, 4, 5, 5, 10, 20 };
        int[] d;

        d = Merge(a, b, c);

        Console.ReadKey();
    }
}