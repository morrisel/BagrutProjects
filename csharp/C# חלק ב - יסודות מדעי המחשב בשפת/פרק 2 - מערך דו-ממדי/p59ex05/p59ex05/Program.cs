using System;

class Program
{
    const int N = 5;

    static bool EqualCross(int[,] m)
    {
        for (int i = 0; i < N; i++)
        {
            if (m[i, i] != m[i, N - i - 1])
                return false;
        }

        return true;
    }
    static bool EqualCross2(int[,] m)
    {
        int temp1 = 0, temp2 = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j)
                    temp1 = m[i, j];

                if (i + j == N - 1)
                    temp2 = m[i, j];
            }

            if (temp1 != temp2)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] m =
        { 
            { 3, 0, 9, 1, 3 },
            { 8, 7, 1, 7, 3 },
            { 3, 0, 6, 1, 3 },
            { 3, 4, 9, 4, 3 },
            { 5, 0, 9, 1, 5 }
        };

        bool valid;

        valid = EqualCross(m);

        Console.WriteLine(valid);

        valid = EqualCross2(m);
        Console.WriteLine(valid);

        Console.ReadKey();
    }
}