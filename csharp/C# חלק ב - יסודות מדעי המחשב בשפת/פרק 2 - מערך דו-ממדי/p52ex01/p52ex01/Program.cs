using System;

class Program
{
    const int N = 8;

    static void Main()
    {
        char[,] board = new char[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if ((i + j) % 2 == 0)
                    board[i, j] = 'b';
                else
                    board[i, j] = 'w';
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}