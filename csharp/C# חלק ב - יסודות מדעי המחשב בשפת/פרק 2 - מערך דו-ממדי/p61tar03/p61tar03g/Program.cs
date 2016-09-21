using System;

class Program
{
    static int SumOfSecondaryDiagonal(int[,] m)
    {
        int sum = 0;
        int x, y;

        for (int i = m.GetLength(0) - 1; i >= 0; i--)
        {
            x = m.GetLength(0) - i - 1;
            y = i;

            sum += m[m.GetLength(0) - i - 1, i];
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

        sum = SumOfSecondaryDiagonal(m);
        Console.WriteLine("sum = {0}", sum);

        Console.ReadKey();
    }
}