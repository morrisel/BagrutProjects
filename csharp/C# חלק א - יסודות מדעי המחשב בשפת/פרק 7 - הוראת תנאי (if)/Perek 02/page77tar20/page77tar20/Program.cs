using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page77tar20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = -3, c = 9;
            bool d = true;

            if ((a < b) && (a < c) && (a < 10))
                Console.WriteLine("Alef - True");
            else
                Console.WriteLine("Alef - Fale");
            Console.WriteLine();

            if ((a < b) || (a < c) || (a < 10))
                Console.WriteLine("Bet - True");
            else
                Console.WriteLine("Bet - False");
            Console.WriteLine();

            if ((a < b) || (a < c) && (a < 10))
                Console.WriteLine("Gimel - True");
            else
                Console.WriteLine("Gimel - False");
            Console.WriteLine();

            if ((a < b) || (a < c) && (a < 10) || (b > a))
                Console.WriteLine("Dalet - True");
            else
                Console.WriteLine("Dalet - False");
            Console.WriteLine();

            if (((a < b) || (a < c)) && ((a < 10) || (b > a)))
                Console.WriteLine("H'ehy - True");
            else
                Console.WriteLine("H'ehy - False");
            Console.WriteLine();

            if (((a < b) || (a < c)) && (a < 10) || (b > a))
                Console.WriteLine("Vav - True");
            else
                Console.WriteLine("Vav - False");
            Console.WriteLine();

            if (!(!d) && (!(5 * 7 == 50)))
                Console.WriteLine("Zain - True");
            else
                Console.WriteLine("Zain - False");
            Console.WriteLine();

            if ((a != b) && (!(b * (-3) == c)))
                Console.WriteLine("Het - True");
            else
                Console.WriteLine("Het - False");
            Console.WriteLine();

            if (!(c / 3 == 3) || (!d))
                Console.WriteLine("Tet - True");
            else
                Console.WriteLine("Tet - False");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
