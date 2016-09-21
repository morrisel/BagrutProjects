using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar07
{
    class Program
    {
        static void Main(string[] args)
        {
            long minute, hour;
            long mod, div;

            Console.Write("Enter number in minute:  ");
            minute = long.Parse(Console.ReadLine());

            div = minute / 60;
            mod = minute % 60;

            hour = div;
            minute = mod;

            Console.WriteLine("You have an  {0}  hours and  {1}  minutes", hour, minute);
            Console.ReadKey();
        }
    }
}
