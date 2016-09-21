using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page25tar03
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 3 numbers
            // output 1 number

            int numOfYears = 3, numOfMonth = 9, numOfDays = 237;
            int sumOfDays;

            Console.WriteLine("The program is equal, how many days exist");
            Console.WriteLine("Years = {0}, Month = {1}, Days = {2}", numOfYears, numOfMonth, numOfDays);
            sumOfDays = numOfYears * 365 + numOfMonth * 30 + numOfDays;
            Console.WriteLine("The sum of all days is: {0}", sumOfDays);
            Console.ReadKey();

        }
    }
}
