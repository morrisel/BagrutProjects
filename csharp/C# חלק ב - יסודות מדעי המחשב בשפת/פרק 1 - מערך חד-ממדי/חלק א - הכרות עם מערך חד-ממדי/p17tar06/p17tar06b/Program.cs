using System;

class Program
{
    static void Main()
    {
        int i, b;
        int[] num = new int[6];

        i = 1;
        num[i] = 2;
        num[i + 1] = 4;
        b = num[i++] + 10;

        Console.WriteLine("i = {0} , b = {1}", i, b);

        Console.ReadKey();
    }
}