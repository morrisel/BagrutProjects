using System;

class CodeFile1
{
    // The program compute a sircle features: diameter, perimeter, area.
    static void Main(string[] args)
    {
        int radius, diameter;
        double perimeter, area;

        Console.Write("Enter a radius of circle: ");

        radius = int.Parse(Console.ReadLine());

        diameter = 2 * radius;
        perimeter = 2 * Math.PI * radius;
        area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The diameter of circle is:\t{0}", diameter);
        Console.WriteLine("The perimeter of circle is:\t{0}",perimeter);
        Console.WriteLine("The area of circle is:\t\t{0}", area);

        Console.ReadKey();
    }
}