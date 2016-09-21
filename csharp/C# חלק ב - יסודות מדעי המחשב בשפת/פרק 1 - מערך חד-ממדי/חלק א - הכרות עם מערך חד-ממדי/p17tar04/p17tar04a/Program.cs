using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
            numbers[i] = i + 1;

        for (int i = 0; i < 5; i++)
            Console.Write("{0} ", numbers[i]);

        Console.ReadKey();
    }
}