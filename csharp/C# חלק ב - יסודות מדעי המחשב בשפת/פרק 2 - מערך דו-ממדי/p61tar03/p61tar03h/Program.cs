using System;

class Program
{
    static int SumOfBelowOfSecondMatrixDiagonal(int[,] m)
    {
        int sum = 0;
        // | 0 | 0 | 0 | 0 | 0 |
        // | 0 | 0 | 0 | 0 | 4 |
        // | 0 | 0 | 0 | 4 | 5 |
        // | 0 | 0 | 6 | 5 | 5 |
        // | 0 | 7 | 3 | 6 | 4 |
        for (int i = m.GetLength(0) - 1; i > 0; i--)
        {
            for (int j = m.GetLength(1) - i; j < m.GetLength(1); j++)
            {
                sum += m[j, i];
            }
        }

        return sum;
    }

    static void Main()
    {
        int sum;
        int[,] m =
        {
            { 8, 2, 7, 3, 6 },
            { 1, 1, 2, 3, 4 },
            { 1, 8, 9, 4, 5 },
            { 8, 7, 6, 5, 5 },
            { 2, 7, 3, 6, 4 }
        };

        sum = SumOfBelowOfSecondMatrixDiagonal(m);
        Console.WriteLine("sum = {0}", sum);

        Console.ReadKey();
    }
}