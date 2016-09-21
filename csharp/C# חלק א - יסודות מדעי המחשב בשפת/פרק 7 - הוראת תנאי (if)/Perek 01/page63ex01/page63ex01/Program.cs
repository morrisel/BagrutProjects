using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page63ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark1, mark2;

            Console.WriteLine("Enter two marks");
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());

            if (mark2 - mark1 >= 5)
                Console.WriteLine("The student progressed");
        }
    }
}
