using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter an any number between [0 - 9]: ");

            num = int.Parse(Console.ReadLine());

            if ((num >= 0) && (num <= 9))
            {
                Console.WriteLine("The number what putted is a single digit");
            }
            else
            {
                Console.WriteLine("The number what putted is a double digit");
            }
        }
    }
}
