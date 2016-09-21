using System;

class Program
{
    /* טענט כניסה: הפעלה מקבלת כפרטמטר מערך דו-ממדי */
    /* טענת יציאה: הפעולה מחזירה סכום כל האיברים שמעל לאלכסון הראשי */
    static int UpperSumOfMainDiagonal(int[,] m)
    {
        int sum = 0;

        for (int row = 0; row < m.GetLength(0); row++)
        {
            for (int col = row + 1; col < m.GetLength(1); col++)
            {
                sum += m[row, col];
            }
        }

        return sum;
    }

    /* טענט כניסה: הפעלה מקבלת כפרטמטר מערך דו-ממדי */
    /* טענת יציאה: הפעולה מחזירה סכום כל האיברים שמתחת לאלכסון הראשי */
    static int LowerSumOfMainDiagonal(int[,] m)
    {
        int sum = 0;

        for (int row = 1; row < m.GetLength(0); row++)
        {
            for (int col = 0; col < row; col++)
            {
                sum += m[row, col];
            }
        }

        return sum;
    }

    /* טענט כניסה: הפעלה מקבלת כפרטמטר מערך דו-ממדי */
    /* טענת יציאה: הפעולה מחליפה את האיברים שמעל לאלכסון הראשי באיברים שמתחת לאלכסון הראשי */
    static void ChangingElements(int[,] m)
    {
        int temp;

        for (int row = 0; row < m.GetLength(0); row++)
        {
            for (int col = row; col < m.GetLength(1); col++)    // העמודה תקבל ערך של שורה
            {
                temp = m[row, col];
                m[row, col] = m[col, row];
                m[col, row] = temp;
            }
        }
    }

    static void Print(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,4}", m[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int upperSum, lowerSum;
        int[,] m =
        {
            { 1, 2, 3, 4 },         // 1   2  3  4
            { 5, 6, 7, 8 },         // 5   6  7  8
            { 9, 10, 11, 12 },      // 9  10 11 12
            { 13, 14, 15, 16 }      // 13 14 15 16
        };

        Console.WriteLine("Before changing");
        Print(m);

        // החלפת האיברים מעל לאלכסון הראשי
        ChangingElements(m);

        Console.WriteLine("\nAfter changing");
        Print(m);

        // סכום מעל לאלכסון הראשי
        upperSum = UpperSumOfMainDiagonal(m);

        // סכום מתחת לאלכסון הראשי
        lowerSum = LowerSumOfMainDiagonal(m);

        Console.WriteLine("sum of upper the main diagonal of matrix is: {0}", upperSum);

        Console.WriteLine("sum of lower the main diagonal of matrix is: {0}", lowerSum);

        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("If sum of above more than below the main diagonal of matrix change the elements");

        Console.WriteLine("Before changing");
        Print(m);

        Console.WriteLine("Press any key...");

        Console.ReadKey();

        if (upperSum > lowerSum)
            ChangingElements(m);

        Console.WriteLine("\nAfter changing");
        Print(m);


        Console.ReadKey();
    }
}