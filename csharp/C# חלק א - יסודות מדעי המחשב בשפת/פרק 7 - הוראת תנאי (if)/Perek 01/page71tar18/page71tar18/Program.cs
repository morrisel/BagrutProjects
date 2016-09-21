using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page71tar18
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, num;
            int m = 0;

            digit = int.Parse(Console.ReadLine());
            num = int.Parse(Console.ReadLine());

            if (num / 10 == digit)
                m++;

            if (num % 10 == digit)
                m++;

            Console.WriteLine("m = " + m);
        }
    }
}
