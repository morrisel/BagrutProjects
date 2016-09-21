using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 4; i >= 0; i--)
            numbers[i] = i + 1;

        for (int i = 4; i >= 0; i--)
            Console.Write(" {0}", numbers[i]);

        Console.ReadKey();
    }
}