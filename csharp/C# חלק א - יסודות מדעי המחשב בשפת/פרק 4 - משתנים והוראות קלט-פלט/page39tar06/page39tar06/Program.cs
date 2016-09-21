using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page39tar06
{
    class Program
    {
        static void Main(string[] args)
        {
            char tav;
            Console.Write("Insert a character:   ");
            tav = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(tav);
            Console.WriteLine(tav + "" + tav);
            Console.WriteLine(tav + "" + tav + "" + tav + "\n");
            Console.ReadKey();
        }
    }
}
