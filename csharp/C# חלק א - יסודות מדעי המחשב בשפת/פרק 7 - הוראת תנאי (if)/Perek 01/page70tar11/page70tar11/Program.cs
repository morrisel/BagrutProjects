using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar11
{
    class Program
    {
        static void Main(string[] args)
        {
            int januar, februar, march;
            float avg;
            int msg;

            Console.Write("Enter the amount rain of Januar season: ");
            januar = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount rain of Februar season: ");
            februar = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount rain of March season: ");
            march = int.Parse(Console.ReadLine());

            avg = (float)(januar + februar + march) / 3;

            if (avg > 100)
            {
                Console.WriteLine("It very rainy  {0}", avg);
            }


            Console.ReadKey();
        }
    }
}
