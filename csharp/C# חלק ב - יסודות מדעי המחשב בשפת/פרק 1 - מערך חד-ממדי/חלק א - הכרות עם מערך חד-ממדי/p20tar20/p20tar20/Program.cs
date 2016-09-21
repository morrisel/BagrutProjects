using System;

class Program
{
    const int TOP = 10;

    static void Main()
    {
        int[] a = { 15, 6, 12, 3, 9, 0, 24, 21, 18, 20 };
        int[] b = { 13, 7, 3, 5, 2, 17, 11, 19, 23, 29 };
        int[] c = new int[TOP];

        int temp;

        Console.WriteLine("Printing the original - arrays a[] and b[]");
        Console.Write("array a[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", a[i]);

        Console.Write("\n\narray b[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", b[i]);

        Console.WriteLine("\n\n" + new string('-', 50));

        ///////////////////////////////////////////////////////////////////////////
        //------------------------------------ a מיון על המערך
        for (int i = 0; i < TOP; i++)
        {
            for (int j = 0; j < TOP - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        //------------------------------------ b מיון על המערך
        for (int i = 0; i < TOP; i++)
        {
            for (int j = 0; j < TOP - 1; j++)
            {
                if (b[j] > b[j + 1])
                {
                    temp = b[j];
                    b[j] = b[j + 1];
                    b[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Printing the ordered - arrays a[] and b[]");
        Console.Write("array a[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", a[i]);

        Console.Write("\n\narray b[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", b[i]);

        Console.WriteLine("\n\n" + new string('-', 50));

        ///////////////////////////////////////////////////////////////////////////
        //-------------------------- a הפיכת סדר של מערך
        for (int i = 0; i < TOP / 2; i++)
        {
            temp = a[i];
            a[i] = a[TOP - i - 1];
            a[TOP - i - 1] = temp;
        }

        //-------------------------- b הפיכת סדר של מערך
        for (int i = 0; i < TOP / 2; i++)
        {
            temp = b[i];
            b[i] = b[TOP - i - 1];
            b[TOP - i - 1] = temp;
        }

        Console.WriteLine("Printing the reversed - arrays a[] and b[]");
        Console.Write("array a[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", a[i]);

        Console.Write("\n\narray b[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", b[i]);

        Console.WriteLine("\n\n" + new string('-', 50));

        ///////////////////////////////////////////////////////////////////////////
        //-------------------------- b-ו a מציאת ערכים הגדולים ביותר בין שני המערכים
        //-------------------------- c והשמתם לתוך מערך חדש
        for (int i = 0; i < TOP; i++)
        {
            if (a[i] > b[i])
            {
                c[i] = a[i];
            }
            else
            {
                if (a[i] == b[i])
                    c[i] = 0;
                c[i] = b[i];
            }
        }

        Console.WriteLine("Printing a new array c[] with biggest values from a[] and b[] arrays");
        Console.Write("array a[#] ");
        for (int i = 0; i < TOP; i++)
            Console.Write("{0,3}", c[i]);

        Console.ReadKey();
    }
}