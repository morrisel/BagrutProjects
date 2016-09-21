using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 10 * i + 10;
            Console.Write(" {0,4}", a[i]);
        }

        Console.WriteLine("\n" + new string('-', 50));
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = (int)Math.Pow((i + 1), 2);
            Console.Write(" {0,4}", a[i]);
        }

        Console.WriteLine("\n" + new string('-', 50));
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = i + 1;
            if (a[i] % 2 == 0) a[i] = 0;

            //// ternary operator
            //a[i] = (a[i] % 2 == 0) ? 0 : a[i];

            Console.Write(" {0,4}", a[i]);
        }

        Console.WriteLine("\n" + new string('-', 50));
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 3 * (i + 1);
            Console.Write(" {0,4}", a[i]);
        }

        Console.WriteLine("\n" + new string('-', 50));
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = 2 * i + 2;

            if (i % 2 != 0)
                a[i] = (-1) * a[i];

            Console.Write(" {0,4}", a[i]);
        }

        Console.WriteLine("\n" + new string('-', 50));
        for (int i = 0, sum = 0; i < a.Length; i++)
        {
            sum = sum + i;

            a[i] = 7 + sum;
            
            Console.Write(" {0,4}", a[i]);
        }

        Console.ReadKey();
    }
}