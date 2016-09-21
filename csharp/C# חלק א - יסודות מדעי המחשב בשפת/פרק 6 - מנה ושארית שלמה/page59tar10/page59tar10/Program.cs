using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar10
{
    class Program
    {
        static void Main(string[] args)
        {
            int xy, x, y;
            int xyMod, xyDiv;
            int xyx;

            Console.Write("Enter a two digit between  [ 9<xy<100 ]  numbers:  ");
            xy = int.Parse(Console.ReadLine());

            xyDiv = xy / 10;
            xyMod = xy % 10;

            x = xyDiv * 100;
            y = xyMod * 10;

            xyx = x + y + xyDiv;

            Console.WriteLine("The three digit [xyx] numbers from [xy] is:  {0}", xyx);




            Console.ReadKey();

        }
    }
}
