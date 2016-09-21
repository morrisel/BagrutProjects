using System;

class Ch2Du1
{
    const int N = 4;
    static void Main()
    {
        char[,] m = new char[N, N];

        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                m[i, j] = '*';

        char let = 'a';

        for (int i = 0; i < m.GetLength(0); i++)
        {
            m[i, i] = let;
            m[i, m.GetLength(1) - i - 1] = let;
            let++;
        }

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }


        Console.ReadKey();
    }
}