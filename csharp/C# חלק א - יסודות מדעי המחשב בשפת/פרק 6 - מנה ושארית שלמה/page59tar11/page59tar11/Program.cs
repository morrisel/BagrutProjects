using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar11
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc, bc, a, b, c;
            int cba;

            Console.Write("Enter three digits number  abc = ");
            abc = int.Parse(Console.ReadLine());

            bc = abc % 100;
            a = abc / 100;
            b = bc / 10;
            c = bc % 10;

            Console.WriteLine("The sum of a, b and c is: {0}", a + b + c);
            Console.WriteLine("{0} + {1} + {2} = {3}", a * 100, b * 10, c, abc);
            Console.WriteLine("The reverse of abc is:  cba = {0}", (c * 100) + (b * 10) + a);



            Console.ReadKey();
        }
    }
}
