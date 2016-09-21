using System;

class Program
{
    static int SumOfBelowOfMatrixDiagonal(int[,] m)
    {
        int sum = 0;

        for (int j = 0; j < m.GetLength(1) - 1; j++)
        {
            for (int i = 1 + j; i < m.GetLength(0); i++)
            {
                sum += m[i, j];
            }
        }
        //for (int i = 1; i < m.GetLength(1); i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {
        //        sum += m[i, j];
        //    }
        //}

        return sum;
    }

    static void Main()
    {
        int sum;
        int[,] m =
        {
            { 8, 2, 7, 3, 6 },      // | 0 | 0 | 0 | 0 | 0 |
            { 1, 1, 2, 3, 4 },      // | 1 | 0 | 0 | 0 | 0 |
            { 1, 8, 9, 4, 5 },      // | 1 | 8 | 0 | 0 | 0 |
            { 8, 7, 6, 5, 5 },      // | 8 | 7 | 6 | 0 | 0 |
            { 2, 7, 3, 6, 4 }       // | 2 | 7 | 3 | 6 | 0 |
        };

        sum = SumOfBelowOfMatrixDiagonal(m);
        Console.WriteLine("sum = {0}", sum);

        Console.ReadKey();
    }
}