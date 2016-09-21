using System;

class Program
{
    static void Main(string[] args)
    {
        // input 2 numbers
        // output 2 numbers
        int length = 5;
        int width = 7;

        float area, perimeter;

        area = length * width;
        perimeter = 2 * (length + width);

        Console.WriteLine("length = 5");
        Console.WriteLine("width = 7");
        Console.WriteLine("The area of rectangle is: {0}", area);
        Console.WriteLine("The perimeter of rectangle is: {0}", perimeter);
        Console.ReadKey();
    }
}