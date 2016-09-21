using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page56tar02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12 / 7, b = 12 % 7, c = b / a, d = c % c;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
        }
    }
}
