using System;

/* מחלקת שירות עבור סדרה חשבונית */
class ArithmeticProgression
{
    public static int[] ElementsOfProgression(int a1, int d, int n)
    {
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = a1 + ((i + 1) - 1) * d;

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

    /* n ואת מספר השלם d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* האיברים הראשונים של הסדרה החשבונית n טענת יציאה: הפעולה מדפיסה את */
    public static void PrintAmountElements(int a1, int d, int n)
    {
        int[] a = new int[n];
        a = ElementsOfProgression(a1, d, n);
        //for (int i = 0; i < n; i++)
        //    a[i] = a1 + ((i + 1) - 1) * d;

        Write(a);
    }

    /* n ואת מספר השלם d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* י של הסדרה-n-טענת יציאה: הפעולה מחזירה את האיבר ה */
    public static int NumberOf_an(int a1, int d, int n)
    {
        int an;
        an = a1 + (n - 1) * d;

        return an;
    }

    /* n ואת מספר השלם d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* האיברים הראשונים של הסדרה החשבונית n טענת יציאה: הפעולה מדפיסה את */
    public static int SumOfProgression(int a1, int d, int n)
    {
        int sum = 0;
        int[] a = ElementsOfProgression(a1, d, n);

        for (int i = 0; i < n; i++)
            sum += a[i];

        return sum;
    }

    /* n ואת מספר השלם d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* האיברים הראשונים של הסדרה החשבונית n טענת יציאה: הפעולה מדפיסה את */
    public static void NumbersIsBetween(int a1, int d, int n1, int n2)
    {
        int len = 0, temp, n = 0;

        temp = n1;
        while (temp <= n2)    // n2-ל n1 מציאת אורך של מספר האיברים בין
        {
            len++;
            temp += d;
        }

        temp = n1;
        while (temp != a1)  // n1 מציאת אינדקס של המספר
        {
            n++;
            temp -= d;
        }


        int[] a = new int[len];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = NumberOf_an(a1, d, n + 1);
            n++;
            //n1 += d;
        }

        Write(a);
    }

    /* num ואת מספר d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* טענת יציאה: הפעולה מחזירה את מספר הסדורי של האיבר */
    public static int IndexOfNuber(int a1, int d, int num)
    {
        int n = 1;
        while (num != a1)  // n1 מציאת אינדקס של המספר
        {
            n++;
            num -= d;
        }
        return n;
    }

    /* num ואת מספר d את הפרש הסדרה ,a1 טענת כניסה: הפעולה מקבלת את האיבר הראשון של הסדרה */
    /* האיברים הראשונים של הסדרה החשבונית n טענת יציאה: הפעולה מדפיסה את */
    public static bool IsFind(int a1, int d, int num)
    {
        while (a1 < num)
        {
            num -= d;
            if (num == a1)
                return true;
        }

        return false;
    }
}

// א. קלט והחזרה של מערך
// ב. הדפסת מערך
// ג. חישוב והחזרה של סכום אברי מערך
// ד. חישוב והחזרה של ממוצע אברי מערך
// ה. חישוב ומחזרה של הערך המקסימלי במערך
// ו. מיון מערך
class Program
{
    static void Main()
    {
        int a1, d, n;
        int[] a;
        int num, sum, n1, n2;

        Console.Write("Enter a first number: a1 = ");
        a1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a difference: d = ");
        d = int.Parse(Console.ReadLine());
        Console.Write("Enter an amount: n = ");
        n = int.Parse(Console.ReadLine());

        // 1
        //ArithmeticProgression.PrintAmountElements(a1, d, n);

        // 2
        //num = ArithmeticProgression.NumberOf_an(a1, d, n);
        //Console.WriteLine("The num is: a[" + n + "] = " + num );

        // 3
        //sum = ArithmeticProgression.SumOfProgression(a1, d, n);
        //Console.WriteLine("The sum of arithmetic progression is: " + sum);

        // 4
        //Console.Write("Enter n1: ");
        //n1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter n2: ");
        //n2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Numbers of between n1-n2 is:");
        //ArithmeticProgression.NumbersIsBetween(a1, d, n1, n2);

        // 5
        //Console.Write("Enter a number of arithmetic progression: ");
        //num = int.Parse(Console.ReadLine());
        //Console.WriteLine("The index number of: " + num + " is: " + ArithmeticProgression.IndexOfNuber(a1, d, num));

        // 6
        Console.WriteLine("num " + n + " is: " + ArithmeticProgression.IsFind(a1, d, n));

        Console.ReadKey();
    }
}