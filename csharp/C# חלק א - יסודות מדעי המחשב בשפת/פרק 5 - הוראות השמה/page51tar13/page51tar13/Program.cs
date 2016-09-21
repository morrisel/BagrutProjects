using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar13
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollar, dollarBonus = 400;
            double shekel, shekelBonus, allSum;

            Console.Write("The sum for traveling in dollars is: ");
            dollar = int.Parse(Console.ReadLine());
            Console.WriteLine("In addition, for traveling boy got 400$ for any spending\n");

            shekel = (dollar * 3.7);
            shekelBonus = (dollarBonus * 3.7);

            allSum = shekel + shekelBonus;

            Console.WriteLine("The lump sum in NIS was: {0}", allSum);
        }
    }
}
