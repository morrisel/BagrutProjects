using System;

class CodeFile1
{
    // The program compute the Chord of Orthogonal rectangular
    static void Main(string[] args)
    {
        int verLine, horLine;
        double chord;

        Console.WriteLine("Enter a vertical and horizontal line of orthogonal rectangular");
        Console.Write("Enter a vertical line ");
        verLine = int.Parse(Console.ReadLine());
        Console.Write("Enter a horizontal line ");
        horLine = int.Parse(Console.ReadLine());

        chord = Math.Sqrt(Math.Pow(verLine, 2) + Math.Pow(horLine, 2));

        Console.WriteLine("\nThe chord of orthogonal rectengular is: {0}", chord);

        Console.ReadKey();
    }
}