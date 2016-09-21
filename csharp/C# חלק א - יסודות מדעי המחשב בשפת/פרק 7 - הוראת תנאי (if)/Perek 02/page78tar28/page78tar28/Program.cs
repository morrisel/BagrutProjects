using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double aa, bb, cc;

            Console.WriteLine("The program recognize if the numbers comprise of Pythagoras theorem or no\n");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            aa = a * a;
            bb = b * b;
            cc = c * c;

            if (cc == aa + bb)
                Console.WriteLine("The numbers of Pythogoras theorem");
            else
                Console.WriteLine("No");


            Console.ReadKey();
        }
    }
}
