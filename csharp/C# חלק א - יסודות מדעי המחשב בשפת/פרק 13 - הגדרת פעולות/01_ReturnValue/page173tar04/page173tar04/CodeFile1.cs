using System;

class CodeFile1
{
    static int Fun1(int x, double r)
    {
        int a = 1, b = 2;
        //double b = 2.0;
        return a + b;

    }

    static int Fun2(int b)
    {
        int mF2 = 7;
        return mF2;
    }


    static void Main(string[] args)
    {
        double r1;
        int x1, x2, b1, b2;

        x2 = Fun1(x1 * 4, 11 / 12);

        Fun1(5, 9 / 3);

        if (Fun1(7, x1) > 0)
            r1 = 7;

        if (Fun1(7, x1) == b1)
            Fun2 = 7;

        b1 = Fun1(Fun2(b2), r1);

        Console.WriteLine(Fun2(x1 > x2));

        Console.WriteLine(Fun2(b1 - b2));

        if (Fun2(x1, x2) > 0)
            Console.WriteLine("x1>x2");

        for (x1 = 1; x1 <= Fun2(b1); x1++)
            Console.WriteLine(x1);


    }
}
