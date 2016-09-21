using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudent;

            Console.Write("Enter the numbers of students of Shoshi ");
            numStudent = int.Parse(Console.ReadLine());

            if ((numStudent % 2 != 0) && (numStudent % 3 != 0) && (numStudent % 4 != 0))
                Console.WriteLine("The number of students who Shoshi");
            else
                Console.WriteLine("The students isn't of Shoshi");

            Console.ReadKey();
        }
    }
}
