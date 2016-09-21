using System;

class Program
{
    static int[,] CornerOfSquare(int[,] mat)
    {
        int[,] tempTable = new int[mat.GetLength(0), mat.GetLength(1)];

        int bottom = mat.GetLength(0) - 1;
        int right = mat.GetLength(1) - 1;

        if ((mat[0, 0] > mat[0, 1]) &&
            (mat[0, 0] > mat[1, 1]) &&
            (mat[0, 0] > mat[1, 0]))
            tempTable[0, 0] = mat[0, 0];

        if ((mat[0, right] > mat[0, 1]) &&
            (mat[0, right] > mat[1, 1]) &&
            (mat[0, 0] > mat[1, 0]))
            tempTable[0, 0] = mat[0, 0];

        if ((mat[0, 0] > mat[0, 1]) &&
            (mat[0, 0] > mat[1, 1]) &&
            (mat[0, 0] > mat[1, 0]))
            tempTable[0, 0] = mat[0, 0];

        if ((mat[0, 0] > mat[0, 1]) &&
            (mat[0, 0] > mat[1, 1]) &&
            (mat[0, 0] > mat[1, 0]))
            tempTable[0, 0] = mat[0, 0];

        return tempTable;
    }

    static void PerimeterOfSquare(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if ((i == 0 && j == 0) || (i == 0 && j == mat.GetLength(1) - 1) ||
                    (i == mat.GetLength(0) - 1 && j == 0) || (i == mat.GetLength(0) - 1 && j == mat.GetLength(1) - 1))
                {
                    CornerOfSquare(mat);
                }
                else
                {

                }
            }
        }
    }

    static void FindSmallestNeighbors(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                // רץ על ההיקף של הריבוע
                if (i == 0 || i == mat.GetLength(0) - 1 || j == 0 || j == mat.GetLength(1) - 1)
                {
                    PerimeterOfSquare(mat);
                }
                else
                {

                }
            }
        }
    }


    private static bool IsLocalMax(int[,] a, int i, int j)
    {
        bool rightBound = i == a.GetLength(0) - 1;
        bool botBound = j == a.GetLength(1) - 1;

        int val = a[i, j];

        bool horisIsOk = (i == 0 || a[i - 1, j] < val) && (rightBound || a[i + 1, j] < val);

        bool vertIsOk = (j == 0 || a[i, j - 1] < val) && (botBound || a[i, j + 1] < val);

        bool leftDiagIsOk = (i == 0 || (j == 0 || a[i - 1, j - 1] < val) && (botBound || a[i - 1, j + 1] < val));

        bool rightDiagIsOk = (rightBound || (j == 0 || a[i + 1, j - 1] < val) && (botBound || a[i + 1, j + 1] < val));


        return horisIsOk && vertIsOk && leftDiagIsOk && rightDiagIsOk;
    }


    static void Main()
    {
        int[,] mat =
        {
            { 480, 345, 230, 320, 200 },
            { 420, 300, 200, 400, 200 },
            { 333, 444, 500, 410, 250 },
            { 366, 488, 313, 276, 499 },
            { 400, 200, 200, 300, 430 }
        };

        //FindSmallestNeighbors(mat);

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (IsLocalMax(mat, i, j))
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, mat[i, j]);
            }
        }


        Console.ReadKey();
    }
}