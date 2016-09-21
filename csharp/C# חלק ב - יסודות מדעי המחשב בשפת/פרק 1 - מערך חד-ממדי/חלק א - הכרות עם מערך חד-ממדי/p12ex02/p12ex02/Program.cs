using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[6];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;
        numbers[5] = 6;

        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 == 0)
                numbers[i - 1] = i + 2;
            else
                numbers[i - 1] = i * 2;
        }

        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
        }

        Console.ReadKey();
    }
}