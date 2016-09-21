using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar16
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1, year2;

            Console.Write(" Insert the year of your birthday: ");
            year1 = int.Parse(Console.ReadLine());
            Console.Write(" Inser a current year: ");
            year2 = int.Parse(Console.ReadLine());


            int old, benYom, benShaa, benDaka;
            old = year2 - year1;

            benYom = old * 365;
            benShaa = benYom * 24;
            benDaka = benShaa * 60;

            Console.WriteLine("You have {0} days", benYom);
            Console.WriteLine("You have {0} hours", benShaa);
            Console.WriteLine("You have {0} minutes", benDaka);
        }
    }
}
