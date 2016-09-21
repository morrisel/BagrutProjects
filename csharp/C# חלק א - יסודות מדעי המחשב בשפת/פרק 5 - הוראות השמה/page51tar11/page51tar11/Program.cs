using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar11
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b;
            double perimeter, area;
            // The program is compute the perimeter and area of equilateral rectangle
            Console.WriteLine("The program is equal the perimeter and area of rectangle");

            Console.Write("Enter a height of rectangle: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Enter a side of rectangle: ");
            b = double.Parse(Console.ReadLine());

            // compute the perimeter
            perimeter = 3 * b;

            // comput the area
            area = (h * b) / 2;

            Console.WriteLine("The perimeter of equilateral rectangle is: {0}", perimeter);
            Console.WriteLine("The area of equilateral rectangle is: {1}", area);
            Console.ReadKey();
        }
    }
}
