using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int diff1, diff2;

            Console.WriteLine("Enter three integer numbers \n\t\tin order to know whether the number of \n\t\t\t\tarithmetic progression or no\n");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            diff1 = num2 - num1;
            diff2 = num3 - num2;
            if (diff2 == diff1)
                Console.WriteLine("This is an arithmetic progression");
            else
                Console.WriteLine("No, it's not an arithmetic progression");
            Console.ReadKey();
        }
    }
}
