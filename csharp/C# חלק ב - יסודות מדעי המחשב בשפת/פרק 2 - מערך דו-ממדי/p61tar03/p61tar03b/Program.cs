using System;

class Program
{
    public static void PrintByCol(int[,] m)
    {
        int[] sum = new int[m.GetLength(0)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,4}", m[i, j]);
                sum[i] += m[j, i];
            }

            Console.WriteLine("\n");
        }

        for (int i = 0; i < sum.Length; i++)
            Console.Write("{0,4}", sum[i]);
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

        PrintByCol(m);

        Console.ReadKey();
    }
}