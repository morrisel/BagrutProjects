using System;

class Program
{
    // קלט: הפעולה מקבלת מערך דו ממדי ומחשבת סכום האלכסון הראשי
    // פלט: הפעול מחזירה סוכם האלכסון הראשי
    static int SumOfMainDiagonalMatrix(int[,] m)
    {
        int sum = 0;

        for (int i = 0; i < m.GetLength(0); i++)
            sum += m[i, i];

        return sum;
    }

    // קלט: הפעולה מקבלת מערך דו ממדי ומחשבת סכום האלכסון המשני
    // פלט: הפעולה מחזירה סכום האלכסון המשני
    static int SumOfSecondaryDiagonalMatrix(int[,] m)
    {
        int sum = 0;

        for (int i = m.GetLength(0) - 1; i >= 0; i--)
            sum += m[m.GetLength(0) - i - 1, i];

        return sum;
    }

    // קלט: הפעולה מקבלת מערך דו ממדי
    // פלט: הפעולה מחזירה אמת אם סכום כל האיברים של כל שורה שווים זה לזה, או שקר אחר
    static bool IsEqualsRows(int[,] m)
    {
        int sum = 0;
        int[] row = new int[m.GetLength(1)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                sum += m[i, j];

            row[i] = sum;
            sum = 0;
        }

        for (int i = 1; i < row.Length; i++)
            if (row[i - 1] != row[i])
                return false;

        return true;
    }

    // קלט: הפעולה מקבלת מערך דו ממדי
    // פלט: הפעולה מחזירה אמת אם סכום כל האיברים של כל העמודה שווים זה לזה, או שקר אחר
    static bool IsEqualsColumns(int[,] m)
    {
        int sum = 0;
        int[] col = new int[m.GetLength(0)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                sum += m[j, i];

            col[i] = sum;
            sum = 0;
        }

        for (int i = 1; i < col.Length; i++)
            if (col[i - 1] != col[i])
                return false;

        return true;
    }


    static void Main()
    {
        int[,] m =
        {
            { 2, 9, 4 },
            { 7, 5, 3 },
            { 6, 1, 8 }
        };

        int d1, d2;
        bool rows, cols;

        d1 = SumOfMainDiagonalMatrix(m);
        d2 = SumOfSecondaryDiagonalMatrix(m);
        rows = IsEqualsRows(m);
        cols = IsEqualsColumns(m);

        if (d1 == d2 && rows && cols)
        {
            Console.WriteLine("Ribua Kesem");
        }
        else
        {
            Console.WriteLine("Rubua lo-Kesem");
        }


        Console.ReadKey();
    }
}