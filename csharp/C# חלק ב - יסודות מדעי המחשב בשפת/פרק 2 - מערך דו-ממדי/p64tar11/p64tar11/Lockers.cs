using System;

class Lockers
{
    const int N = 9;

    static void CreateLockersNumber(int[,] locker)
    {
        int num = 10;

        for (int i = 0; i < locker.GetLength(0); i++)
        {
            num = 10 * (i + 1);

            for (int j = 0; j < locker.GetLength(1); j++)
            {
                num++;
                locker[i, j] = num;
            }
        }
    }

    static int GenerateCodes(int row, int col)
    {
        Random rnd = new Random();
        int num;

        num = rnd.Next(111, 999);

        return num + row * 10 + col;
    }

    static int GetCodesOfLocker(int[,] locker, int num)
    {
        int code, row, col;

        row = num / 10 - 1;
        col = num % 10 - 1;

        code = GenerateCodes(row, col);

        code += locker[row, col];

        return code;
    }

    static void Main()
    {
        int num, code;
        int[,] numOfLockers = new int[N, N];

        CreateLockersNumber(numOfLockers);

        Console.Write("Enter number between (11-99): ");
        num = int.Parse(Console.ReadLine());

        code = GetCodesOfLocker(numOfLockers, num);
        Console.WriteLine("The code of locker {0}, is {1}", num, code);

        Console.ReadKey();
    }
}