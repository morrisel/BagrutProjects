using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page71tar19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max, t;
            num = int.Parse(Console.ReadLine());

            max = num % 10;
            t = num / 10 % 10;
            if (t > max)
                max = t;
            t = num / 100;
            if (t > max)
                max = t;
            Console.WriteLine("The digit is " + max);
        }
    }
}
