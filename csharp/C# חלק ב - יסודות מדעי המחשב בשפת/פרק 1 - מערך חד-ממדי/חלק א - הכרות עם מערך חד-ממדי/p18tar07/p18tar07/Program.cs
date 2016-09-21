using System;

class Program
{
    static void Main()
    {
        int test;
        int[] a, b;

        a = new int[6];
        b = new int[4];

        Random rnd = new Random();

        test = rnd.Next(0);
        Console.WriteLine(test);
        Console.WriteLine("\n");

        for (int i = 0; i < 6; i++)
        {
            a[i] = rnd.Next(6) + 1 - i;
            Console.Write("{0} ", a[i]);
        }

        Console.WriteLine("\n");

        for (int i = 0; i < 4; i++)
        {
            //if (((1 - i) * 3 +3) < 0)
            //break;
            b[i] = rnd.Next(Math.Abs(1 - i) * 3) + 3;
            Console.Write("{0} ", b[i]);
        }

        Console.ReadKey();
    }
}