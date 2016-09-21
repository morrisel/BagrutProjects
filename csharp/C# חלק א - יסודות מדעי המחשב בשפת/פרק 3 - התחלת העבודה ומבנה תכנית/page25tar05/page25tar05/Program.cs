using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page25tar05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 input and 1 output

            double beforeVAT = 100.43;
            double afterVAT;

            Console.WriteLine("The program is compute the cost of Computer with include VAT\n");

            Console.WriteLine("The cost of computer in Israel before VAT was: {0} NIS", beforeVAT);

        //    temp = beforeVAT;

            afterVAT = beforeVAT * 0.17 + beforeVAT;
            Console.WriteLine("The cost of computer in Israel with VAT is: {0} NIS", afterVAT);

            Console.ReadKey();

        }
    }
}
