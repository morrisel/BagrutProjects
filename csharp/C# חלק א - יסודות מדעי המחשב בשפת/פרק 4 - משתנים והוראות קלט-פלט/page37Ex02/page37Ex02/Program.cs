using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page37Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1, digit2, digit3;

            Console.WriteLine("Please insert 3 digits: ");
            digit1 = int.Parse(Console.ReadLine());
            digit2 = int.Parse(Console.ReadLine());
            digit3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("{0} {1} {2}", digit1, digit2, digit3);
            Console.WriteLine("{0} {1} {2}", digit1, digit3, digit2);
            Console.WriteLine("{0} {1} {2}", digit2, digit1, digit3);
            Console.WriteLine("{0} {1} {2}", digit2, digit3, digit1);
            Console.WriteLine("{0} {1} {2}", digit3, digit1, digit2);
            Console.WriteLine("{0} {1} {2}", digit3, digit2, digit1);
        }
    }
}
