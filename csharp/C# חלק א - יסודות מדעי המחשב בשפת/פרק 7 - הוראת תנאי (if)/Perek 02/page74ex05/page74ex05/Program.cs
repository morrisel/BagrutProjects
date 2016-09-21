using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page74ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter an integer number: ");

            num = int.Parse(Console.ReadLine());

            if (num / 7 == 0 || num % 10 == 7 || num / 10 == 7)
                Console.WriteLine("boom");

            Console.ReadKey();
        }
    }
}
