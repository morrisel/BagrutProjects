using System;

class Program
{
    static int SumOfAboveMainDiagonal(int[,] m)
    {
        int sum = 0;

        for (int i = 0; i < m.GetLength(0) - 1; i++)
        {
            for (int j = 1 + i; j < m.GetLength(1); j++)
            {
                sum += m[i, j];
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

        sum = SumOfAboveMainDiagonal(m);
        Console.WriteLine("sum = {0}", sum);

        Console.ReadKey();
    }
}