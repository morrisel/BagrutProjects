using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page75ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sharpGrd, algGrd, softGrd;

            Console.Write("Enter the first grade of student: ");
            sharpGrd = int.Parse(Console.ReadLine());
            Console.Write("Enter the second grade of student: ");
            algGrd = int.Parse(Console.ReadLine());
            Console.Write("Enter the third grade of student: ");
            softGrd = int.Parse(Console.ReadLine());

            if (((sharpGrd >= 80) || (algGrd >= 80)) && ((sharpGrd >= 80) || (softGrd >= 80)) && ((algGrd >= 80) || (softGrd >= 80)))
            {
                Console.WriteLine("The student passed to second year");
            }
            else
            {
                Console.WriteLine("The student can't pass to second year");
            }

            Console.ReadKey();
        }
    }
}
