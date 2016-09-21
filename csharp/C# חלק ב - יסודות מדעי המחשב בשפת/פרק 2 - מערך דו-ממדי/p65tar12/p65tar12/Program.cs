using System;

class Program
{
    const int N = 3;

    static void MultiplyMatrix(int[,] A, int[,] B, int[] arr)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                arr[i] += A[i, j] * B[j, i];
            }
        }
    }

    static void PrintOneDimensionArray(int[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            Console.WriteLine("{0,4}", arr[i]);
        Console.WriteLine();
    }

    static void PrintTwoDimensionArray(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,4}", m[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[,] m1 = new int[N, N] { { 7, 5, 1 }, { 2, 3, 0 }, { 4, 2, 3 } };
        int[,] m2 = new int[N, N] { { 6, 2, 2 }, { 1, 8, 6 }, { 3, 0, 1 } };
        int[] arr = new int[N];

        Console.WriteLine("Print the arrays before multiply");
        PrintTwoDimensionArray(m1);
        PrintTwoDimensionArray(m2);
        PrintOneDimensionArray(arr);
        Console.WriteLine("---------------------------------------");

        MultiplyMatrix(m1, m2, arr);

        PrintOneDimensionArray(arr);

        Console.ReadKey();
    }
}