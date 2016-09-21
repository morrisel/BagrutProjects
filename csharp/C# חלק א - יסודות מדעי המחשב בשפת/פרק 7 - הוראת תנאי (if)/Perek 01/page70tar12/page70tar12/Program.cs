using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar12
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc;
            Console.WriteLine("Enter an any three digit number"); 
            abc = int.Parse(Console.ReadLine());

            if ((abc % 100) % 10 == (abc) / 100)
                Console.WriteLine("The number {0} is a Polindrom", abc);
            else
                Console.WriteLine("The number {0} isn't a Polindrom", abc);

            Console.ReadKey();
        }
    }
}
