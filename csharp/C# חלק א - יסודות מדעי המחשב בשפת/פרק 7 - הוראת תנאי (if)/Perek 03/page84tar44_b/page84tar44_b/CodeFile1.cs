using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        float zela1, zela2, zela3;
        bool triangle;

        Console.Write("Enter first side on triangle: ");
        zela1 = float.Parse(Console.ReadLine());
        Console.Write("Enter first side on triangle: ");
        zela2 = float.Parse(Console.ReadLine());
        Console.Write("Enter first side on triangle: ");
        zela3 = float.Parse(Console.ReadLine());


        triangle = zela1 + zela2 > zela3;
        triangle = zela1 + zela3 > zela2;
        triangle = zela2 + zela3 > zela1;

        if (triangle)
            Console.WriteLine("This is a Triangle");
        else
            Console.WriteLine("This isn't a Triangle");

        Console.ReadKey();
    }
}