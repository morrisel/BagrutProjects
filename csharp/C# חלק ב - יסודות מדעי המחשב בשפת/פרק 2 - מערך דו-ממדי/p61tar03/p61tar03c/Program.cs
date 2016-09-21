using System;

class Program
{
    static int PrintAround(int[,] m)
    {
        int sum = 0;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (i == 0 || j == 0)
                {
                    sum += m[i, j];
                }
                else
                {
                    sum = sum + m[i, m.GetLength(0) - 1] + m[m.GetLength(1) - 1, j];

                    if (i == 4 && j == 4)
                        sum = sum - m[i, j];

                    i++;
                }
            }
        }

        return sum;
    }

    static void Main()
    {
        int[,] m =
        {
            { 8, 2, 7, 3, 6 },
            { 1, 1, 2, 3, 4 },
            { 1, 8, 9, 4, 5 },
            { 8, 7, 6, 5, 5 },
            { 2, 7, 3, 6, 4 }
        };

        int sum = PrintAround(m);

        Console.WriteLine("sum is = {0}", sum);

        Console.ReadKey();
    }
}