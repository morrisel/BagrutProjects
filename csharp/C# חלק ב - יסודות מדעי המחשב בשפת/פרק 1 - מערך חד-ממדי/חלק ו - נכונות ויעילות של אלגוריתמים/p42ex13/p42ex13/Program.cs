using System;

class Program
{
    static bool Orly(int[] a)
    {
        int i = 1, count, j;
        bool flag = true, contin = true;

        while (i < a.Length - 1)
        {
            contin = true;
            count = 0;
            j = i;
            while (contin && i < a.Length - 1)
            {
                if (a[i] == a[i + 1])
                {
                    i++;
                    count++;
                }
                else
                {
                    contin = false;
                }
            }
            if (count > 0)
            {
                for (int k = j; k < i; k++)
                {
                    a[k] = 0;
                }
                flag = false;
            }
            i++;
        }

        return flag;
    }

    static bool Orr(int[] a)
    {
        bool flag = true;

        for (int i = 1; i < a.Length - 1; i++)
        {
            if (a[i] == a[i + 1])
            {
                a[i] = 0;
                flag = false;
            }
        }

        return flag;
    }


    static void Main()
    {
        int[] arrOrly = { 11, 2, 2, 3, 17, 5, 19, 7, 8, 9, 10 };
        int[] arrOrr = { 11, 2, 2, 3, 17, 5, 19, 7, 8, 9, 10 };
        bool b1, b2;

        b1 = Orly(arrOrly);
        b2 = Orr(arrOrr);

        Console.ReadKey();
    }
}