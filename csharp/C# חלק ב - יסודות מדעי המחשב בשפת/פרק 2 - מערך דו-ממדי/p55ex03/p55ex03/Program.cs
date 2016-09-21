using System;

class Ch2Solve3
{
    static void Main()
    {
        //char[,] m = new char[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
        char[,] m = { { 'i', 'm', 'a' }, { 'i', 's', 'b' }, { 's', 's', 'e' } };

        int count = 0;

        //for (int i = 0; i < m.GetLength(0); i++)
        //    for (int j = 0; j < m.GetLength(1); j++)
        //        m[i, j] = char.Parse(Console.ReadLine());

        for (int i = 0; i < m.GetLength(0)-1; i++)
        {
            for (int j = 0; j < m.GetLength(1)-1; j++)
            {
                if (m[i, j] == m[i, j + 1])
                    count++;
                if (m[i, j] == m[i + 1, j])
                    count++;
            }
        }

        int lastRow = m.GetLength(0) - 1;
        for (int j = 0; j < m.GetLength(1)-1; j++)
        {
            if (m[lastRow, j] == m[lastRow, j + 1])
                count++;
        }

        int lastCol = m.GetLength(1) - 1;
        for (int i = 0; i < m.GetLength(0)-1; i++)
        {
            if (m[i, lastCol] == m[i + 1, lastCol])
                count++;
        }

        Console.WriteLine(count);

        Console.ReadKey();
    }
}