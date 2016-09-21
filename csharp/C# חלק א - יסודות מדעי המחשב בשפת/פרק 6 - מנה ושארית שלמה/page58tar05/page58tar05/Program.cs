using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page58tar05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, newNum;
            Console.WriteLine("Enter a three digit number");
            num = int.Parse(Console.ReadLine());
            newNum = (num + 5) / 10 * 10;
            Console.WriteLine("newNum = {0}", newNum);
            Console.ReadKey();
        }
    }
}
