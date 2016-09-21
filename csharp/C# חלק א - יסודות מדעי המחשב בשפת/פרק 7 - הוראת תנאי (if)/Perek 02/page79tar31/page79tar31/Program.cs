using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page79tar31
{
    class Program
    {
        static void Main(string[] args)
        {
            float line1, line2, line3;
            Console.Write("The program solve the rectangular problem\n");
            Console.Write("Enter three length sides of rectangle \n");
            line1 = float.Parse(Console.ReadLine());
            line2 = float.Parse(Console.ReadLine());
            line3 = float.Parse(Console.ReadLine());

            if ((line1 + line2 > line3) && (line1 + line3 > line2) && (line2 + line3 > line1))
                Console.WriteLine("This is a rectangle");
            else
                Console.WriteLine("This isn't a rectangle");

            Console.ReadKey();
        }
    }
}
