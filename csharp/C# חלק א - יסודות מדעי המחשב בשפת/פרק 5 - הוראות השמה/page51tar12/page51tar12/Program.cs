using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar12
{
    class Program
    {
        static void Main(string[] args)
        {
            int pkak1, pkak2, pkak3, pkak4, pkak5, pkak6, pkak7;
            double sum;
            double all;
            
            Console.WriteLine("The program compute how many points do you have!");
            Console.WriteLine("Obey to the following message!\n");

            Console.WriteLine("You find 5 pakaks from 12");

            Console.Write("What value on the pkak? 10, 100, 1000 or 10000: ");
            pkak1 = int.Parse(Console.ReadLine());

            Console.Write("What value on the pkak? 10, 100, 1000 or 10000: ");
            pkak2 = int.Parse(Console.ReadLine());

            Console.Write("What value on the pkak? 10, 100, 1000 or 10000: ");
            pkak3 = int.Parse(Console.ReadLine());

            Console.Write("What value on the pkak? 10, 100, 1000 or 10000: ");
            pkak4 = int.Parse(Console.ReadLine());

            Console.Write("What value on the pkak? 10, 100, 1000 or 10000: ");
            pkak5 = int.Parse(Console.ReadLine());


            sum = pkak1 + pkak2 + pkak3 + pkak4 + pkak5;
            
            all = 5 / 12.0 + sum;

            Console.WriteLine("\t\n* * *   G O O D ! ! !   * * *\n");
            Console.WriteLine("Y O U   H A V E   {0}   P O I N T S ! ! !\n\n", all);
        }
    }
}
