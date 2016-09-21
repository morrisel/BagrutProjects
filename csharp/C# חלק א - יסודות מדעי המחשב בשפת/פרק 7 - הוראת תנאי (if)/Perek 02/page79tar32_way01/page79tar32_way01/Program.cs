using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page79tar32_way01
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, numFirst, numSecond;

            Console.WriteLine("Enter a two digit number");
            digit = int.Parse(Console.ReadLine());

            if (digit % 2 == 0)
            {
                numFirst = digit / 10;
                numSecond = digit % 10;
                numFirst++;
                numSecond++;
                numFirst = numFirst * 10;
                digit = numFirst + numSecond;
                Console.WriteLine("The digit number is increase: " + digit);
            }
            else
            {
                numFirst = digit / 10;
                numSecond = digit % 10;
                numFirst--;
                numSecond--;
                numFirst = numFirst * 10;
                digit = numFirst + numSecond;
                Console.WriteLine("The digit number is dicrease: " + digit);
            }


            Console.ReadKey();
        }
    }
}
