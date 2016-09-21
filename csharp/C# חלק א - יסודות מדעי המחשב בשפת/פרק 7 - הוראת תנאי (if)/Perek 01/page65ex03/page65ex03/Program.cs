using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page65ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople, numBoats, totalBill = 0;
            Console.WriteLine("Enter a number of people in a group");

            numPeople = int.Parse(Console.ReadLine());
            if (numPeople % 8 == 0)
                numBoats = numPeople / 8;
            else
                numBoats = numPeople / 8 + 1;

            totalBill = numBoats * 30;
            Console.WriteLine("NumBoats: {0}", numBoats);
            Console.WriteLine("TotalBill: {0}", totalBill);
            
            Console.ReadKey();
        }
    }
}
