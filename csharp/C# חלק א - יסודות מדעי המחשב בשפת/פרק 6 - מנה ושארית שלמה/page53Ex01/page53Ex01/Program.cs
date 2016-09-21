using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page53Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ten, units, sum;

            Console.WriteLine("Enter a two digit number (10 - 99):");
            num = int.Parse(Console.ReadLine());
            ten = num / 10;
            units = num % 10;

            Console.WriteLine("The tens digits: {0}, the units digits: {1}", ten, units);

            sum = ten + units;
            Console.WriteLine("The digits sum is: {0}", sum);
            Console.ReadKey();

        }
    }
}
