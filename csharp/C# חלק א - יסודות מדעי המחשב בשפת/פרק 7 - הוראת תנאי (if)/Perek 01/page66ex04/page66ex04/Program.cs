using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page66ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double results;

            Console.WriteLine("Please enter the big number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the small number");
            num2 = int.Parse(Console.ReadLine());
            results = num1 / num2;
            if (num1 % num2 == 0)
            {
                Console.WriteLine("{0} divided by {1}", num1, num2);
                Console.WriteLine("The result is {0}", results);
            }
            else
                Console.WriteLine("{0} is not divided by {1}", num1, num2);


            Console.ReadKey();
        }
    }
}
