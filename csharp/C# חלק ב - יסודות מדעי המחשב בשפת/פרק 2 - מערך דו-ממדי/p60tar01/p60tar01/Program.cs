using System;

class Program
{
    const int ROW = 5, COL = 4;

    // 1
    static int[,] GetByRows(int[,] m)
    {
        Console.Write("Fill the matrix array\n");
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
        ////m[ROW, COL] = 5;
        //int[,] table = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
        //m = table;


        return m;
    }

    // 2
    static void PrintByColumn(int[,] m)
    {
        for (int i = 0; i < m.GetLength(1); i++)        // m.GetLength(1) = COL
        {
            for (int j = 0; j < m.GetLength(0); j++)    // m.GetLength(0) = ROW
            {
                Console.Write("{0,3} ", m[j, i]);
            }
            Console.WriteLine();
        }
    }
    static void PrintByRow(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)        // m.GetLength(1) = COL
        {
            for (int j = 0; j < m.GetLength(1); j++)    // m.GetLength(0) = ROW
            {
                Console.Write("{0,3} ", m[i, j]);
            }
            Console.WriteLine();
        }
    }

    // 3
    static void ResetArrayElementsToZero(int[,] m)
    {
        for (int i = 0; i < ROW; i++)
            for (int j = 0; j < COL; j++)
                m[i, j] = 0;
    }

    // 4
    static int[,] OrdinalNumbers(int[,] m)
    {
        int max = m[0, 0];
        int temp;

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                if (max > m[i, j])
                {
                    temp = m[i, j];
                    m[i, j] = temp;
                    max = temp;
                }
            }
        }

        return m;
    }

    // 4
    static int[,] OrdinalNumbers2(int[,] m)
    {
        int temp, k = 0, j;

        for (int i = 0; i < ROW * COL; i++)
        {
            for (j = 1; j < COL; j++)
            {
                if (m[k,j-1] > m[k, j])
                {
                    temp = m[k, j];
                    m[k, j] = m[k, j - 1];
                    m[k, j - 1] = temp;
                }

            }

            if ((i + 1) / COL == k + 1)
                k++;
        }

        return m;
    }

    static void Main()
    {
        int[,] m = new int[ROW, COL];

        int[,] table =
        {
            { 5, 1, 2, 4 },
            { 4, 6, 9, 1 },
            { 11, 21, 6, 9 },
            { 4, 7, 3, 2 },
            { 11, 83, 6, 9 }
        };

        table = OrdinalNumbers2(table); // 4

        // The table is printed by rows
        PrintByRow(table);

        Console.WriteLine();

        // The table is printed by columns
        PrintByColumn(table);

        Console.WriteLine("\n");
        m = GetByRows(m);

        //ResetArrayElementsToZero(m);

        PrintByColumn(m);

        m = OrdinalNumbers(m);
        PrintByColumn(m);


        Console.ReadKey();
    }
}