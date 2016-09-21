using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page69tar05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two positive integers number");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num2 > num1)
                Console.WriteLine("{0}, {1}", num1, num2);
            Console.WriteLine("{0}, {1}", num2, num1);
            Console.ReadKey();
        }
    }
}
