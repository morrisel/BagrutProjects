using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int roundSquare = 0, i;
        double square;
        for (i = 1; i <= 300; i++)
        {
            square = Math.Sqrt(i);
            if (square % 2 == 0 || square % 3 == 0 ||
                square % 5 == 0 || square % 7 == 0 ||
                square % 11 == 0 || square % 13 == 0 ||
                square % 17 == 0)
            {
                Console.WriteLine(square);
                roundSquare++;
            }
        }
        Console.WriteLine("\n" + roundSquare);
        Console.ReadKey();
    }
}