using System;

class Program
{
    static int FindMaxSequence(char[,] tav, int row)
    {
        int[] sequences = new int[tav.GetLength(1)];
        int index = 0;
        int maxSequence = 1;

        for (int i = 1; i < tav.GetLength(1); i++)
        {
            if (tav[row - 1, i - 1] == tav[row - 1, i])
            {
                maxSequence++;
                sequences[index] = maxSequence;
            }
            else
            {
                if (sequences[index] != 0)
                {
                    index++;
                    maxSequence = 1;
                }
            }
        }

        maxSequence = sequences[0];
        for (int i = 0; i < sequences.Length; i++)
        {
            if (sequences[i] > maxSequence)
                maxSequence = sequences[i];
        }

        return maxSequence;
    }

    static void GetTable(char[,] tav)
    {
        int[] allMaxSequences = new int[tav.GetLength(0)];
        int row, maxSequence;

        for (int i = 0; i < tav.GetLength(0); i++)
        {
            for (int j = 0; j < tav.GetLength(1); j++)
            {
                Console.Write("{0,4}", tav[i, j]);
            }
            Console.WriteLine();
        }

        Console.Write("Enter number of row for find max sequence: ");
        row = int.Parse(Console.ReadLine());

        maxSequence = FindMaxSequence(tav, row);

        Print(row, maxSequence);
    }

    static void InsertAllRows(char[,] tav)
    {
        int[] maxSequences = new int[tav.GetLength(0)];

        Console.WriteLine("The method finding for all rows the max sequences.");

        for (int i = 0; i < maxSequences.Length; i++)
        {
            maxSequences[i] = FindMaxSequence(tav, i + 1);

            Print(i + 1, maxSequences[i]);
        }

    }

    static void Print(int row, int maxSequence)
    {
        Console.WriteLine("The max sequence of row {0} is: {1}", row, maxSequence);
    }



    static void Main()
    {
        char[,] tav = new char[4, 7]
        {
            { 'c', 'a', 'a', 'x', '@', '@', '@' },
            { 'x', 'y', 'z', 'f', 'f', 'd', 'x' },
            { 'e', 'h', 'k', 'k', 'k', 'k', 'a' },
            { 'i', 'i', 'i', 'i', 'i', '@', '@' }
        };

        GetTable(tav);
        Console.WriteLine();
        InsertAllRows(tav);

        Console.ReadKey();
    }
}