using System;

class CodeFile1
{
    // The program compute the area and perimeter of rectangular
    // Heron's formula
    // The states that the area "A" of a triangle whose sides have lengths "a", "b", and "c" is
    // where "s" is the semiperimeter of the triangle.
    // A = Sqrt[s(s-a)(s-b)(s-c)]

    static void Main(string[] args)
    {
        float sideA, sideB, sideC, perimeter;
        float semiPerim;
        double area;

        Console.Write("Enter side A of triangle: ");
        sideA = float.Parse(Console.ReadLine());
        Console.Write("Enter side A of triangle: ");
        sideB = float.Parse(Console.ReadLine());
        Console.Write("Enter side A of triangle: ");
        sideC = float.Parse(Console.ReadLine());

        perimeter = sideA + sideB + sideC;
        semiPerim = perimeter / 2;
        area = Math.Sqrt(semiPerim * (semiPerim - sideA) * (semiPerim - sideB) * (semiPerim - sideC));

        Console.WriteLine("The perimeter of rectangular is:\t{0}", perimeter);
        Console.WriteLine("The area of rectangular is:\t\t{0}", area);

        Console.ReadKey();
    }
}