using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page54Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int len, lenMm;
            int blue, white;
            int onlyBlue, onlyWhite;
            int blueAndWhite;

            Console.WriteLine("Insert the chain length");
            len = int.Parse(Console.ReadLine());        // אורך מחרוזת מסנטימטרים

            Console.WriteLine("Insert the blue and white diameter");
            blue = int.Parse(Console.ReadLine());       // אורך חרוז כחול במילימטרים
            white = int.Parse(Console.ReadLine());      // אורך חרוז לבן במילימטרים

            lenMm = len * 10;         // המרת מסנטימטרים למילימטרים

            onlyBlue = lenMm / blue;
            onlyWhite = lenMm / white;

            blueAndWhite = lenMm / (onlyBlue + onlyWhite);

            Console.WriteLine("only blue: {0}", onlyBlue);
            Console.WriteLine("only white: {0}", onlyWhite);
            Console.WriteLine("blue and white: {0} from each color", blueAndWhite);
        }
    }
}
