using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar09
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1, year2;

            Console.Write(" Insert the year of your birthday: ");
            year1 = int.Parse(Console.ReadLine());
            Console.Write(" Inser a current year: ");
            year2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is: {0}", year2-year1);
        }
    }
}
