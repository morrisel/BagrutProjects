using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page39tar03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter an integer number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("the number {0} large 2 is: {1}", num, num + 2);
            Console.WriteLine("the number {0} times great 3 is: {1}", num, num * 3);
            Console.ReadKey();

        }
    }
}
