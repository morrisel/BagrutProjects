using System;

// א. קלט והחזרה של מערך
// ב. הדפסת מערך
// ג. חישוב והחזרה של סכום אברי מערך
// ד. חישוב והחזרה של ממוצע אברי מערך
// ה. חישוב ומחזרה של הערך המקסימלי במערך
// ו. מיון מערך

/* מחלקת שירות עבור מערך של שלמים */
class MyIntArr
{
    /* טענת יציאה: הפעולה קולטת גודל למערך, בונה אותו, קולטת לתוכו ערכים ומחזירה אותו */
    public static int[] Read()
    {
        int n;
        int[] a;

        Console.Write("Enter array size: ");
        n = int.Parse(Console.ReadLine());

        a = new int[n];

        Console.WriteLine("Enter array values");
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        return a;
    }

    /* a טענת כניסה: הפעולה מקבלת מערך */
    /* טענת יציאה: הפעולה מדפיסה את ערכי המערך בשורה אחת */
    public static void Write(int[] a)
    {
        Console.WriteLine("The array values are:");
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);
        Console.WriteLine();
    }

    /* a טענת כניסה: הפעולה מקבלת מערך */
    /* טענת יציאה: הפעולה מחשבת ומחזירה את סכום אברי המערך */
    public static int Sum(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
            sum += a[i];

        return sum;
    }

    /* a טענת כניסה: הפעולה מקבלת מערך */
    /* טענת היציאה: הפעולה מחשבת ומחזירה את ממוצע אברי המערך */
    public static double Average(int[] a)
    {
        double avg = 0.0;

        avg = (double)Sum(a) / a.Length;

        return avg;
    }

    /* a טענת כניסה: הפעולה מקבלת מערך */
    /* טענת יציאה: הפעולה מחשבת ומחזירה את הערך המקסימלי בין אברי המערך */
    public static int Max(int[] a)
    {
        int max = a[0];

        for (int i = 1; i < a.Length; i++)
            if (max < a[i]) max = a[i];

        return max;
    }

    /* a טענת כניסה: הפעולה מקבלת מערך */
    /* הפעולה ממיינת את המערך */
    public static void Sort(int[] a)
    {
        int temp, p;

        for (int i = 0; i < a.Length - 1; i++)
        {
            p = i;
            for (int j = i + 1; j < a.Length; j++)
                if (a[j] < a[p])
                    p = j;
            
            if (p != i)
            {
                temp = a[i];
                a[i] = a[p];
                a[p] = temp;
            }
        }
    }
}

// א. קלט והחזרה של מערך
// ב. הדפסת מערך
// ג. חישוב והחזרה של סכום אברי מערך
// ד. חישוב והחזרה של ממוצע אברי מערך
// ה. חישוב ומחזרה של הערך המקסימלי במערך
// ו. מיון מערך
class Ch4Solve1TestMyIntArr
{
    static void Main()
    {
        int[] a = MyIntArr.Read();

        MyIntArr.Write(a);
        Console.WriteLine("The array sum is: " + MyIntArr.Sum(a));
        Console.WriteLine("The array average is: " + MyIntArr.Average(a));
        Console.WriteLine("The maximum value in array is: " + MyIntArr.Max(a));

        MyIntArr.Sort(a);
        Console.WriteLine("The sorted array is: ");
        MyIntArr.Write(a);

        Console.WriteLine("Hello");
        Console.ReadKey();
    }
}