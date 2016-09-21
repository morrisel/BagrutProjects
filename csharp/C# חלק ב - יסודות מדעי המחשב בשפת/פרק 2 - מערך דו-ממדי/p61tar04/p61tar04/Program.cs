using System;

class Program
{
    // קלט: מערך דו ממדי
    // פלט: המתודה מחזירה אמת אם כל איבריה באלכסון הראשי הם אחדות, אחרת שקר
    // Find if all elements of the main diagonal is equals to 1
    static bool IsMatrixDiagonalEqualOnesDigits(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
            if (m[i, i] != 1)
                return false;

        return true;
    }

    // קלט: מערך דו ממדי
    // פטל: המתודה מחזירה אמת עם כל האיברים מעל האלכסון הראשי הם אפסים, אחרת שקר
    // Find if all elements above the main diagonal of matrix is equals to 0
    static bool IsAboveMatrixDiagonalEqualsZero(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0) - 1; i++)
            for (int j = 1 + i; j < m.GetLength(1); j++)
                if (m[i, j] != 0)
                    return false;

        return true;
    }

    // קלט: מערך דו ממדי
    // פלט: המתודה מחזירה אמת אם כל האיברים מתחת לאלכסון הראשי הם אפסים, אחרת שקר
    // Find if all elements below the main diagonal of matrix is equals to 0
    static bool IsBelowMatrixDiagonalEqualsZero(int[,] m)
    {
        for (int j = 0; j < m.GetLength(1) - 1; j++)
            for (int i = 1 + j; i < m.GetLength(0); i++)
                if (m[i, j] != 0)
                    return false;

        return true;
    }


    static void Main()
    {
        bool diagonal, aboveDiagonal, belowDiagonal;

        //int[,] m =
        //{
        //    { 8, 2, 7, 3, 6 },
        //    { 1, 1, 2, 3, 4 },
        //    { 1, 8, 9, 4, 5 },
        //    { 8, 7, 6, 5, 5 },
        //    { 2, 7, 3, 6, 4 }
        //};

        int[,] m =
        {
            { 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1 }
        };

        diagonal = IsMatrixDiagonalEqualOnesDigits(m);
        aboveDiagonal = IsAboveMatrixDiagonalEqualsZero(m);
        belowDiagonal = IsBelowMatrixDiagonalEqualsZero(m);

        if (diagonal && aboveDiagonal && belowDiagonal)
            Console.WriteLine("matrix homogen");
        else
            Console.WriteLine("matrix not homogen");
        

        Console.ReadKey();
    }
}