using System;

class Program
{
    static bool IsMatrixRowSimetric(char[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1) / 2; j++)
                if (m[i, j] != m[i, m.GetLength(0) - 1 - j])
                    return false;

        return true;
    }

    static bool IsMatrixColumnSimetric(char[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1) / 2; j++)
                if (m[j, i] != m[m.GetLength(1) - j - 1, i])
                    return false;

        return true;
    }

    static bool IsMatrixSimetric(char[,] m)
    {
        bool rowsIsTrue, columnsIsTrue;

        rowsIsTrue = IsMatrixRowSimetric(m);
        columnsIsTrue = IsMatrixColumnSimetric(m);

        if (rowsIsTrue && columnsIsTrue)
            return true;
        else
            return false;
    }

    static void Main()
    {
        char[,] m =
        {
            { 'a', 'b', 'b', 'a' },
            { 'c', 'c', 'c', 'c' },
            { 'c', 'c', 'c', 'c' },
            { 'a', 'b', 'b', 'a' }
        };

        Console.WriteLine("The matrix is simetric?: {0}", IsMatrixSimetric(m));

        Console.ReadKey();
    }
}