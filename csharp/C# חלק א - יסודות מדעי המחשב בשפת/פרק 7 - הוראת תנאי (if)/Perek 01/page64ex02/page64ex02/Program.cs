using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page64ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if (num % 7 == 0)
                Console.WriteLine("boom");
            Console.ReadKey();
        }
    }
}
