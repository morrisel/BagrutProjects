using System;

class Program
{
    static int[] FindMaxStudentsInSectionAndGroup(int[,] zofim)
    {
        int[] max = new int[zofim.GetLength(0)];
        int tempMax = 0;

        for (int i = 0; i < zofim.GetLength(0); i++)
        {
            tempMax = zofim[i, 0];
            for (int j = 1; j < zofim.GetLength(1); j++)
            {
                if (tempMax < zofim[i, j])
                    tempMax = zofim[i, j];
            }
            max[i] = tempMax;
        }

        return max;
    }

    static void PrintSectionAndGroupOfMaxStudents(int[,] zofim)
    {
        int[] max = FindMaxStudentsInSectionAndGroup(zofim);

        for (int i = 0; i < zofim.GetLength(0); i++)
        {
            for (int j = 0; j < zofim.GetLength(1); j++)
            {
                if (max[i] == zofim[i, j])
                {
                    Console.WriteLine("gdud: {0}, kvuza: {1}, hanihim: {2}", i + 1, j + 1, max[i]);
                }
            }
        }
    }

    static int FindMinFromAllMaxies(int[] max)
    {
        int min = 0;

        min = max[0];
        for (int i = 1; i < max.Length; i++)
        {
            if (max[i] < min)
                min = max[i];
        }

        return min;
    }

    static void PrintMinFromAllMaxies(int[,] zofim, int min)
    {
        Console.WriteLine("The minimal group from all maxies groups is:");
        for (int i = 0; i < zofim.GetLength(0); i++)
        {
            for (int j = 0; j < zofim.GetLength(1); j++)
            {
                if (zofim[i, j] == min)
                {
                    Console.WriteLine("gdud {0}, kvuzta {1}:", i + 1, j + 1);
                }
            }
        }
        Console.WriteLine("end the number is: {0}", min);
    }

    static void Main()
    {
        int[,] zofim =
        { 
            { 9, 15, 23, 18, 15, 20 },
            { 21, 20, 19, 17, 34, 22 },
            { 30, 28, 25, 19, 20, 19 },
            { 14, 16, 23, 22, 21, 23 }
        };

        int[] max = new int[zofim.GetLength(0)];

        max = FindMaxStudentsInSectionAndGroup(zofim);

        int min;
        min = FindMinFromAllMaxies(max);


        Console.WriteLine("--------------------------------");
        PrintSectionAndGroupOfMaxStudents(zofim);
        Console.WriteLine("--------------------------------");
        PrintMinFromAllMaxies(zofim, min);
        Console.WriteLine("--------------------------------");

        Console.ReadKey();
    }
}