using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar10
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int a, b, c;

            Console.WriteLine("Enter an integer number: ");
            firstNum = int.Parse(Console.ReadLine());

            firstNum++;
            a = firstNum;
            Console.Write(a);

            a++;
            b = a;
            Console.Write(" "+b);
            
            b++;
            c = b;
            Console.Write(" " + c);

            Console.WriteLine();

        }
    }
}
