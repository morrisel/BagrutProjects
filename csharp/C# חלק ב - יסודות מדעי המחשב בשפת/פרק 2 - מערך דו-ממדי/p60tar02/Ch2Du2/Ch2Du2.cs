using System;

class Ch2Du2
{
    const int N = 4;

    static void Init(int[,] m)
    {
        int num = 1;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = num;
                    num++;
                }
            }
            else
            {
                for (int j = m.GetLength(1) - 1; j >= 0; j--)
                {
                    m[i, j] = num;
                    num++;
                }
            }
        }
    }

    static void Main()
    {
        int[,] m = new int[N, N];

        Init(m);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write("{0,3}", m[i, j]);
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}