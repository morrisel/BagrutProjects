using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page51tar15
{
    class Program
    {
        static void Main(string[] args)
        {
            int yom, layla, shabat, yomTime, laylaTime, shabatTime;
            double yomSolve, laylaSolve, shabatSolve;
            double maskoret;

            Console.WriteLine("The program compute salary of worker\n");

            Console.Write("How many worked-days you were worked? ");
            yom = int.Parse(Console.ReadLine());
            Console.Write("How much time (hours) of your worked-days do you have? ");
            yomTime = int.Parse(Console.ReadLine());

            Console.Write("How many night you were worked? ");
            layla = int.Parse(Console.ReadLine());
            Console.Write("How much time (hours) of your night's days do you have? ");
            laylaTime = int.Parse(Console.ReadLine());

            Console.Write("How many Shabat's day you were worked? ");
            shabat = int.Parse(Console.ReadLine());
            Console.Write("How much time (hours) of your shabat's days do you have? ");
            shabatTime = int.Parse(Console.ReadLine());

            yomSolve = (double)yom * yomTime;
            laylaSolve = (double)yom + 0.5 * yom;
            shabatSolve = (double)yom * 2;

            maskoret = (double)(yomSolve + laylaSolve + shabatSolve);

            Console.WriteLine("Your salary is: {0}", maskoret);

        }
    }
}
