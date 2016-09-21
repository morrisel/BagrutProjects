using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page45Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int out1, out2, out3, pay;
            double avg;

            Console.WriteLine("Insert three numbers of exits");
            out1 = int.Parse(Console.ReadLine());
            out2 = int.Parse(Console.ReadLine());
            out3 = int.Parse(Console.ReadLine());

            pay = (out1 + out2 + out3) * 12;
            avg = (double)(out1 + out2 + out3) / 3;

            Console.WriteLine("The sum of month is: {0}", pay);
            Console.WriteLine("The average of month is: {0}", avg);
            Console.ReadKey();
        }
    }
}
