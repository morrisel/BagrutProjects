using System;

class Program
{
    const int N = 3;

    public static void PrintByRow(int[,] m)
    {
        int sum = 0;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,4}", m[i, j]);
                sum += m[i, j];
            }
            Console.Write(" : sum = {0}\n\n", sum);
            sum = 0;
        }
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


        PrintByRow(m);

        Console.ReadKey();
    }
}