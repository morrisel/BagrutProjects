using System;

class CodeFile1
{
    static int Sod2(int x, int y)
    {
        if (x < 0)
            return Math.Sqrt(x - y);
        return Math.Sqrt(x + y);
        return Math.Sqrt(x * y);
    }


    static void Main(string[] args)
    {
        int a, b;
        int sq;

        Console.Write("Enter a number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        b = int.Parse(Console.ReadLine());

        sq = Sod2(a, b);
        Console.WriteLine(sq);


        Console.ReadKey();
    }
}