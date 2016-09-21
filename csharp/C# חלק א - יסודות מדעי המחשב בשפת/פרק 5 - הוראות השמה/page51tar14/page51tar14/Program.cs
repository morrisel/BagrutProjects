using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar14
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.WriteLine("The program is converting from fahrenheit to celsius degree");
            Console.Write("Enter a value in fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (double)5 / (9 * (fahrenheit - 32));

            Console.WriteLine("The celsiuse is: " + celsius);
        }
    }
}
