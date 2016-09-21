using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page46Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int age1;       // must be      10 < age1 <= 120
            int age2;       // must be      4 < age2 <= 120
            int age3;       // must be      1 < age3 <= 120
            int age4;       // must be      0 < age4 <= 120

            Console.Write("Insert the big boy age: ");
            age1 = int.Parse(Console.ReadLine());

            age4 = age1 - 10;
            age3 = age4 + 1;
            age2 = age3 + 3;

            Console.WriteLine("The big girl age is: {0}", age2);
            Console.WriteLine("The small girl age is: {0}", age3);
            Console.WriteLine("The small boy age is: {0}", age4);

            Console.ReadKey();
        }
    }
}
