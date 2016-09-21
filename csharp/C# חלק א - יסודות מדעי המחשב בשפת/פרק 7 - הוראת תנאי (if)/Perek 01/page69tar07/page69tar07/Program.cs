using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page69tar07
{
    class Program
    {
        static void Main(string[] args)
        {
            int byChocolate, sellChocolate;
            int earnBuyer, lostBuyer;

            Console.Write("Enter the amount of packages of chocolate what the salesman buy: ");
            byChocolate = int.Parse(Console.ReadLine());
            byChocolate = byChocolate * 5;

            Console.Write("Enter the amount of packages of chocolate what the salesman sell: ");
            sellChocolate = int.Parse(Console.ReadLine());
            sellChocolate = sellChocolate * 10;

            if (sellChocolate > byChocolate)
            {
                earnBuyer = sellChocolate - byChocolate;
                Console.WriteLine("The salesman earn {0} ", earnBuyer);
            }
            else
            {
                lostBuyer = sellChocolate - byChocolate;
                Console.WriteLine("The salesman lose {0} ", lostBuyer);
            }

            Console.ReadKey();
        }
    }
}
