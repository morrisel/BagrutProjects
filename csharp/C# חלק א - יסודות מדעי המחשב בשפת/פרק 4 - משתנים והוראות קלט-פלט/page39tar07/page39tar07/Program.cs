using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page39tar07
{
    class Program
    {
        static void Main(string[] args)
        {
            char tav;
            Console.Write("Insert a character:   ");
            tav = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("| " + "  " + " " + "  " + " | " + tav + "  " + "  " + " | " + tav + "  " + "  " + " | " + tav + "   " + tav + " | " + tav + "   " + tav + " | " + tav + "   " + tav + " |");
            Console.WriteLine("| " + "  " + tav + "  " + " | " + "  " + " " + "  " + " | " + "  " + tav + "  " + " | " + " " + "   " + " " + " | " + "  " + tav + "  " + " | " + tav + "   " + tav + " |");
            Console.WriteLine("| " + "  " + " " + "  " + " | " + "  " + "  " + tav + " | " + "  " + "  " + tav + " | " + tav + "   " + tav + " | " + tav + "   " + tav + " | " + tav + "   " + tav + " |");

            Console.ReadKey();
        }
    }
}
