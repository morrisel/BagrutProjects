using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page81tar34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Smallest number");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
                Console.WriteLine(" {0} the most smallest number", a);
            else
            {
                if (b < a && b < c)
                    Console.WriteLine(" {0} the most smallest number", b);
                else
                    Console.WriteLine(" {0} the most smallest number", c);
            }

            Console.ReadKey();
        }
    }
}
