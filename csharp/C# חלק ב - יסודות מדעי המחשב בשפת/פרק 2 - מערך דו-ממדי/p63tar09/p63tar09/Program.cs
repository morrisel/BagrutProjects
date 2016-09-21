using System;

class Program
{
    const int N = 3;

    static bool Check1(int[,] m, int[] a)
    {
        int i = 0, j;

        //// שגיאה: לולאה אינסופית
        //while (i < m.GetLength(0))
        //{
        //    j = 0;
        //    while (a[j] == m[i, j] && j < m.GetLength(1) - 1)
        //    {
        //        j++;
        //    }

        //    if (j == m.GetLength(1))
        //        return true;
        //}

        while (i < m.GetLength(0))
        {
            j = 0;
            while (a[j] == m[i, j] && j < m.GetLength(1) - 1)
            {
                j++;
            }

            if ((j + 1) == m.GetLength(1))
                return true;

            i++;
        }

        return false;
    }

    static bool Check2(int[,] m, int[] a)
    {
        int i = 0, mone;

        while (i < m.GetLength(0))
        {
            mone = 0;

            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (a[j] == m[i, j])
                    mone++;
            }

            if (mone == m.GetLength(1))
                return true;
            else
                i++;
        }

        return false;
    }


    static void Main()
    {
        int[,] m = new int[N, N] { { 5, 4, 6 }, { 7, 3, 9 }, { 11, 2, 3 } };
        int[] a = new int[N] { 7, 3, 9 };
        bool flag1, flag2;

       

        flag1 = Check1(m, a);
        flag2 = Check2(m, a);

        Console.WriteLine("flag1 = Check1(m, a)# " + flag1);
        Console.WriteLine("flag2 = Check1(m, a)# " + flag2);

        Console.ReadKey();
    }
}