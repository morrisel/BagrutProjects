using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page81tar35_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2 && (n1 % 2 == 0 || n2 % 2 == 0))
            {
                int temp;
                temp = n1 - n2;
                if (temp % 2 == 0)
                    Console.WriteLine("Both are even");
                else
                    Console.WriteLine("One of them is even");
            }
            else
                Console.WriteLine("The sum of numbers is: {0}", n1 + n2);

            Console.ReadKey();
        }
    }
}
