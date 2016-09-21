using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar08
{
    class Program
    {
        static void Main(string[] args)
        {
            int talmidim;
            int pairs, alone;

            Console.Write("Enter a number of students  ");
            talmidim = int.Parse(Console.ReadLine());

            pairs = talmidim / 2;
            alone = talmidim % 2;

            Console.WriteLine("The pairs of students is:  {0}", pairs);
            Console.WriteLine("The alon of students is:  {0}", alone);
            Console.ReadKey();
        }
    }
}
