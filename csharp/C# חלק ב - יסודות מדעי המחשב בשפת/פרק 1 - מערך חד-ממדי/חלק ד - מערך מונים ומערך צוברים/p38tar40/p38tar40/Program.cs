using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        Random randNum = new Random();

        int num;
        for (int i = 0; i < 9; i++)
        {
            num = randNum.Next(1, 10);
            //a[num] = a[num] + num / num;
            a[num-1] += num / num;
        }

        Console.ReadKey();
    }
}