using System;

class Program
{
    const int N = 3, M = 4;


    static void BubbleSortByDescending(int[,] mat)
    {
        int temp;

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = mat.GetLength(1) - 1; j >= 0; j--)
            {
                for (int k = mat.GetLength(1) - 2; k >= 0; k--)
                {
                    if (mat[i, k + 1] > mat[i, k])
                    {
                        temp = mat[i, k];
                        mat[i, k] = mat[i, k + 1];
                        mat[i, k + 1] = temp;
                    }
                }
            }
        }
    }

    static void Print(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,4}", mat[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] mat = new int[N, M];
        Random rnd = new Random();

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = rnd.Next(20);
            }
        }

        Console.WriteLine("Before bubble sorting");
        Print(mat);

        BubbleSortByDescending(mat);

        Console.WriteLine("\nAfter bubble sorting");
        Print(mat);

        Console.ReadKey();
    }
}