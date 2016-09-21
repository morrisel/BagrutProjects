using System;

class CodeFile1
{
    /* r-טענת כניסה: הפעולה מקבלת אורך רדיוס ב */
    /* :טענת יציאה: הפעולה מציגה כפלט */
    // קוטר, היקף ושטח המעגל
    // קוטר היקף ושטח המעגל שרדיוסו מחצית מהרדיוס שהתקבל כקלט
    static void Circle(double r)
    {
        double diameter, perimeter, area;

        diameter = 2 * r;               // קוטר
        perimeter = 2 * Math.PI * r;    // היקף
        area = Math.PI * r * r;         // שטח

        Console.Write("\nThe diameter of radius {0} is:\t{1}", r, diameter);
        Console.Write("\nThe perimeter of radius {0} is:\t{1}", r, perimeter);
        Console.Write("\nThe area of radius {0} is:\t{1}", r, area);

        Console.WriteLine("\n\n............................................................");
        diameter = 2 * (r / 2);                 // קוטר
        perimeter = 2 * Math.PI * (r / 2);      // היקף
        area = Math.PI * (r / 2) * (r / 2);     // שטח

        Console.Write("\nThe diameter of radius {0} is:\t{1}", r / 2, diameter);
        Console.Write("\nThe perimeter of radius {0} is:\t{1}", r / 2, perimeter);
        Console.Write("\nThe area of radius {0} is:\t{1}", r / 2, area);
    }


    /* r-קלט: אורך רדיוס ב */
    /* פלט: הפעולה מציגה את הפלט */
    public static void Main(string[] args)
    {
        double radius;

        Console.Write("Enter a size of radius:  ");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("\nTest is running...");
        Circle(radius);
        Console.WriteLine();
        Console.ReadKey();
    }
}